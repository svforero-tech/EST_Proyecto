namespace EST_Proyecto
{
    class LinkedLista<T> : ILista<T>
    {
        private NodeDouble<T> head;

        public LinkedLista()
        {
            head = null; // La lista esta vacia, entonces es null, aún no se hace referencia a nada 
        }

        public void AddFirst(T dato)
        {
            NodeDouble<T> newNode = new NodeDouble<T>(dato);
            newNode.Next = head; // Para que el nodo apunte a la cabeza 
            head = newNode; // La cabeza empieza apuntar al nuevo nodo
        }

        public void AddLast(T dato)
        {
            NodeDouble<T> newNode = new NodeDouble<T>(dato);

            if (head == null) // Si la cabeza esta vacia, el ultimo es el primero
            {
                head = newNode;
                return;
            }

            NodeDouble<T> actualNode = head; //El nodo actual es la cabeza para empezar a buscar

            while (actualNode.Next != null) // Mientras no sea null, siga buscando (recorrer hasta el final)
            {
                actualNode = actualNode.Next; // Si no es null, el nodo actual es el siguiente en la lista
            }

            actualNode.Next = newNode; // Cuando el siguiente sea null, agregue el nuevo valor 
        }

        public void InsertAt(T dato, int index)
        {
            NodeDouble<T> actualNode = head; //El nodo atual es la cabeza 
            int Count = 1; // inicia el contador
            while (actualNode.Next != null && Count < index -1) // Mientras el nodo siguiente no sea nulo y el contador sea menor q la posicion -1
            { 
                actualNode = actualNode.Next; // Recorra los nodos 
                Count++; // Suma al contador 
            }
           

            NodeDouble<T> NewNode = new NodeDouble<T>(dato); // Crea el nuevo nodo, que almacena el dato
            NewNode.Next = actualNode.Next; // El nodo siguiente al nuevo es igual al siguiente de la Cuenta
            actualNode.Next = NewNode; // El nodo siguiente al actual apunta al nuevo nodo

            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }

        }

        public void RemoveFirst()//Elimina el primer nodo
        {
            if (head == null)
            { return; }
            head = head.Next;
            

        }

        public void RemoveLast()//Elimina el ultimo
        {
            if (head == null) return;
            if (head.Next == null)
            {
                head = null;
                return;

            }

            NodeDouble<T> actual = head;
            while (actual.Next.Next != null) 
            {
                actual = actual.Next; 
            }
                actual.Next = null;
            
        }


        public void Print()//imprime los nodos agregados
        {
            NodeDouble<T> actualNode = head;
            while (actualNode != null)
            {
                Console.Write(actualNode.Data + " -> ");
                actualNode = actualNode.Next;

            }

            Console.Write("null");

        }

        public void Remove(T dato)//Elimina un nodo en específico
        {
            if (head == null) return;
            if (head.Data.Equals(dato)) RemoveFirst();
            NodeDouble<T> actual = head;

            while (actual.Next != null)
            {
                if (actual.Next.Data.Equals(dato))
                {
                    actual.Next = actual.Next.Next;
                }
                actual = actual.Next;
            }
        }

        public bool Contains(T dato)//confirma si existe el dato
        {
            NodeDouble<T> actual = head;
            while (actual != null)
            {
                if (actual.Data.Equals(dato))
                {
                    return true;
                }
                actual= actual.Next;
            }
            return false;
        }

        public T GetAt(int index)//Trae el dato que se encuentra en ese nodo 
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            NodeDouble<T> actualNode = head; 
            int Count = 0; 

            while (actualNode != null)
            {
                if (Count == index -1)
                {
                    return actualNode.Data;
                }
                actualNode = actualNode.Next;
                Count++;
            }
             throw new IndexOutOfRangeException("El índice está fuera de los límites de la lista");
        }

        public int Count()//Cuenta la cantidad de nodos
        {
            NodeDouble<T> actualNode = head; 
            int Count = 1; 
            while (actualNode.Next != null) 
            {
                Count++;
                actualNode = actualNode.Next; 
            }
            return Count;
        }

        public void Clear()//Elimina todos los nodos
        {
            head = null;
        }


    }
}