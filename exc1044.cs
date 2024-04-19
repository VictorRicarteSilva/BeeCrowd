internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(entrada[0]),
            B = Convert.ToInt32(entrada[1]);
        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
        string[] entrada = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(entrada[0]),
            B = Convert.ToInt32(entrada[1]);
        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}