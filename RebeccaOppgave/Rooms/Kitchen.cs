namespace RebeccaOppgave;

public class Kitchen : Room , IDecoration
{
    public Kitchen(string name = "Kjøkkenet", string floor = "Linoleum", string walls = "blå", string ceiling = "slitt", string door = "", string window = "lite") 
        : base(name, floor, walls, ceiling, door, window)
    {
    }
    private static List<string> _dekorasjon = new List<string>{"Dette er kjøkkenet"};

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