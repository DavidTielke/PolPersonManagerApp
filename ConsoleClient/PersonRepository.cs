namespace ConsoleClient;

public class PersonRepository
{
    private readonly PersonParser _parser;
    private readonly FileReader _reader;

    public PersonRepository()
    {
        _parser = new PersonParser();
        _reader = new FileReader();
    }

    public IQueryable<Person> Query()
    {
        var lines = _reader.ReadLines("data.csv");
        var persons = lines.Select(_parser.Parse);
        return persons.AsQueryable();
    }
}