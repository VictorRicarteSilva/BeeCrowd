using System.Collections.Generic;
using System.Linq;
internal class beecrowd
{
    private static void Main(string[] args)
    {
        List<int> x = new List<int>();

        for (int i = 1; i <= 100; i++) 
        {
            x.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine(x.Max());
        Console.WriteLine(x.IndexOf(x.Max()) + 1);

    }

}