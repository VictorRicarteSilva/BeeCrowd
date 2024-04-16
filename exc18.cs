internal class beecrowd
{
    private static void Main(string[] args)
    {
        int tempo = Convert.ToInt32(Console.ReadLine());
        int velocidade = Convert.ToInt32(Console.ReadLine());
        double gasto = velocidade / 12.0 * tempo;
        Console.WriteLine($"{gasto:F3}");    
    }

}