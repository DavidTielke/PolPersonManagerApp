using Configuration;
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

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;
    private readonly IConfigurator _config;
    private readonly int AGE_TRESHOLD;

    public PersonManager(IPersonRepository repository,
        IConfigurator config)
    {
        _config = config;
        AGE_TRESHOLD = _config.GetValue<int>("AgeTreshold");
        _repository = repository;
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository
            .Query()
            .Where(p => p.Age >= AGE_TRESHOLD);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _repository
            .Query()
            .Where(p => p.Age < AGE_TRESHOLD);
    }
}