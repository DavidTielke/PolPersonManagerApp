using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands
{
    private readonly PersonManager _manager;

    public PersonDisplayCommands()
    {
        _manager = new PersonManager();
    }

    // Alle Methoden die wir geschrieben haben
    // mehr als 20 LOC
    // oder mehr als 5 Parametern
    // oder mehr als 7 Cyclomatische Komplexität
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