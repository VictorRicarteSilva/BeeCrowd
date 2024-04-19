internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int horaInicial = Convert.ToInt32(entrada[0]),
            minutoInicial = Convert.ToInt32(entrada[1]),
            horaFinal = Convert.ToInt32(entrada[2]),
            minutoFinal = Convert.ToInt32(entrada[3]);

        // Calculando a duração
        int duracaoHoras = horaFinal - horaInicial;
        int duracaoMinutos = minutoFinal - minutoInicial;

        // Ajustando os minutos e horas se necessário
        if (duracaoMinutos < 0)
        {
            duracaoMinutos += 60;
            duracaoHoras -= 1;
        }

        if (duracaoHoras < 0)
        {
            duracaoHoras += 24;
        }

        // Se o jogo durou 0 horas e 0 minutos, ele deve ter durado 24 horas
        if (duracaoHoras == 0 && duracaoMinutos == 0)
        {
            duracaoHoras = 24;
        }
        else if (duracaoHoras == 0 && minutoInicial == minutoFinal)
        {
            // Se as horas são iguais e os minutos também, o jogo durou 1 minuto
            duracaoMinutos = 1;
        }

        // Saída de resultados
        Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");

    }

}