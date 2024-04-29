internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 1, count = 0;
        double v;
        while (i <= 6)
        {
            v = Convert.ToDouble(Console.ReadLine());
            if(v > 0) { count++; }
            i++;
        }
        Console.WriteLine($"{count} valores positivos");

    }

}