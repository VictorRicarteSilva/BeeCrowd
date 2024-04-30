internal class beecrowd
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if(x % 2 == 0 && x > 0) { Console.WriteLine("EVEN POSITIVE"); }
            if(x % 2 == 0 && x < 0) { Console.WriteLine("EVEN NEGATIVE"); }
            if(x % 2 != 0 && x > 0) { Console.WriteLine("ODD POSITIVE"); }
            if(x % 2 != 0 && x < 0) { Console.WriteLine("ODD NEGATIVE"); }
            if(x == 0) { Console.WriteLine("NULL"); }
        }
    }

}