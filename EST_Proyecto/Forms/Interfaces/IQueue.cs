namespace EST_Proyecto
{
    internal interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
        T Peek();

        bool IsEmpty();

        int Count();
        void Clear();
    }
}
