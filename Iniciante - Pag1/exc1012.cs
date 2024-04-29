internal class beecrowd
{
    private static void Main(string[] args)
    {
        double A, B, C;
        string entrada = Console.ReadLine();
        string[] instanciacao = entrada.Split(' ');
        A = Convert.ToDouble(instanciacao[0]);
        B = Convert.ToDouble(instanciacao[1]);
        C = Convert.ToDouble(instanciacao[2]);
        Console.WriteLine($"TRIANGULO: {A * C / 2:F3}");
        Console.WriteLine($"CIRCULO: {3.14159 * Math.Pow(C, 2.0):F3}");
        Console.WriteLine($"TRAPEZIO: {(A + B) * C / 2:F3}");
        Console.WriteLine($"QUADRADO: {B * B:F3}");
        Console.WriteLine($"RETANGULO: {A * B:F3}");

    }
}