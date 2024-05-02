internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 1;
        int j = 7;
        int aux = 0;
        while (true)
        {
            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
            }
            aux += 2;
            i += 2;
            j = 7;
            j += aux;
            if (i >= 10) { break; }
        }
    }

}