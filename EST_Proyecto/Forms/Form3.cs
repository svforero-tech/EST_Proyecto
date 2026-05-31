using EST_Proyecto.Forms.Estructuras.Graphs;
using EST_Proyecto.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace EST_Proyecto.Forms
{
    public partial class Form3 : Form
    {
        private const int VERTEX_RADIUS = 22;

        private Dictionary<int, PointF> positions = new Dictionary<int, PointF>();

        private IGraph graph;
        private Dijkstra dijkstra;
        private ShortestPathReport report;
        private int currentSource = 0;
        private int highlightedDestination = -1;

        public Form3()
        {
            InitializeComponent();

            SetDoubleBuffered(panelGraph);

            dijkstra = new Dijkstra();

            BuildSampleGraph();

            AssignPositionsCircular(
                graph.VerticesCount,
                panelGraph.Width,
                panelGraph.Height,
                40
            );

            panelGraph.Paint += panelGraph_Paint;

            panelGraph.MouseClick += panelGraph_MouseClick;
        }

        // =====================================================
        // DOUBLE BUFFER
        // =====================================================

        private void SetDoubleBuffered(Panel panel)
        {
            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                BindingFlags.SetProperty |
                BindingFlags.Instance |
                BindingFlags.NonPublic,
                null,
                panel,
                new object[] { true }
            );
        }

        // =====================================================
        // GRAFO DE EJEMPLO
        // =====================================================

        private void BuildSampleGraph()
        {
            graph = new GraphList(8);

            for (int i = 0; i < 8; i++)
            {
                graph.AgregarVertice(
                    i,
                    i.ToString()
                );
            }

            graph.AgregarArista(0, 1, 4);
            graph.AgregarArista(0, 2, 2);

            graph.AgregarArista(1, 2, 5);
            graph.AgregarArista(1, 3, 10);

            graph.AgregarArista(2, 4, 3);

            graph.AgregarArista(4, 3, 4);

            graph.AgregarArista(3, 5, 11);

            graph.AgregarArista(4, 5, 5);

            report =
                dijkstra.BuildShortestPaths(
                    graph,
                    currentSource,
                    graph.VerticesCount
                );
        }

        // =====================================================
        // POSICIONES CIRCULARES
        // =====================================================

        private void AssignPositionsCircular( int n,int width, int height, int margin)
        {
            positions.Clear();

            if (n == 0)
            {
                return;
            }

            float cx = width / 2f;

            float cy = height / 2f;

            float r = Math.Min(width, height) / 2f  - margin - VERTEX_RADIUS;

            for (int i = 0; i < n; i++)
            {
                double angle = -Math.PI / 2 + 2 * Math.PI * i / n;
                float x =  cx + (float)(r * Math.Cos(angle));
                float y = cy + (float)(r * Math.Sin(angle));

                positions[i] = new PointF(x, y);
            }
        }

        // =====================================================
        // DIBUJAR
        // =====================================================

        private void panelGraph_Paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            DrawEdges(g);
            DrawVertices(g);
        }

        // =====================================================
        // DIBUJAR ARISTAS
        // =====================================================

        private void DrawEdges(Graphics g)
        {
            using (Pen pen = new Pen(  Color.FromArgb(120, 120, 120), 2f))
            {
                pen.CustomEndCap = new AdjustableArrowCap(5, 6);

                foreach (var edge in EnumerateEdges())
                {
                    int u = edge.Item1;
                    int v = edge.Item2;
                    double w = edge.Item3;

                    PointF pu = positions[u];
                    PointF pv = positions[v];

                    PointF a = Shrink( pu,pv, VERTEX_RADIUS + 2 );

                    PointF b = Shrink( pv, pu, VERTEX_RADIUS + 2);

                    bool highlighted = IsEdgeInShortestPath(u, v);

                    if (highlighted)
                    {
                        pen.Color = Color.Gold;
                        pen.Width = 4f;
                    }
                    else
                    {
                        pen.Color = Color.LightGray;
                        pen.Width = 2f;
                    }

                    g.DrawLine(pen, a, b );

                    PointF mid =  new PointF((a.X + b.X) / 2f, (a.Y + b.Y) / 2f);

                    using (Font fw = new Font("Segoe UI",8f,FontStyle.Regular))
                    using (Brush bw = new SolidBrush(Color.FromArgb(60,60,60)))
                    {
                        string txt =w.ToString();

                        SizeF sz =g.MeasureString( txt,fw);

                        g.DrawString( txt,fw,bw,mid.X -sz.Width / 2,mid.Y - sz.Height / 2
                        );
                    }
                }
            }
        }

        // =====================================================
        // DIBUJAR VERTICES
        // =====================================================

        private void DrawVertices(Graphics g)
        {
            foreach (var kv in positions)
            {
                int id = kv.Key;

                PointF p = kv.Value;

                RectangleF rect = new RectangleF( p.X - VERTEX_RADIUS, p.Y - VERTEX_RADIUS,VERTEX_RADIUS * 2,
                        VERTEX_RADIUS * 2 );

                Color fillColor =ColorForVertex(id);

                using (Brush fill = new SolidBrush(fillColor))
                {
                    g.FillEllipse(fill, rect);
                }

                using (Pen border =new Pen(Color.FromArgb(40, 40, 40),1.5f))
                {
                    g.DrawEllipse(border, rect);
                }

                using (Font f = new Font( "Segoe UI", 10f,FontStyle.Bold))
                using (Brush tb = new SolidBrush(Color.White))
                {
                    string text = id.ToString();

                    SizeF sz = g.MeasureString( text, f);

                    g.DrawString(text, f, tb, p.X - sz.Width / 2, p.Y - sz.Height / 2);
                }

                DrawDistanceLabel(g, id, p);
            }
        }

        // =====================================================
        // DISTANCIAS SOBRE VERTICES
        // =====================================================

        private void DrawDistanceLabel(Graphics g, int id, PointF p)
        {
            string text;

            if (double.IsPositiveInfinity(report.Distances[id]))
            {
                text = "∞";
            }
            else
            {
                text = report.Distances[id].ToString();
            }

            using (Font f = new Font("Segoe UI", 8f))
            using (Brush b =  new SolidBrush(Color.Black))
            {
                g.DrawString(text, f, b, p.X + 25, p.Y - 5);
            }
        }

        // =====================================================
        // COLOR VERTICES
        // =====================================================

        private Color ColorForVertex(int id)
        {
            if (id == currentSource)
            {
                return Color.DodgerBlue;
            }

            if (IsVertexInShortestPath(id))
            {
                return Color.Orange;
            }

            return Color.DarkSlateGray;
        }

        // =====================================================
        // CAMINO MINIMO
        // =====================================================

        private bool IsVertexInShortestPath(int vertex)
        {
            if (highlightedDestination == -1)
            {
                return false;
            }

            LinkedListaStack<int> path =dijkstra.RebuildPath(highlightedDestination,report.Previous);

            while (!path.IsEmpty())
            {
                int v = path.Pop();

                if (v == vertex)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsEdgeInShortestPath( int u,int v)
        {
            if (highlightedDestination == -1)
            {
                return false;
            }

            LinkedListaStack<int> path =dijkstra.RebuildPath(highlightedDestination,report.Previous);

            if (path.IsEmpty())
            {
                return false;
            }

            int previous = path.Pop();

            while (!path.IsEmpty())
            {
                int current = path.Pop();

                if (previous == u && current == v)
                {
                    return true;
                }

                previous = current;
            }

            return false;
        }

        // =====================================================
        // ENUMERAR ARISTAS
        // =====================================================

        private IEnumerable<(int, int, double)>
            EnumerateEdges()
        {
            for (int u = 0; u < graph.VerticesCount; u++)
            {
                foreach (int v in graph.ObtenerVecinos(u))
                {
                    double w;

                    if (graph.TryObtenerPeso(u, v, out w))
                    {
                        yield return (u, v, w);
                    }
                }
            }
        }

        // =====================================================
        // SHRINK
        // =====================================================

        private static PointF Shrink(
            PointF p1, PointF p2,float shrink)
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            float len = (float)Math.Sqrt(dx * dx + dy * dy);

            if (len <= shrink)
            {
                return p1;
            }

            return new PointF(
                p1.X + dx * shrink / len,
                p1.Y + dy * shrink / len
            );
        }

        // =====================================================
        // CLICK SOBRE VERTICE
        // =====================================================

        private void panelGraph_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            foreach (var kv in positions)
            {
                int id = kv.Key;

                PointF p = kv.Value;

                float dx = e.X - p.X;

                float dy = e.Y - p.Y;

                float dist =(float)Math.Sqrt(dx * dx + dy * dy);

                if (dist < VERTEX_RADIUS)
                {
                    currentSource = id;

                    highlightedDestination = -1;

                    report =  dijkstra.BuildShortestPaths( graph, currentSource, graph.VerticesCount );

                    panelGraph.Invalidate();

                    return;
                }
            }
        }

        // =====================================================
        // BOTON MOSTRAR CAMINO
        // =====================================================

        private void btnShowPath_Click(object sender, EventArgs e)
        {
             int destination;
            if (!int.TryParse(txtDestination.Text, out destination))
            {
            MessageBox.Show("Ingrese un número válido");
            return;
            }
            
            if (destination < 0 || destination >= graph.VerticesCount)
            {
            MessageBox.Show("Nodo fuera de rango");
            return;
            }

            if (double.IsPositiveInfinity(report.Distances[destination]))
            {
                MessageBox.Show("Nodo inalcanzable");

                highlightedDestination = -1;
            }
            else
            {
                highlightedDestination =  destination;
            }
            panelGraph.Invalidate();
        }
    }
}
