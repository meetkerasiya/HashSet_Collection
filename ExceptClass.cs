namespace HashSet_Collection
{
    public class ExceptClass
    {
        public ExceptClass() {


            HashSet<int> set = new HashSet<int>();

            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(1);
            set.Add(5);

            HashSet<int> set2 = new HashSet<int>();

            set2.Add(7);
            set2.Add(4);
            set2.Add(6);

            set.ExceptWith(set2);
            Console.WriteLine("Except: ");
            foreach (var num in set)
            {
                Console.WriteLine(num);
            }
        }
    }
}
