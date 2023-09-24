using _0_3TränaTester.InterFaces;

namespace _0_3TränaTester.Models;

internal class Person : IPerson
{
    public Person(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email.ToLower().Trim();
    }
    
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
