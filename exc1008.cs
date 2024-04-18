internal class beecrowd
{
    private static void Main(string[] args)
    {
        int number, qtdHoras;
        double salario, valorHora;
        number = Convert.ToInt32(Console.ReadLine());
        qtdHoras = Convert.ToInt32(Console.ReadLine());
        valorHora = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {qtdHoras * valorHora:F2}");
    }
}