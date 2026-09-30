namespace Personklass_Cleancode;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Console.WriteLine("Vad heter du?");
        person.name = Console.ReadLine()!;
        Console.WriteLine("Hur gammal är du?");
        person.age = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Vilken är din favoritfärg?");
        person.favoritcolor = Console.ReadLine()!;

        Person person1 = new Person();
        Console.WriteLine("Vad heter du?");
        person1.name = Console.ReadLine()!;
        Console.WriteLine("Hur gammal är du?");
        person1.age = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Vilken är din favoritfärg?");
        person1.favoritcolor = Console.ReadLine()!;
        
        person.Introduce(person1);
        person1.Introduce(person);

        
        Console.ReadLine();
    }
}
        

