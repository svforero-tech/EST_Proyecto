
namespace EST_Proyecto
{
    internal interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Peek();

        bool IsEmpty();

        int Count();
        void Clear();
    }
}
