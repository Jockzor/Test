

using _0_3TränaTester.InterFaces;
using _0_3TränaTester.Models;
using System.Collections.Concurrent;

namespace _0_3TränaTester.Services;

internal class MenuService : IMenuService
{
    IPersonService personService = new PersonService();
    public void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU\n ----------------\n 1: Add person\n 2: Display person\n 3: Display all\n 4. Radera person");
            Console.Write("Ange ett alternativ: ");
            string option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    CreatePerson();
                    break;
                case "2":
                    DisplayPerson();
                    break;
                case "3":
                    DisplayAll();
                    break;
                case "4":
                    DeletePerson();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
    public void CreatePerson()
    {
        Console.Clear();
        Console.Write("Create person\n ------------\nAnge förnamn: ");
        string firstName = Console.ReadLine()!;
        Console.Write("Ange efternamn: ");
        string lastName = Console.ReadLine()!;
        Console.Write("Ange email-adress: ");
        string email = Console.ReadLine()!;
        Person person = new(firstName, lastName, email);
        personService.CreatePerson(person);

        Console.WriteLine("Person was created");
        Console.ReadKey();
    }

    public void DisplayAll()
    {
        Console.Clear();
        foreach (Person person in personService.GetAllPersons()) { Console.WriteLine($"Fullname: {person.FirstName} {person.LastName}, Email: {person.Email}"); }
        Console.ReadKey();
    }

    public void DisplayPerson()
    {
        Console.Clear() ;
        Console.Write("Hämta specifik användare\n -------------\n Ange epost-adress: ");
        string email = Console.ReadLine()!.ToLower().Trim();
        var person = personService.GetPerson(person => person.Email == email);

        if(person != null)
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Email}");
        else
            Console.WriteLine($"Kunde inte hitta någon person med epostadressen <{email}>");

        Console.ReadKey(); 

    }

    public void DeletePerson()
    {
        Console.Clear();
        Console.Write("Radera person\n ---------------\n Ange epost-adressen till den du vill radera: ");
        string email = Console.ReadLine()!.ToLower().Trim();
        var person = personService.GetPerson(person=>person.Email == email);

        if (person != null)
        {
            personService.DeletePerson(person);
            Console.WriteLine($"Tog bort {person.FirstName} {person.LastName}.");
        }
        else
            Console.WriteLine($"$Kunde inte hitta någon person med epostadressen <{email}>");
        Console.ReadKey();
    }
}
