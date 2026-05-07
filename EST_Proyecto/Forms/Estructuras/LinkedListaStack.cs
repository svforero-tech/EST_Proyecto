
namespace EST_Proyecto
{
        class LinkedListaStack<T> : IStack<T>
        {
            private NodeDouble<T> top;
            private int size;

            public LinkedListaStack()
            {
                top = null;
                size = 0;
            }
            public void Clear()
            {
                top = null;
                size = 0;
            }

            public int Count()
            {
                return size;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public T Peek()
            {
                if (IsEmpty()) throw new InvalidOperationException("La pila está vacía");

                return top.Data;
            }

            public T Pop()
            {
                if (IsEmpty()) throw new InvalidOperationException("La pila está vacía");

                T item = top.Data;
                top = top.Next;

                if (top != null)
                {
                    top.Prev = null;
                }
                size--;

                return item;

            }

            public void Push(T item)
            {
                NodeDouble<T> newNode = new NodeDouble<T>(item);
                newNode.Next = top;

                if (top != null)
                {
                    top.Prev = newNode;
                }

                top = newNode;
                size++;
            }
        }
    }

