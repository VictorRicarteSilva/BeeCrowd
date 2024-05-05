internal class beecrowd
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0, z = 0, k = 0;
            while (i < n)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(entrada[0]);
                int y = Convert.ToInt32(entrada[1]);
                if (x == y || y == x + 1 || x == y + 1)
                {
                Console.WriteLine("0");
            }
                else if (x < y || x > y)
                {
                    if (x > y)
                    {
                        z = x;
                        x = y;
                        y = z;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        while (x < y - 1)
                        {
                            x += 1;
                            if (x % 2 != 0)
                            {
                                k += x;
                            }
                        }
                    }
                Console.WriteLine(k);
                k = 0;
                }
                i++;
            }

    }

}