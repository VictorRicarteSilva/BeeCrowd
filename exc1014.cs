internal class beecrowd
{
    private static void Main(string[] args)
    {
        int distancia;
        double combustivel;
        distancia = Convert.ToInt32(Console.ReadLine());
        combustivel = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{distancia / combustivel:F3} km/l");
    }
}