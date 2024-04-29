internal class beecrowd
{
    private static void Main(string[] args)
    {
        string isVertebrado = Console.ReadLine();
        string animalgroup = Console.ReadLine();
        string alimentation = Console.ReadLine();

        if(isVertebrado == "vertebrado" && animalgroup == "ave")
        {
            if(alimentation == "carnivoro") { Console.WriteLine("aguia"); }
            else { Console.WriteLine("pomba"); }
        }
        if(isVertebrado == "vertebrado" && animalgroup == "mamifero")
        {
            if (alimentation == "onivoro") { Console.WriteLine("homem"); }
            else { Console.WriteLine("vaca"); }
        }
        if (isVertebrado == "invertebrado" && animalgroup == "inseto")
        {
            if((alimentation == "hematofago")) { Console.WriteLine("pulga"); }
            else { Console.WriteLine("lagarta"); }
        }
        if(isVertebrado == "invertebrado" && animalgroup == "anelideo")
        {
            if ((alimentation == "hematofago")) { Console.WriteLine("sanguessuga"); }
            else { Console.WriteLine("minhoca"); }
        }
    }

}