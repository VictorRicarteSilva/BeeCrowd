internal class beecrowd
{
    private static void Main(string[] args)
    {
        double n = 3.14159;
        double raio, A;
        raio = Convert.ToDouble(Console.ReadLine());
        A = n * (raio * raio);
        Console.WriteLine($"A={A.ToString("F4")}");
    }
}