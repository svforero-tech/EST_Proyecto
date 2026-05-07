
namespace EST_Proyecto
{
     class ListaEnlazada
    {

        private Node head;
        public ListaEnlazada ()
        {
            head = null; // La lista esta vacia, entonces es null, aún no se hace referencia a nada 
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data); 
            newNode.Next = head; // Para que el nodo apunte a la cabeza 
            head = newNode; // La cabeza empieza apuntar al nuevo nodo
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null) // Si la cabeza esta vacia, el ultimo es el primero
            {
                head = newNode;
                return;
            }

            Node actualNode = head; //El nodo actual es la cabeza para empezar a buscar

            while (actualNode.Next != null) // Mientras no sea null, siga buscando (recorrer hasta el final)
            {
                actualNode = actualNode.Next; // Si no es null, el nodo actual es el siguiente en la lista
            }

            actualNode.Next = newNode; // Cuando el siguiente sea null, agregue el nuevo valor 
        }

        public void Print()
        {
            Node actualNode = head;
            while (actualNode != null) 
            {
                Console.Write(actualNode.Data + " -> ");
                actualNode = actualNode.Next;

            }

            Console.Write("null");

        }


    }
}
