internal class beecrowd
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine()),
            y = Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine(soma(x, y));
    }

    public static int soma(int x, int y)
    {
        int resp = 0;
        int cont = 0;
        if (x < y)
        {
            for (cont = x + 1; cont < y; cont++)
            {
                if (cont % 2 != 0)
                {
                    resp += cont;
                }
            }
        }
        else
        {
            for (cont = y + 1; cont < x; cont++)
            {
                if (cont % 2 != 0)
                {
                    resp += cont;
                }
            }
        }
        return resp;
    }
}