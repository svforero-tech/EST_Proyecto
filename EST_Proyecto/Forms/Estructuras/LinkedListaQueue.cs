
namespace EST_Proyecto
{
        class LinkedListaQueue<T> : IQueue<T>
        {
            public NodeDouble<T> front;
            public NodeDouble<T> rear;
            public int size;

            public LinkedListaQueue()
            {
                front = null;
                rear = null;
                size = 0;
            }
            public void Clear()
            {
                front = null;
                rear = null;
                size = 0;
            }

            public int Count()
            {
                return size;
            }

            public T Dequeue()
            {
                if (IsEmpty()) throw new InvalidOperationException("La cola está vacía");

                T item = front.Data;
                front = front.Next;

                if (front != null)
                {
                    front.Prev = null; // Desconectamos el nodo eliminado
                }
                else
                {
                    rear = null; // Si se vació, el rear también debe ser null
                }

                size--;
                return item;
            }

            public void Enqueue(T item)
            {
                NodeDouble<T> newNode = new NodeDouble<T>(item);

                if (front == null)
                {
                    front = rear = newNode;
                }
                else
                {
                    rear.Next = newNode;
                    newNode.Prev = rear;
                    rear = newNode;
                }
                size++;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public T Peek()
            {
                if (IsEmpty()) throw new InvalidOperationException("La cola está vacía");

                return front.Data;
            }
        }
    }

