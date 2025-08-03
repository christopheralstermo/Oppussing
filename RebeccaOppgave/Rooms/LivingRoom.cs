namespace RebeccaOppgave;

public class LivingRoom : Room, IDecoration
{
    private string _window { get; }

    public LivingRoom(string name = "Stua", string floor = "Parkett", string walls = "Blå", string ceiling = "Slitt",
        string door = "Lett billigdør", string window = "lite")
        : base(name, floor, walls, ceiling, door, window)
    {
        _window = window;
    }

    private static List<string> _dekorasjon = new List<string>();

    public string Window => _window;

    public void ShowItems()
    {
        foreach (var item in _dekorasjon)
        {
            Console.WriteLine(item);
        }
    }


    public void AddItem(string inputten)
    {
        _dekorasjon.Add(inputten);
    }
}