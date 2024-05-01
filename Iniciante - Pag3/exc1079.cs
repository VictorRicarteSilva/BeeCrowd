internal class beecrowd
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++) 
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double mediaPonderada = 0;
            mediaPonderada += Convert.ToDouble(entrada[0]) * 2;
            mediaPonderada += Convert.ToDouble(entrada[1]) * 3;
            mediaPonderada += Convert.ToDouble(entrada[2]) * 5;
            Console.WriteLine($"{mediaPonderada / 10:F1}");
        }
    }
}