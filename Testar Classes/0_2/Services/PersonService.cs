

using _0_2.Models;

namespace _0_2.Services;

internal class PersonService
{
    private List<Person> _listOfPersons = new List<Person>();
    
    public Person CreatePersonAndReturnIt(string aFirstName, string aLastName, int aAge)
    {
        Person person = new Person(aFirstName, aLastName, aAge);
             return person;
    }
    public void AddPersonToList(Person person)
    {
        _listOfPersons.Add(person);
    }
    
    public void CreatePersonAddToList(Person person) 
    {
        _listOfPersons.Add(new Person
        {
            
            FirstName = person.FirstName,
            LastName = person.LastName,
            Age = person.Age,
        });
    }
    

    public List<Person> GetAllPersons() 
    {
        return _listOfPersons;
    }

    public void UpdateCustomer() { }
    public void DeleteCustomer() { }

}
