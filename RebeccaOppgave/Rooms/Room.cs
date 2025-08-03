namespace RebeccaOppgave;
//Bathroom: Wallcolor: White, Tiles: None, Door: Old door, Decoration Items: Potted plant
//Bedroom:  Wallcolor: White, Tiles: None, Door: Old door,Decoration Items: Picture
//Office: Wallcolor: Pink, Tiles: None,Door: Old door, Decoration Items: None
//Kitchen: Wallcolor: White, Tiles: None, Door: New door, Decoration Items: None
//Livingroom: Wallcolor: White, Tiles: None,Door: Old door, Decoration Items: None
public class Room
{
    private protected string _name { get; }
    private protected string _floor { get; private set; }
    private protected string _walls { get; private set; }
    private protected string _ceiling { get; private set;}
    private protected string _door { get; private set;}
    private protected string _window { get; private set;}
    
    
    
    public Room(string name, string floor, string walls, string ceiling, string door, string window)
    {
        _name = name;
        _floor = floor;
        _walls = walls;
        _ceiling = ceiling;
        _door = door;
        _window = window;
    }


    public override string ToString() => $"\nRom: {_name}\nGulv: {_floor}\nVegger: {_walls}\nTak: {_ceiling}\nDør: {_door}\nVindu: {_window}\n";
    public string GetInfo => $"Rom: {_name}\nGulv: {_floor}\nVegger: {_walls}\nTak: {_ceiling}\nDør: {_door}\nVindu: {_window}";

    public string Name => _name;
    public string Floor
    {
        set => _floor = value;
    }

    public string Walls
    {
        set => _walls = value;
    }

    public string Ceiling
    {
        get => _ceiling;
        set => _ceiling = value;
    }

    public string Window
    {
        set => _window = value;
    }

    public string Door
    {
        set => _door = value;
    }
    
}