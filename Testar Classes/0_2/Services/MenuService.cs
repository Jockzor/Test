using _0_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_2.Services
{
    internal class MenuService
    {
        private PersonService personService = new PersonService();

        public void MainMenu()
        {
            //"""
            //tre st citattecken så kan man
            //skriva fritext
            //med radbrytning 
            //"""
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add person\n2. Display all persons\n3. Display specific person\n4. Remove person");
                Console.Write("Enter an option: ");
                var option = Console.ReadLine();

                switch(option) 
                {
                    case "1":
                        CreateMenu();
                    break;
                    case "2":
                        ListAllMenu();
                    break;
                    case "3":

                    break;
                    case "4":

                    break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
        public void CreateMenu()
        {
            Console.Clear();

            //Person person = new Person();
            Console.WriteLine("Create person");
            Console.WriteLine("-------------");
            Console.Write("Enter firstname: ");
            string FirstName = Console.ReadLine()!;
            Console.Write("Enter lastname: ");
            string LastName = Console.ReadLine()!;
            Console.Write("Enter age: ");
            int Age = int.Parse(Console.ReadLine()!);

            Person createdPerson = personService.CreatePersonAndReturnIt( FirstName, LastName, Age);
            personService.AddPersonToList( createdPerson );
            

            Console.WriteLine("Person was added.");
            Console.ReadKey();
        }

        public void ListAllMenu()
        {
            Console.Clear();
            Console.WriteLine("All persons");
            Console.WriteLine("-----------");
            if (!personService.GetAllPersons().Any())
                Console.WriteLine("No persons to display");
           
            else
            {
                foreach (Person person in personService.GetAllPersons())
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
                }
            }
            Console.ReadKey();
        }

    }
}
