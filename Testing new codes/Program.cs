using System.Collections;

namespace Testing_new_codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            /* int[,] myArray1 = new int[,] {
                 { 1, 2 }
                ,{ 3, 4 }
             };

             int[][] myArray2 = new int[][] {
                 new int[] { 1, 5 }
                ,new int[] { 3, 4 }
             };
             Console.WriteLine(myArray2.Max(x => x.Max()));
             IEnumerator enumerator = myArray2.GetEnumerator();
             while (enumerator.MoveNext())
             {
                 Console.WriteLine(enumerator.Current);
             }
             Console.ReadLine();*/
            List<string> result=new List<string>();
            result.Add("a");
            Console.WriteLine(result[0]);
        }
    }

    public class Item
    {
        public  int Bas { get; init; } = 0;
        Item(int a)
        {
            Bas= a;
        }
    } 
}