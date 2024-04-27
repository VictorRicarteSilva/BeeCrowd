internal class beecrowd
{
    private static void Main(string[] args)
    {
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        if(salario <= 2000.00m)
        {
            Console.WriteLine("Isento");
        }
        else if(salario <= 3000.00m)
        {
            Console.WriteLine($"R$ {((salario - 2000.00m) * 0.08m):F2}");
        }
        else if(salario <= 4500.00m)
        {
            Console.WriteLine($"R$ {((salario - 3000.00m) * 0.18m + 1000.00m * 0.08m):F2}");
        }
        else
        {
            Console.WriteLine($"R$ {((salario - 4500.00m) * 0.28m + 1500.00m * 0.18m + 1000.00m * 0.08m):F2}");
        }
    }
}