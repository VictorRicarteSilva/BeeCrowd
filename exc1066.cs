using System.Linq;
internal class beecrowd
{
    private static void Main(string[] args)
    {
        int i = 0;
        int[] numbers = new int[5];
        
        while (i < 5)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        int[] pares = numbers.Where(x => x % 2 == 0).ToArray();
        Console.WriteLine($"{pares.Length} valor(es) par(es)");

        int[] impares = numbers.Where(x => x % 2 != 0).ToArray();
        Console.WriteLine($"{impares.Length} valor(es) impar(es)");

        int[] positivos = numbers.Where(x => x > 0).ToArray();
        Console.WriteLine($"{positivos.Length} valor(es) positivo(s)");

        int[] negativos = numbers.Where(x => x < 0).ToArray();
        Console.WriteLine($"{negativos.Length} valor(es) negativo(s)");
    }

}