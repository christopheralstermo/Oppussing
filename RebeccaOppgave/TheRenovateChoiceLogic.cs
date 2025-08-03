namespace RebeccaOppgave;

public class TheRenovateChoiceLogic
{
    private TheListAndArrayClass theList = new TheListAndArrayClass();
    private TheSwitches switchClass = new TheSwitches();
    

    public void TheRenovateChoices(ref int roomCounter, ref int buildChoices , ref bool whileSwitch, ref string theChosenRoom)
    {
        Console.Clear();
        whileSwitch = true;
        theChosenRoom = theList.TheRooms[roomCounter].Name;
        Console.Clear();
        while (whileSwitch)
        {
            Console.Write($"""
                           Hva vil du gjøre på {theChosenRoom}?

                           - Bygge (Nye dører, vindu, etc)
                           - Male
                           - Dekorere
                           - Få en oversikt over alt i rommet.
                           
                           - Tilbake
                           - Exit program

                           {theList.RenovateAlternatives[buildChoices]}

                           """);
            
            switchClass.BuilderChoiceSwitch(ref buildChoices, theList.RenovateAlternatives, ref whileSwitch);
        }
    }


}