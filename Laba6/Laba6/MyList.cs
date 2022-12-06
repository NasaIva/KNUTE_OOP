namespace Laba6
{
    internal class MyList<T>
    {
        T[] list = new T[0];

        public T this[int i]
        {
            get
            {
                if (i > list.Length && i < 0) throw new IndexOutOfRangeException();
                return list[i];
            }

            set
            {
                if (i > list.Length && i < 0) throw new IndexOutOfRangeException();
                list[i] = value;
            }

        }
        public void Add(T value)
        {
            T[] newList = new T[GetLength() + 1];
            list.CopyTo(newList, 0);
            newList[GetLength()] = value;
            list = newList;

        }

        public void Remove(T value)
        {
            int i = Array.IndexOf(list, value);

            if (i == -1)
            {
                Console.WriteLine("Error: Element not found");
                return;
            }

            for (int j=i; j<GetLength()-1; j++)
            {
                list[j] = list[j+1];
            }
            Array.Resize(ref list, GetLength() - 1);
        }

        public T GetValue(int index)
        {
            return list[index];
        }

        public int GetLength()
        {
            return list.Length;
        }

        public void PrintList()
        {
            foreach (T value in list)
            {
                System.Console.Write(value.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
