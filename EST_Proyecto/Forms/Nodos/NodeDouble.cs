
namespace EST_Proyecto
{
     class NodeDouble<T>
    {
        public T Data;
        public NodeDouble<T> Next;
        public NodeDouble<T> Prev;


        public NodeDouble(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
