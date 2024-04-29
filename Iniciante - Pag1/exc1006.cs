internal class beecrowd
{
    private static void Main(string[] args)
    {
        double A, B, C;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        C = Convert.ToDouble(Console.ReadLine());
        double media = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;
        Console.WriteLine($"MEDIA = {media.ToString("F1")}");
    }
}