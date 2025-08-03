namespace RebeccaOppgave;

public class WhatToChangeClass
{
    private TheSwitches switchClass = new TheSwitches();

    public void WhatToChange(ref string theChosenRoom, Action run)
    {
        bool theInnerSwitch = true;
        int detailListNb = 0;
        string[] detailList = ["Dør", "Vindu", "Fliser", "Tak", "Tilbake"];
        while (theInnerSwitch)
        {
            Console.WriteLine($"""
                               Velg:
                               - Ny dør
                               - Sett inn nytt vindu
                               - Legg fliser
                               - Fiks tak
                               - Tilbake

                               {detailList[detailListNb]}
                               """);

            switchClass.WhatToDoWithTheRoomSwitch(ref detailListNb, detailList, ref theInnerSwitch);
        }

        switchClass.WhatToChangeInTheRoomSwitch(theChosenRoom, run, detailList, detailListNb);

        run();
    }

    public void WhatToPaint(ref string theChosenRoom, Action run, TheListAndArrayClass theList, KeyPressClass theKeys)
    {
        string[] paintJobAlternatives = ["Tak", "Vegger", "Alt", "Tilbake"];
        int paintJobIndexNb = 0;
        bool paintJobSwitch = true;
        string theChosenPaintAlternative = null;
        while (paintJobSwitch)
        {
            Console.WriteLine($"""
                               Hva vil du male?
                               
                               Ditt valg: {paintJobAlternatives[paintJobIndexNb]}
                               
                               """);
            ConsoleKeyInfo thePaintingChoice = Console.ReadKey();
            Console.Clear();
            
            switchClass.PaintJobAlternativeSwitch(thePaintingChoice, ref paintJobIndexNb, paintJobAlternatives, ref theChosenPaintAlternative, ref paintJobSwitch);
            
            
            foreach (var room in theList.TheRooms)
            {
                if (room.Name == theChosenRoom)
                {
                    switchClass.TheChosenPaintjobAlternativeSwitch(theChosenRoom, run, theList, theChosenPaintAlternative, room);
                }
            }
        }

    }

    


    public void WhatToDecorate(ref string theChosenRoom, Action run, TheListAndArrayClass theList, KeyPressClass theKeys)
    {
        string[] decorateChoices = ["Dekorere", "Se inventar"];
        int deocrateChoiceNb = 0;
        bool decoSwitch = true;
        while (decoSwitch)
        {
            Console.WriteLine($"""
                              Vil du:
                              - Dekorere
                              - Se inventar
                              
                              Ditt valg: {decorateChoices[deocrateChoiceNb]}
                              """);
            ConsoleKeyInfo theDecoChoice = Console.ReadKey();
            Console.Clear();
            
            switchClass.DeocrateChoice(theChosenRoom, theDecoChoice, ref deocrateChoiceNb, decorateChoices, ref decoSwitch);
        }
    }

    
}
    

