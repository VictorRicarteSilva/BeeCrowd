internal class beecrowd
{
    private static void Main(string[] args)
    {
        int raio;
        double pi = 3.14159;
        raio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"VOLUME = {(4.0 / 3.0) * pi * Math.Pow(raio, 3.0):F3}");
    }
}