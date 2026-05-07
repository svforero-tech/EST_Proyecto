
namespace EST_Proyecto
{
   class NodeTree<T>
    {
        public T Value;
        public NodeTree<T> Left;
        public NodeTree<T> Right;
        public NodeTree(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
