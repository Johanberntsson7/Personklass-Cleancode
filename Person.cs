using System.Text.Json.Serialization;

namespace Personklass_Cleancode;


public class Person
{
    public string name = "";
    public int age = 0;

    public string favoritcolor = "";
    public void Introduce(Person other)
    {
        Console.WriteLine($"Hej! {other.name}, Jag heter {name} och är {age}, och har favoritfärg {favoritcolor}");
        
    }
}       

