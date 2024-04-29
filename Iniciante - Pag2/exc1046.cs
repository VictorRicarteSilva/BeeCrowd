internal class beecrowd
{
    private static void Main(string[] args)
    {
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int inicio = Convert.ToInt32(entrada[0]),
            fim = Convert.ToInt32(entrada[1]);

        if(inicio > fim)
        {
            Console.WriteLine($"O JOGO DUROU {(24 - inicio) + fim} HORA(S)");
        }else if(inicio < fim)
        {
            Console.WriteLine($"O JOGO DUROU {fim - inicio} HORA(S)");
        }else
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
    }

}