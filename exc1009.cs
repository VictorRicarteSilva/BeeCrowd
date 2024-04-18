internal class beecrowd
{
    private static void Main(string[] args)
    {
        string nome;
        double salario, vendas;
        nome = Console.ReadLine();
        salario = Convert.ToDouble(Console.ReadLine());
        vendas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"TOTAL = R$ {salario + (vendas * 0.15):F2}");
    }
}