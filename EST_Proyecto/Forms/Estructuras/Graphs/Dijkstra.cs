using EST_Proyecto.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EST_Proyecto.Forms.Estructuras.Graphs
{
    public class Dijkstra
    {
        public ShortestPathReport BuildShortestPaths(IGraph graph, int source, int totalVertices)
        {
            double[] dist = new double[totalVertices];

            int[] prev =new int[totalVertices];

            bool[] visited =new bool[totalVertices];

            for (int i = 0; i < totalVertices; i++)
            {
                dist[i] = double.PositiveInfinity;

                prev[i] = -1;

                visited[i] = false;
            }

            dist[source] = 0;

            ShortestPathReport report = new ShortestPathReport(dist, prev );

            for (int count = 0;count < totalVertices; count++)
            {
                int u = ExtractMin(dist,visited);

                if (u == -1)
                {
                    break;
                }

                visited[u] = true;

                TraceSnapshot snapshot = new TraceSnapshot(u,(double[])dist.Clone(),(int[])prev.Clone());

                foreach (int neighbor in graph.ObtenerVecinos(u))
                {
                    if (visited[neighbor])
                    {
                        continue;
                    }

                    double weight;

                    if (graph.TryObtenerPeso( u, neighbor, out weight))
                    {
                        double candidate = dist[u] + weight;
                        bool updated = false;

                        if (candidate < dist[neighbor])
                        {
                            dist[neighbor] = candidate;
                            prev[neighbor] = u;
                            updated = true;
                        }

                        snapshot.Relaxations.Enqueue( new RelaxationStep(u, neighbor, candidate, updated));
                    }
                }

                report.Trace.Enqueue(snapshot);
            }

            return report;
        }

        private int ExtractMin(double[] dist, bool[] visited)
        {
            double min = double.PositiveInfinity;
            int index = -1;
            for (int i = 0; i < dist.Length; i++)
            {
                if (!visited[i]
                    && dist[i] < min)
                {
                    min = dist[i];
                    index = i;
                }
            }

            return index;
        }

        public LinkedListaStack<int> RebuildPath(int destination,int[] prev)
        {
            LinkedListaStack<int> path = new LinkedListaStack<int>();

            int current = destination;
            while (current != -1)
            {
                path.Push(current);
                current = prev[current];
            }
            return path;
        }
    }
}
