internal class beecrowd
{
    private static void Main(string[] args)
    {
        int testes = Convert.ToInt32(Console.ReadLine());
        double coelhos = 0,
            ratos = 0,
            sapos = 0,
            cobaias = 0;

        for (int i = 0; i < testes; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            cobaias += Convert.ToInt32(entrada[0]);

            switch (Convert.ToChar(entrada[1]))
            {
                case 'C':
                    coelhos += Convert.ToInt32(entrada[0]);
                    break;
                case 'R':
                    ratos += Convert.ToInt32(entrada[0]);
                    break;
                case 'S':
                    sapos += Convert.ToInt32(entrada[0]);
                    break;
            }
        }

        Console.WriteLine($"Total: {cobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {coelhos / cobaias * 100:F2} %");
        Console.WriteLine($"Percentual de ratos: {ratos / cobaias * 100:F2} %");
        Console.WriteLine($"Percentual de sapos: {sapos / cobaias * 100:F2} %");
    }

}