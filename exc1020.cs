internal class beecrowd
{
    private static void Main(string[] args)
    {
        int idade = Convert.ToInt32(Console.ReadLine());
        int ano, mes, dia;

        ano = idade / 365;
        idade -= ano * 365;
        mes = idade / 30;
        idade -= mes * 30;
        dia = idade;
        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");
    }

}