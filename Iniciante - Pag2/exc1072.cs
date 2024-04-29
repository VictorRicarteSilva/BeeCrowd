internal class beecrowd
{
    private static void Main(string[] args)
    {
        int aux1 = 0, aux2 = 0, n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if(x >= 10 && x <= 20) { aux1++; }
            else { aux2++; }
        }
        Console.WriteLine($"{aux1} in");
        Console.WriteLine($"{aux2} out");
    }
}