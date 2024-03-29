namespace HomeWork10
{
    class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList()
        {
            const int defaultCapacity = 6;
            items = new T[defaultCapacity];
            count = 0;
        }
        private void EnsureCapacity()
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length + 1);
            }
        }
        public void Add(T item)
        {
            EnsureCapacity();
            items[count++] = item;

        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Index is out of range.");
                return items[index];
            }
        }
        public int Count
        {
            get { return count; }
        }
    }

}



                
               

            
            