namespace RebeccaOppgave;

public class TheListAndArrayClass
{
    private List<string> _colors = new List<string>
    {
        "blå",
        "rød",
        "hvit",
        "svart",
        "aqua",
        "orange",
        "gull",
        "sølv",
        "brun",
        "gul"
    };

    private List<string> _doors = new List<string>
    {
        "gammel",
        "billig",
        "solid tre",
        "metall",
    };

    private List<string> _items = new List<string>
    {
        // Stue
        "sofa", "lenestol", "salongbord", "tv", "tv-benk", "bokhylle", "teppe", "gardiner",
        "lampe", "gulvlampe", "vase", "pynteputer", "plante", "bilde", "speil", "reol",
    
        // Kjøkken
        "kjøleskap", "ovn", "komfyr", "mikrobølgeovn", "oppvaskmaskin", "vask", "benkeplate",
        "kjøkkenbord", "stol", "krakk", "kjøkkenskap", "kjøkkenvifte", "brødrister", "kjøkkenkniv",
        "kasserolle", "stekepanne", "kjøkkenhåndkle", "kjøkkenklut", "kjøkkenvekt",
    
        // Soverom
        "seng", "madrass", "sengetøy", "dyne", "pute", "nattbord", "garderobeskap", "kommode",
        "klesstativ", "tøfler", "vekkerklokke", "sengeteppe", "kleshengere", "oppbevaringsboks",
    
        // Bad
        "toalett", "vaskeservant", "dusj", "badekar", "håndkle", "håndkleholder", "toalettbørste",
        "såpedispenser", "tannbørsteholder", "badespeil", "hyller", "vaskekurv", "skittentøyskurv",
    
        // Kontor
        "skrivebord", "kontorstol", "bokhylle", "skrivebordslampe", "datamaskin", "skjerm",
        "tastatur", "mus", "printer", "papirkurv", "notatblokk", "penneholder", "arkivskap",
    
        // Gang/Entre
        "skohylle", "klesknagger", "hattestativ", "paraplyholder", "nøkkelbrett", "postkasse",
        "dørmatte", "oppbevaringsbenk", "vegghylle",
    
        // Spisestue
        "spisebord", "spisestuestoler", "vitrmeskap", "skjenk", "duk", "lysestake", "servietter",
    
        // Barnerom
        "køyeseng", "lekegrind", "leketøy", "oppbevaringskasser", "skrivebord", "barnestol",
        "veggdekor", "nattlampe", "leketeppe",
    
        // Vaskerom
        "vaskemaskin", "tørketrommel", "tørkestativ", "strykbrett", "strykjern", "vaskemiddel",
        "klesklyper", "kleskurv",
    
        // Generelt
        "klokke", "radiator", "vifte", "luftfukter", "røykvarsler", "brannslukker", "førstehjelpsskrin"
    };

    private List<string> _windows = new List<string>
    {
        "stort",
        "lite",
        "herdet glass",
        "mosaikk",
        "rundt",
        "spesialshape"
    };

    private static List<Room> _theRoomList = new List<Room>
    {
        new BathRoom(),
        new BedRoom(),
        new Kitchen(),
        new LivingRoom(),
        new Office()
    };

    private List<string> _floor = new List<string>
    {
        "parkett",
        "linoleum",
        "betong",
        "marmor",
        "veggTilvegg-teppe",
        "fliser"
    };

    private List<string> _ceiling = new List<string>
    {
        "Takplater",
        "Dampsperre",
        "Åpen himmel",
        "Aluminiumsfolie og kleshengere av metall",
        "Tretak"
    };
    
    private string[] renovateAlternatives = 
    [
        "Bygge", 
        "Male", 
        "Dekorere/Se inventar", 
        "Få oversikt over rommet",
        "Tilbake",
        "Exit"
    ];

    public List<string> Colors => _colors;
    public List<string> Doors => _doors;
    public List<string> Windows => _windows;
    public List<string> Items => _items;
    public List<Room> TheRooms => _theRoomList;

    public List<string> Ceiling
    {
        get => _ceiling;
    }

    public string[] RenovateAlternatives => renovateAlternatives;
}