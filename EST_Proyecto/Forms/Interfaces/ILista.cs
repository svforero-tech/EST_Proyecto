
namespace EST_Proyecto
{
    public interface ILista<T> 
    {
        void AddFirst(T dato);
        void AddLast(T dato);
        void InsertAt(T dato, int index);
        void RemoveFirst();
        void RemoveLast();
        void Remove(T dato);
        bool Contains(T dato);
        T GetAt(int index);
        int Count ();
        void Clear();
        void Print();
    }
}
