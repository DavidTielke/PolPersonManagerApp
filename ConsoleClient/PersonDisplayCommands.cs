using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands : IPersonDisplayCommands
{
    private readonly IPersonManager _manager;

    public PersonDisplayCommands(IPersonManager manager)
    {
        _manager = manager;
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