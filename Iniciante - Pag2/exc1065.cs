internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 1, v, count = 0;
        while (i <= 5)
        {
            v = Convert.ToInt32(Console.ReadLine());
            if (v % 2 == 0) 
            { 
                count++;
            }
            i++;
        }
        Console.WriteLine($"{count} valores pares");

    }

}