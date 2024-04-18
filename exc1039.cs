internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int codigo = Convert.ToInt32(entrada[0]),
            quantidade = Convert.ToInt32(entrada[1]);
        double comanda;
        switch (codigo)
        {
            case 1:
                comanda = quantidade * 4.00;
                Console.WriteLine($"Total: R$ {comanda:F2}");
                break;
            case 2:
                comanda = quantidade * 4.50;
                Console.WriteLine($"Total: R$ {comanda:F2}");
                break;
            case 3:
                comanda = quantidade * 5.00;
                Console.WriteLine($"Total: R$ {comanda:F2}");
                break;
            case 4:
                comanda = quantidade * 2.00;
                Console.WriteLine($"Total: R$ {comanda:F2}");
                break;
            case 5:
                comanda = quantidade * 1.50;
                Console.WriteLine($"Total: R$ {comanda:F2}");
                break;
        }
    }

}