internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 1, count = 0;
        double v, media = 0;
        while (i <= 6)
        {
            v = Convert.ToDouble(Console.ReadLine());
            if (v > 0) 
            { 
                count++;
                media += v;
            }
            i++;
        }
        Console.WriteLine($"{count} valores positivos");
        Console.WriteLine($"{media / count:F1}");

    }

}