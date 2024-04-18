internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(entrada[0]),
            B = Convert.ToInt32(entrada[1]),
            C = Convert.ToInt32(entrada[2]),
            D = Convert.ToInt32(entrada[3]);
        if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }

}