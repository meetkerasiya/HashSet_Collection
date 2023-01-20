namespace HashSet_Collection
{
    public class UnionClass
    {
        public void UnionHashset()
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);

            HashSet<int> set2 = new HashSet<int>();

            set2.Add(7);
            set2.Add(4);
            set2.Add(6);
            Console.WriteLine("Set1: ");
            foreach (int i in set)
            {
                Console.WriteLine(i);
            }Console.WriteLine("Set2: ");
            foreach (int i in set2)
            {
                Console.WriteLine(i);
            }
            set.UnionWith(set2);
            Console.WriteLine("Union: ");
            foreach(var num in set)
            {
                Console.WriteLine(num);
            }
        }
    }
}
