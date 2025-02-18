namespace ConsoleClient;

public class PersonDisplayCommands
{
    private readonly PersonManager _manager;

    public PersonDisplayCommands()
    {
        _manager = new PersonManager();
    }
    public void DisplayAllAdults()
    {
        var adults = _manager.GetAllAdults().ToList();
        Console.WriteLine($"### ERWACHSENE ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }


    public void DisplayAllChildren()
    {
        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"### KINDER ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}