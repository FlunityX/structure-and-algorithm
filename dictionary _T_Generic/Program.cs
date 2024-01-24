namespace dictionary__T_Generic
{
    class diction<Tkey, Tvalue>
    {
        private Dictionary<Tkey, Tvalue> dictionarys;
        public diction(){
            dictionarys = new Dictionary<Tkey, Tvalue>();
        }
        public void adddic(Tkey key, Tvalue value) 
        {
            dictionarys.Add(key, value);
        }
        public void remove(Tkey key)
        {
            dictionarys.Remove(key);
        }
        public void print () 
        {
            foreach (var kvp in dictionarys) 
            {
                Console.WriteLine("key :{0} , value :{1}" ,kvp.Key ,kvp.Value);
            }
        }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            diction<int, string> _td = new diction<int, string>();
            _td.adddic(1, "hello");
            _td.adddic(2, "world");
           
            _td.remove(1);
            _td.print();
            Console.ReadLine();
        }
    }
}
