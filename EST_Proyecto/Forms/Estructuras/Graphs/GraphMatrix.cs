using EST_Proyecto.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EST_Proyecto.Forms.Estructuras.Graphs
{
    public class GraphMatrix : IGraph
    {
        private readonly double?[,] matrix;
        private readonly string[] names;
        private int verticesCount;

        public int VerticesCount => verticesCount;

        public GraphMatrix(int capacity)
        {
            matrix = new double?[capacity, capacity];
            names = new string[capacity];
            verticesCount = 0;
        }

        public void AgregarVertice(int id, string nombre)
        {
            names[id] = nombre;
            verticesCount++;
        }

        public void AgregarArista(int origen, int destino, double peso)
        {
            matrix[origen, destino] = peso;
        }

        public IEnumerable<int> ObtenerVecinos(int vertice)
        {
            for (int i = 0; i < verticesCount; i++)
            {
                if (matrix[vertice, i].HasValue)
                {
                    yield return i;
                }
            }
        }

        public bool TryObtenerPeso(int origen, int destino, out double peso)
        {
            if (matrix[origen, destino].HasValue)
            {
                peso = matrix[origen, destino].Value;
                return true;
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
