internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        
        double x1 = Convert.ToDouble(linha1[0]);
        double y1 = Convert.ToDouble(linha1[1]);

        string[] linha2 = Console.ReadLine().Split(' ');

        double x2 = Convert.ToDouble(linha2[0]);
        double y2 = Convert.ToDouble(linha2[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"{distancia:F4}");    }
}