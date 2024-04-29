internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 0, n = Convert.ToInt32(Console.ReadLine());
        while(i <= n)
        {
            if(i % 2 != 0) { Console.WriteLine(i); }
            i++;
        }

    }

}