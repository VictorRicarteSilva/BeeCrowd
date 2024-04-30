internal class beecrowd
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10000; i++)
        {
            if(i % n == 2) { Console.WriteLine(i); }
        }
    }

}