namespace RebeccaOppgave;

public class Office : Room, IDecoration
{
    public Office(string name = "Kontoret", string floor = "Parkett", string walls = "Tapet", string ceiling = "Takplater", string door = "Tredør", string window = "") 
        : base(name, floor, walls, ceiling, door, window)
    {
    }

    private static List<string> _dekorasjon = new List<string>();
    
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