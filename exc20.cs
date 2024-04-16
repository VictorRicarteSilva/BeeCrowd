internal class beecrowd
{
    private static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int horas, minutos, segundos;
        horas = N / 3600;
        N -= 3600 * horas;
        minutos = N / 60;
        N -= 60 * minutos;
        Console.WriteLine($"{horas}:{minutos}:{N}");
    }

}