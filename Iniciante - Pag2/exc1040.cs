// Wrong aswer (5%) - por conta de uma divergencia entra o C# e o beecrowd, o C# aredonda volores "0.5" para cima e o beecrowd arredonda para baixo.
internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        float N1 = float.Parse(entrada[0]),
               N2 = float.Parse(entrada[1]),
               N3 = float.Parse(entrada[2]),
               N4 = float.Parse(entrada[3]);
        float media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;
        Console.WriteLine($"Media: {media:F1}");
        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }else if (media < 5)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            float N = float.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {N:F1}");
            if ((N + media) / 2 >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {(N + media) / 2:F1}");
            }
        }
    }

}