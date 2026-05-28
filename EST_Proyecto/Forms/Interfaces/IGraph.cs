using System;
using System.Collections.Generic;
using System.Text;

namespace EST_Proyecto.Forms.Interfaces
{
    public interface IGraph
    {
        // Agregar vértices
        void AgregarVertice(int id, string nombre);

        // Agregar arista con peso
        void AgregarArista(int origen, int destino, double peso);

        // Obtener vecinos de un vértice
        IEnumerable<int> ObtenerVecinos(int vertice);

        // Intentar obtener el peso
        bool TryObtenerPeso(int origen, int destino, out double peso);
    }
}
