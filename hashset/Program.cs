namespace hashset
{
    class Myhash<T>
    {
        private HashSet<T> items;

        public Myhash()
        {
            items = new HashSet<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void PrintItems()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        Myhash<int> myhash = new Myhash<int>();
            myhash.AddItem(1);
            myhash.PrintItems();
        }
    }
}
