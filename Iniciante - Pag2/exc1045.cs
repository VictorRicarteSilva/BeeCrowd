internal class beecrowd
{
    private static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        float A = float.Parse(entrada[0]),
              B = float.Parse(entrada[1]),
              C = float.Parse(entrada[2]);

        if (A < B) { float auxiliar = A; A = B; B = auxiliar; }
        if (A < C) { float auxiliar = A; A = C; C = auxiliar; }
        if (B < C) { float auxiliar = B; B = C; C = auxiliar; }

        if (A >= (B + C))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) { Console.WriteLine("TRIANGULO RETANGULO"); }
            if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)) { Console.WriteLine("TRIANGULO OBTUSANGULO"); }
            if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2)) { Console.WriteLine("TRIANGULO ACUTANGULO"); }
            if (A == B && A == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else
            {
                if (A == B || A == C || B == C) { Console.WriteLine("TRIANGULO ISOSCELES"); }
            }
        }
    }

}