using EST_Proyecto.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EST_Proyecto.Forms.Estructuras.Graphs
{
    public class GraphList : IGraph
    {
        private class Edge
        {
            public int Destino;
            public double Peso;

            public Edge(int destino, double peso)
            {
                Destino = destino;
                Peso = peso;
            }
        }

        private readonly DynamicArray<LinkedLista<Edge>> adjacency;
        private readonly string[] names;
        private int verticesCount;

        public int VerticesCount => verticesCount;

        public GraphList(int capacity)
        {
            adjacency = new DynamicArray<LinkedLista<Edge>>();
            names = new string[capacity];

            for (int i = 0; i < capacity; i++)
            {
                adjacency.Add(new LinkedLista<Edge>());
            }
        }

        public void AgregarVertice(int id, string nombre)
        {
            names[id] = nombre;
            verticesCount++;
        }

        public void AgregarArista(int origen, int destino, double peso)
        {
            adjacency.Get(origen)
                     .AddLast(new Edge(destino, peso));
        }

        public IEnumerable<int> ObtenerVecinos(int vertice)
        {
            LinkedLista<Edge> list =
                adjacency.Get(vertice);

            int total = list.Count();

            for (int i = 0; i < total; i++)
            {
                Edge edge = list.GetAt(i);

                yield return edge.Destino;
            }
        }

        public bool TryObtenerPeso(int origen,int destino, out double peso)
        {
            LinkedLista<Edge> list = adjacency.Get(origen);

            int total = list.Count();

            for (int i = 0; i < total; i++)
            {
                Edge edge = list.GetAt(i);

                if (edge.Destino == destino)
                {
                    peso = edge.Peso;
                    return true;
                }
            }

            peso = 0;
            return false;
        }

        public string ObtenerNombre(int id)
        {
            return names[id];
        }
    }
}
