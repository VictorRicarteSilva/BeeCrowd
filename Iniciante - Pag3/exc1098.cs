internal class beecrowd
{
    private static void Main(string[] args)
    {
        float i, j, valor;

        int temp, temp2;

        for (i = 0, j = 1, valor = 0, temp = 0, temp2 = 0; i < 2.2; j++)
        {
            if (temp2 == 0)
            {
                Console.WriteLine($"I={i:F0} J={j:F0}");
            }
            else
            {
                Console.WriteLine($"I={i:F1} J={j:F1}");
            }
            temp++;

            if (temp == 3)
            {

                i += 0.2f;

                valor += 0.2f;

                j = valor;

                temp = 0;

                temp2++;
            }
            if (temp2 == 5)

                temp2 = 0;
        }
    }

}