internal class beecrowd
{
    private static void Main(string[] args)
    {
        double salario = Convert.ToDouble(Console.ReadLine());
        if(salario <= 400.00)
        {
            Console.WriteLine($"Novo salario: {salario + (salario * 0.15):F2}");
            Console.WriteLine($"Reajuste ganho: {salario * 0.15:F2}");
            Console.WriteLine("Em percentual: 15 %");
        }else if(salario <= 800.00)
        {
            Console.WriteLine($"Novo salario: {salario + (salario * 0.12):F2}");
            Console.WriteLine($"Reajuste ganho: {salario * 0.12:F2}");
            Console.WriteLine("Em percentual: 12 %");
        }else if(salario <= 1200.00)
        {
            Console.WriteLine($"Novo salario: {salario + (salario * 0.10):F2}");
            Console.WriteLine($"Reajuste ganho: {salario * 0.10:F2}");
            Console.WriteLine("Em percentual: 10 %");
        }else if(salario <= 2000.00)
        {
            Console.WriteLine($"Novo salario: {salario + (salario * 0.07):F2}");
            Console.WriteLine($"Reajuste ganho: {salario * 0.07:F2}");
            Console.WriteLine("Em percentual: 7 %");
        }
        else
        {
            Console.WriteLine($"Novo salario: {salario + (salario * 0.04):F2}");
            Console.WriteLine($"Reajuste ganho: {salario * 0.04:F2}");
            Console.WriteLine("Em percentual: 4 %");
        }
    }

}