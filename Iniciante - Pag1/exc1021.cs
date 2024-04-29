internal class beecrowd
{
    private static void Main(string[] args)
    {
        double valor = Convert.ToDouble(Console.ReadLine());
        int nota100, nota50, nota20, nota10, nota5, nota2;
        int moeda1, moeda50, moeda25, moeda10, moeda5;
        
        int valorInt;
        double valorDouble, moeda01;
        // notas
        valorInt = (int)valor;
        // moedas
        valorDouble = valor - valorInt;

        // notas
        nota100 = valorInt / 100;
        valorInt -= nota100 * 100;
        nota50 = valorInt / 50;
        valorInt -= nota50 * 50;
        nota20 = valorInt / 20;
        valorInt -= nota20 * 20;
        nota10 = valorInt / 10;
        valorInt -= nota10 * 10;
        nota5 = valorInt / 5;
        valorInt -= nota5 * 5;
        nota2 = valorInt / 2;
        valorInt -= nota2 * 2;

        //moedas
        moeda1 = valorInt / 1;
        moeda50 = (int)(valorDouble / 0.50);
        valorDouble -= moeda50 * 0.50;
        moeda25 = (int)(valorDouble / 0.25);
        valorDouble -= moeda25 * 0.25;
        moeda10 = (int)(valorDouble / 0.10);
        valorDouble -= moeda10 * 0.10;
        moeda5 = (int)(valorDouble / 0.05);
        valorDouble -= moeda5 * 0.05;
        moeda01 = (valorDouble / 0.01);

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
        
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moeda01:F0} moeda(s) de R$ 0.01");    }

}