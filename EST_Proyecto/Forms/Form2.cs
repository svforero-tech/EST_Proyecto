using EST_Proyecto;
using EST_Proyecto.Forms.Interfaces;
using EST_Proyecto.Forms.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EST_Proyecto.Forms
{
    public partial class Form2 : Form
    {
        private const int NODE_RADIUS = 25;
        private const int LEVEL_HEIGHT = 80;

        private BinaryTree<int> tree;

        private Dictionary<NodeTree<int>, Point> positions = new();

        private int? _highlighted = null;
        private string traversalResult = "";

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
        private void ClearLabels()
        {
            lblResult.Text = "";
            lblHeight.Text = "Height:";
            lblCount.Text = "Count:";
            lblMin.Text = "Min:";
            lblMax.Text = "Max:";
            txtTraversal.Clear();
            txtValue.Clear();
        }

        private void AssignPositions(
            NodeTree<int> node,
            ref int counter,
            int sideMargin,
            int spacing,
            int topMargin,
            int level)
        {
            if (node == null)
                return;

            AssignPositions(
                node.Left,
                ref counter,
                sideMargin,
                spacing,
                topMargin,
                level + 1);

            int x = sideMargin + counter * spacing;

            int y = topMargin + level * LEVEL_HEIGHT;

            positions[node] = new Point(x, y);

            counter++;

            AssignPositions(
                node.Right,
                ref counter,
                sideMargin,
                spacing,
                topMargin,
                level + 1);
        }
        public Form2()
        {
            InitializeComponent();
            SetDoubleBuffered(panelTree);
            tree = new BinaryTree<int>();
            panelTree.Paint += panelTree_Paint;
            panelTree.MouseClick += panelTree_MouseClick;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValue.Text))
                {
                    MessageBox.Show("Ingrese un valor.");
                    return;
                }

                int value = int.Parse(txtValue.Text);

                if (tree is AVLTree avl)
                {
                    avl.Insert(value);
                }
                else
                {
                    tree.Insert(value);
                }

                _highlighted = null;

                ClearLabels();

                panelTree.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo se permiten números.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValue.Text))
                {
                    MessageBox.Show("Ingrese un valor.");

                    return;
                }

                int value = int.Parse(txtValue.Text);

                if (!tree.Contains(value))
                {
                    MessageBox.Show("El valor no existe.");

                    return;
                }

                if (tree is AVLTree avl)
                {
                    avl.Remove(value);
                }
                else
                {
                    tree.Remove(value);
                }

                _highlighted = null;

                ClearLabels();

                panelTree.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Solo se permiten números.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValue.Text))
                {
                    MessageBox.Show("Ingrese un valor.");

                    return;
                }

                int value = int.Parse(txtValue.Text);

                bool exists = tree.Contains(value);

                if (exists)
                {
                    lblResult.Text = "Sí existe";

                    _highlighted = value;
                }
                else
                {
                    lblResult.Text = "No existe";

                    _highlighted = null;
                }

                panelTree.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Solo se permiten números.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            try
            {
                traversalResult = "";

                PreOrderString(tree.GetRoot());

                txtTraversal.Text = traversalResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnInOrder_Click(object sender, EventArgs e)
        {
            try
            {
                traversalResult = "";

                InOrderString(tree.GetRoot());

                txtTraversal.Text = traversalResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void btnLevelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                traversalResult = "";

                LevelOrderString();

                txtTraversal.Text = traversalResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            try
            {
                lblHeight.Text = "Height: " + tree.Height();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                lblCount.Text ="Count: " + tree.Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tree.IsEmpty())
                {
                    MessageBox.Show("El árbol está vacío.");

                    return;
                }

                lblMin.Text = "Min: " + tree.Min();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                if (tree.IsEmpty())
                {
                    MessageBox.Show("El árbol está vacío.");

                    return;
                }

                lblMax.Text = "Max: " + tree.Max();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                tree.Clear();

                txtTraversal.Clear();
                ClearLabels();

                panelTree.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rbBST_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBST.Checked)
            {
                tree = new BinaryTree<int>();

                panelTree.Invalidate();
            }
        }

        private void rbAVL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAVL.Checked)
            {
                tree = new AVLTree();

                panelTree.Invalidate();
            }

        }

        private void panelTree_Paint(object sender, PaintEventArgs e)
        {
            positions.Clear();

            int counter = 0;

            AssignPositions(tree.GetRoot(), ref counter, 50, 70, 50, 0);

            DrawEdges(e.Graphics, tree.GetRoot());
            DrawNodes(e.Graphics, tree.GetRoot());
            if (tree is AVLTree avl)
            {
                DrawBalanceFactor(e.Graphics, tree.GetRoot(), avl);
            }


        }

        private void panelTree_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var item in positions)
            {
                NodeTree<int> node = item.Key;

                Point p = item.Value;

                double distance = Math.Sqrt(Math.Pow(e.X - p.X, 2) + Math.Pow(e.Y - p.Y, 2));

                if (distance <= NODE_RADIUS)
                {
                    MessageBox.Show(
                        "Valor: " + node.Value);

                    break;
                }
            }
        }
        private void DrawEdges(Graphics g, NodeTree<int> node)
        {
            if (node == null)
                return;

            Point p = positions[node];

            using (Pen pen = new Pen(Color.Black, 2F))
            {
                if (node.Left != null)
                {
                    Point pL = positions[node.Left];

                    g.DrawLine(pen, p, pL);
                }

                if (node.Right != null)
                {
                    Point pR = positions[node.Right];

                    g.DrawLine(pen, p, pR);
                }
            }

            DrawEdges(g, node.Left);

            DrawEdges(g, node.Right);
        }


        private void DrawNodes(Graphics g, NodeTree<int> node)
        {
            if (node == null)
                return;

            Point p = positions[node];

            Color color = Color.FromArgb(216, 55, 150);

            if (_highlighted != null &&
                node.Value == _highlighted)
            {
                color = Color.Gold;
            }

            Rectangle rect = new Rectangle(
                p.X - NODE_RADIUS,
                p.Y - NODE_RADIUS,
                NODE_RADIUS * 2,
                NODE_RADIUS * 2);

            using (Brush fill = new SolidBrush(color))
            {
                g.FillEllipse(fill, rect);
            }

            using (Font f = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (Brush tb = new SolidBrush(Color.White))
            {
                string text = node.Value.ToString();

                SizeF sz = g.MeasureString(text, f);

                g.DrawString(text,f,tb,p.X - sz.Width / 2, p.Y - sz.Height / 2);
            }

            DrawNodes(g, node.Left);
            DrawNodes(g, node.Right);
        }


        private void DrawBalanceFactor(Graphics g, NodeTree<int> node, AVLTree avl)
        {
            if (node == null)
                return;

            Point p = positions[node];
            int bf = avl.GetBalance(node);
            using (Font f = new Font("Segoe UI", 7F))
            using (Brush b = new SolidBrush(Color.FromArgb(0, 146, 255)))
            {
                g.DrawString(bf.ToString(), f, b, p.X + 15, p.Y - 25);
            }

            DrawBalanceFactor(g, node.Left, avl);
            DrawBalanceFactor(g, node.Right, avl);
        }

        private void PreOrderString(NodeTree<int> node)
        {
            if (node == null)
                return;

            traversalResult += node.Value + " ";

            PreOrderString(node.Left);

            PreOrderString(node.Right);
        }
        private void InOrderString(NodeTree<int> node)
        {
            if (node == null)
                return;

            InOrderString(node.Left);

            traversalResult += node.Value + " ";

            InOrderString(node.Right);
        }
        private void PostOrderString(NodeTree<int> node)
        {
            if (node == null)
                return;

            PostOrderString(node.Left);

            PostOrderString(node.Right);

            traversalResult += node.Value + " ";
        }
        private void LevelOrderString()
        {
            if (tree.GetRoot() == null)
                return;

            Queue<NodeTree<int>> queue =
                new Queue<NodeTree<int>>();

            queue.Enqueue(tree.GetRoot());

            while (queue.Count > 0)
            {
                NodeTree<int> current =
                    queue.Dequeue();

                traversalResult +=
                    current.Value + " ";

                if (current.Left != null)
                    queue.Enqueue(current.Left);

                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }
    }
}
