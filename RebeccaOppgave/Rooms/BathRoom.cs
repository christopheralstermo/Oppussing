namespace RebeccaOppgave;

public class BathRoom : Room, IDecoration
{
    public BathRoom(string name = "Badet", string floor = "fliser", string walls = "fliser", string ceiling = "dampsperre", string door = "gammel og slitt", string window = "") 
        : base(name, floor, walls, ceiling, door, window)
    {
    }
    private static List<string> _dekorasjon = new List<string>();

    public List<string> Dekorasjon = _dekorasjon;
    
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