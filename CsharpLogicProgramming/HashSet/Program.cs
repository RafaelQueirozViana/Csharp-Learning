using System.Collections.ObjectModel;

namespace HashSet {
    internal class Program {
        static void Main(string[] args) {


            SortedSet<int> a = [0, 2, 4, 6, 8];
            SortedSet<int> b = [1, 3, 5, 7, 9];

            SortedSet<int> group = new SortedSet<int>(a);
            group.UnionWith(b);

            PrintCollection<int>(a);
            PrintCollection<int>(group);







        }
        public static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T item in collection) {
                System.Console.Write($"{item}, ");
            }
            System.Console.WriteLine("");
        }
    }


}
