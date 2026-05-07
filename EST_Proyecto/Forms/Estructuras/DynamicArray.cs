
namespace EST_Proyecto
{
    public class DynamicArray<T>
    {
        private T[] data;
        private int size;

        public DynamicArray(int capacity = 4)
        {
            data = new T[capacity];
            size = 0;

        }

        public void Add(T element)
        {
            if (size == data.Length) Resize();

            data[size] = element;
            size++;
        } 

        private void Resize()
        {
            T[] newData = new T[data.Length * 2];

            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }

        public T Get(int index)
        {

            if (index < 0 | index >= size)
            {
                throw new IndexOutOfRangeException();

            }
          return data[index];
        }

        public void Remove(int index)
            {

                if (index < 0 | index >= size)
                {
                    throw new IndexOutOfRangeException();
                }

                for (int i = index; i < size - 1; i++)
                {
                    data[i] = data[i + 1];
                }

                size--;
            }

        /*public int Update(int index, T elemnt)
        {
            if (index < 0 | index >= size)
            {
                throw new IndexOutOfRangeException();

            }
            data[index] = elemnt;
        }*/

        public int Count()
        {
            return size;
        }
    }
}
