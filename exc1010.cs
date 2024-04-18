internal class beecrowd
{
    private static void Main(string[] args)
    {
        int qtd1, qtd2, cod1, cod2;
        double valor1, valor2;
        string entrada1, entrada2;
        entrada1 = Console.ReadLine();
        entrada2 = Console.ReadLine();
        string[] dados = entrada1.Split(' ');
        cod1 = Convert.ToInt32(dados[0]);
        qtd1 = Convert.ToInt32(dados[1]);
        valor1 = Convert.ToDouble(dados[2]);
        string[] dados2 = entrada2.Split(' ');
        cod2 = Convert.ToInt32(dados2[0]);
        qtd2 = Convert.ToInt32(dados2[1]);
        valor2 = Convert.ToDouble(dados2[2]);
        Console.WriteLine($"VALOR A PAGAR: R$ {(valor1 * qtd1) + (valor2 * qtd2):F2}");

    }
}