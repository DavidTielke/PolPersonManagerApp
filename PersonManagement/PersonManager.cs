using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonValidator
{
    public bool IsValid(Person person)
    {
        return person != null;
    }
}

public class PersonManager
{
    private readonly PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository
            .Query()
            .Where(p => p.Age >= 18);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _repository
            .Query()
            .Where(p => p.Age < 18);
    }
}