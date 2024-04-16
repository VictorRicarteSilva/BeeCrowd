internal class beecrowd
{
    private static void Main(string[] args)
    {
        double A, B;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        double media = ((A * 3.5) + (B * 7.5)) / 11;
        Console.WriteLine($"MEDIA = {media.ToString("F5")}");
    }
}