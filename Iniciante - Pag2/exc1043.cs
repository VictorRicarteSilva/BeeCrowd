internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = (Console.ReadLine().Split(' '));
        float A = float.Parse(entrada[0]),
              B = float.Parse(entrada[1]),
              C = float.Parse(entrada[2]);

        if (A > (B - C) && A < (B + C))
        {
            Console.WriteLine($"Perimetro = {A + B + C:F1}");
        }
        else
        {
            Console.WriteLine($"Area = {(A + B) * C / 2:F1}");
        }
    }

}