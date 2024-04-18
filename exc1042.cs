internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = (Console.ReadLine().Split(' '));
        int v1 = Convert.ToInt32(entrada[0]),
            v2 = Convert.ToInt32(entrada[1]),
            v3 = Convert.ToInt32(entrada[2]);
        int[] ints = {v1 , v2 , v3 };
        Array.Sort(ints);
        Console.WriteLine(ints[0]);
        Console.WriteLine(ints[1]);
        Console.WriteLine(ints[2]);
        Console.WriteLine();
        Console.WriteLine(v1);
        Console.WriteLine(v2);
        Console.WriteLine(v3);
    }

}