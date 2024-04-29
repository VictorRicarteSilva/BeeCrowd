internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(entrada[0]),
               B = Convert.ToDouble(entrada[1]),
               C = Convert.ToDouble(entrada[2]);
        double delta, r1, r2;

        delta = (Math.Pow(B, 2)) - (4 * A * C);
        if (delta < 0 || A <= 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-B + Math.Sqrt(delta)) / (2 * A);
            r2 = (-B - Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");
    }

}