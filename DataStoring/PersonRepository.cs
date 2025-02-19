using Configuration;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _parser;
    private readonly IFileReader _reader;
    private readonly IConfigurator _config;

    public PersonRepository(IPersonParser parser, 
        IFileReader reader,
        IConfigurator config)
    {
        _parser = parser;
        _reader = reader;
        _config = config;
    }

    public IQueryable<Person> Query()
    {
        var path = _config.GetValue<string>("CsvPath");
        var lines = _reader.ReadLines(path);
        var persons = lines.Select(_parser.ParseFromCsv);
        return persons.AsQueryable();
    }
}