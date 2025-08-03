namespace RebeccaOppgave;

public class IntroClass
{
    private TheListAndArrayClass theList = new TheListAndArrayClass();
    private TheSwitches switchClass = new TheSwitches();
    string theChosenRoom;
    
    public void TheIntro(ref bool whileSwitch, ref int indexNb1, Action run)
    {
        Console.Clear();
        while (whileSwitch)
        {
            int amountOfRooms = theList.TheRooms.Count;


            Console.WriteLine($"""
                               Du har et hus med {amountOfRooms} rom.
                               
                               (Trykk space for oversikt over huset)
                               """);

            Console.WriteLine($"\nVelg rom: {theList.TheRooms[indexNb1].Name}");

            switchClass.RoomChoiceSwitch(ref indexNb1, theList.TheRooms, ref whileSwitch, ref theChosenRoom, run);
            
            Console.Clear();
        }
    }


}