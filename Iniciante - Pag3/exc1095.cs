internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 1;
        int j = 60;
        while (true) 
        {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
            j -= 5;
            if(j < 0) { break; }
        }
    }

}