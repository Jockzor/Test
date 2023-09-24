
using _0_3TränaTester.InterFaces;
using _0_3TränaTester.Models;
using Newtonsoft.Json;

namespace _0_3TränaTester.Services;

internal class PersonService : IPersonService
{
    private List<Person> _persons = new();

    public void CreatePerson(Person person)
    {
        
        _persons.Add(person);

        var json = JsonConvert.SerializeObject(_persons);
        FileService.SaveToFile(json);
    }

    public void DeletePerson(Person person)
    {
        _persons.Remove(person);
    }

    public IEnumerable<Person> GetAllPersons()
    {

        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            _persons = JsonConvert.DeserializeObject<List<Person>>(content)!;
     
        return _persons;      
    }

    public Person GetPerson(Func<Person, bool> expression)
    {
        var person = _persons.FirstOrDefault(expression);
        return person!;
    }
}
