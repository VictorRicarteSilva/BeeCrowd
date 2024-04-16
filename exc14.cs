internal class beecrowd
{
    private static void Main(string[] args)
    {
        int a, b, c;
        string entrada = Console.ReadLine();
        string[] instanciacao = entrada.Split(' ');
        a = Convert.ToInt32(instanciacao[0]);
        b = Convert.ToInt32(instanciacao[1]);
        c = Convert.ToInt32(instanciacao[2]);
        int maior = (a + b + Math.Abs(a - b)) / 2;
        Console.WriteLine($"{(maior + c + Math.Abs(maior - c)) / 2} eh o maior");

    }
}