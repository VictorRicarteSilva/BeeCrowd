internal class beecrowd
{
    private static void Main(string[] args)
    {
         string[] entrada =(Console.ReadLine().Split(' '));
         float x = float.Parse(entrada[0]),
               y = float.Parse(entrada[1]);
        if(x > 0 && y > 0) Console.WriteLine("Q1");
        if(x < 0 && y > 0) Console.WriteLine("Q2");
        if(x < 0 && y < 0) Console.WriteLine("Q3");
        if(x > 0 && y < 0) Console.WriteLine("Q4");
        if(x == 0 && y == 0) Console.WriteLine("Origem");
        if(x == 0 && y != 0) Console.WriteLine("Eixo Y");
        if(y == 0 && x != 0) Console.WriteLine("Eixo X");
    }

}