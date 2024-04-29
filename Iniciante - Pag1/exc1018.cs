internal class beecrowd
{
    private static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(N);
        int qtdNotas100, qtdNotas50, qtdNotas20, qtdNotas10, qtdNotas5, qtdNotas2, qtdNotas1;
        
        qtdNotas100 = N / 100;
        N -= 100 * qtdNotas100;
        qtdNotas50 = N / 50;
        N -= 50 * qtdNotas50;
        qtdNotas20 = N / 20;
        N -= 20 * qtdNotas20;
        qtdNotas10 = N / 10;
        N -= 10 * qtdNotas10;
        qtdNotas5 = N / 5;
        N -= 5 * qtdNotas5;
        qtdNotas2 = N / 2;
        N -= 2 * qtdNotas2;
        qtdNotas1 = N / 1;

        Console.WriteLine($"{qtdNotas100} nota(s) de R$ 100,00");
        Console.WriteLine($"{qtdNotas50} nota(s) de R$ 50,00");
        Console.WriteLine($"{qtdNotas20} nota(s) de R$ 20,00");
        Console.WriteLine($"{qtdNotas10} nota(s) de R$ 10,00");
        Console.WriteLine($"{qtdNotas5} nota(s) de R$ 5,00");
        Console.WriteLine($"{qtdNotas2} nota(s) de R$ 2,00");
        Console.WriteLine($"{qtdNotas1} nota(s) de R$ 1,00");
    
    }

}