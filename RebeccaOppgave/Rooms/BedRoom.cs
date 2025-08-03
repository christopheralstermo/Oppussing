namespace RebeccaOppgave;

public class BedRoom : Room, IDecoration
{
    public BedRoom(string name = "Soverommet", string floor = "Parkett", string walls = "Sparklet Gips", string ceiling = "Takplater", string door = "Lett dør", string window = "stort") 
        : base(name, floor, walls, ceiling, door, window)
    {
    }

    private static List<string> _dekorasjon = new List<string> { "Dette er soverommet" };

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