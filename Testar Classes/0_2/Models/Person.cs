

namespace _0_2.Models;

internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; } = null!;
    public int Age { get; set; }

    public Person()
    {
        
    }
    public Person(string aFirstName, string aLastName, int aAge)
    {
        FirstName = aFirstName;
        LastName = aLastName;
        Age = aAge;
    }
}
