internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] diaInicial = Console.ReadLine().Split(' ');
        string[] horaInicial = Console.ReadLine().Replace(" ", "").Split(':');
        string[] diaFinal = Console.ReadLine().Split(' ');
        string[] horaFinal = Console.ReadLine().Replace(" ", "").Split(':');

        int di = Convert.ToInt32(diaInicial[1]);
        int hi = Convert.ToInt32(horaInicial[0]);
        int mi = Convert.ToInt32(horaInicial[1]);
        int si = Convert.ToInt32(horaInicial[2]);

        int df = Convert.ToInt32(diaFinal[1]);
        int hf = Convert.ToInt32(horaFinal[0]);
        int mf = Convert.ToInt32(horaFinal[1]);
        int sf = Convert.ToInt32(horaFinal[2]);

        int horarioInicialEmSegundos, horarioFinalEmSegundos, temp;

        horarioInicialEmSegundos = si + mi * 60 + hi * 3600 + di * 86400;
        horarioFinalEmSegundos = sf + mf * 60 + hf * 3600 + df * 86400;
        temp = horarioFinalEmSegundos - horarioInicialEmSegundos;

        Console.WriteLine($"{temp / 86400} dia(s)");
        temp %= 86400;
        Console.WriteLine($"{temp / 3600} hora(s)");
        temp %= 3600;
        Console.WriteLine($"{temp / 60} minuto(s)");
        temp %= 60;
        Console.WriteLine($"{temp} segundo(s)");
    }

}