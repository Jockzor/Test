


using _0_3TränaTester.Models;

namespace _0_3TränaTester.InterFaces;

internal interface IPersonService
{
    public void CreatePerson(Person person);
    public void DeletePerson(Person person);
    public Person GetPerson(Func<Person, bool> expression);
    public IEnumerable<Person> GetAllPersons();
}
