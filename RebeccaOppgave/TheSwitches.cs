namespace RebeccaOppgave;

public class TheSwitches
{
    private TheListAndArrayClass theList = new TheListAndArrayClass();
    private KeyPressClass theKeys = new KeyPressClass();

    public void RenovationChoiceSwitch(ref int builderChoiceCounter, ref int theRoomIndex,
        Action run, ref string theChosenRoom, WhatToChangeClass whatToChangeClass)
    {
        switch (theList.RenovateAlternatives[builderChoiceCounter])
        {
            case "Bygge":
                Console.Clear();
                whatToChangeClass.WhatToChange(ref theChosenRoom, run);
                break;

            case "Male":
                Console.Clear();
                whatToChangeClass.WhatToPaint(ref theChosenRoom, run, theList, theKeys);
                run();
                break;

            case "Dekorere/Se inventar":
                Console.Clear();
                whatToChangeClass.WhatToDecorate(ref theChosenRoom, run, theList, theKeys);
                Console.ReadKey();
                run();
                break;

            case "Få oversikt over rommet":
                Console.Clear();
                foreach (var room in theList.TheRooms)
                {
                    if (theList.TheRooms[theRoomIndex].Name == room.Name)
                    {
                        Console.WriteLine(room.GetInfo);
                    }
                }

                Console.ReadKey();
                run();
                break;

            case "Tilbake":
                run();
                break;
            
            case "Exit":
                break;
        }
    }




    public int DetailsInTheRoomSwitch(ConsoleKeyInfo theChoice, int detailListNb, string[] detailList,
        ref bool theInnerSwitch)
    {
        switch (theChoice.Key)
        {
            case ConsoleKey.LeftArrow:
            case ConsoleKey.DownArrow:
                theKeys.KeyPressLogicForArrays(ref detailListNb, "<", detailList);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.UpArrow:
                theKeys.KeyPressLogicForArrays(ref detailListNb, ">", detailList);
                break;

            case ConsoleKey.Enter:
                theInnerSwitch = false;
                break;

            default:
                Console.Clear();
                Console.WriteLine("\n\nBruk piltaster og \"Enter\"");
                Console.ReadKey();
                break;
        }

        return detailListNb;
    }


    public void RoomChoiceSwitch(ref int indexNb1, List<Room> lista, ref bool whileSwitch, ref string theChosenRoom, Action run)
    {
        
        ConsoleKeyInfo roomChoice = Console.ReadKey();
        switch (roomChoice.Key)
        {
            case ConsoleKey.LeftArrow:
            case ConsoleKey.DownArrow:
                theKeys.KeyPressLogicForClassLists(ref indexNb1, "<", lista);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.UpArrow:
                theKeys.KeyPressLogicForClassLists(ref indexNb1, ">", lista);
                break;

            case ConsoleKey.Enter:
                theChosenRoom = theList.TheRooms[indexNb1].Name;
                whileSwitch = false;
                break;            
            
            case ConsoleKey.Spacebar:
                theChosenRoom = theList.TheRooms[indexNb1].Name;
                Console.Clear();
                Console.WriteLine("\n\n*************************");
                foreach (var room in theList.TheRooms)
                {
                    Console.WriteLine(room.ToString());
                }
                Console.ReadKey();
                Console.Clear();
                run();
                break;

            default:
                Console.Clear();
                Console.WriteLine("\n\nBruk piltaster og \"Enter\"");
                Console.ReadKey();
                break;
        }
    }

    public void BuilderChoiceSwitch(ref int buildChoices, string[] lista, ref bool whileSwitch)
    {
        ConsoleKeyInfo builderChoice = Console.ReadKey();

        switch (builderChoice.Key)
        {

            case ConsoleKey.LeftArrow:
            case ConsoleKey.UpArrow:
                Console.Clear();
                theKeys.KeyPressLogicForArrays(ref buildChoices, "<", lista);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.DownArrow:
                Console.Clear();
                theKeys.KeyPressLogicForArrays(ref buildChoices, ">", lista);
                break;

            case ConsoleKey.Enter:
                whileSwitch = false;
                break;

            default:
                Console.Clear();
                Console.WriteLine("\n\nBruk piltaster og \"Enter\"");
                Console.ReadKey();
                break;
        }
    }


    public void WhatToChangeInTheRoomSwitch(string theChosenRoom, Action run, string[] detailList, int detailListNb)
    {
        switch (detailList[detailListNb])
        {
            case "Dør":
                bool doorSwitch = true;
                int doorIndexNb = 0;
                foreach (var room in theList.TheRooms)
                {
                    if (room.Name == theChosenRoom)
                    {
                        while (doorSwitch)
                        {
                            Console.WriteLine($"""
                                               Velg dør: {theList.Doors[doorIndexNb]}
                                               """);
                            ConsoleKeyInfo doorChoice = Console.ReadKey();
                            Console.Clear();
                            switch (doorChoice.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                case ConsoleKey.UpArrow:
                                    theKeys.KeyPressLogicForStringLists(ref doorIndexNb, "<", theList.Doors);
                                    break;

                                case ConsoleKey.RightArrow:
                                case ConsoleKey.DownArrow:
                                    theKeys.KeyPressLogicForStringLists(ref doorIndexNb, ">", theList.Doors);
                                    break;

                                case ConsoleKey.Enter:
                                    doorSwitch = false;
                                    break;
                            }
                        }

                        room.Door = theList.Doors[doorIndexNb];
                    }
                }

                Console.WriteLine($"Du har nå satt inn ny dør på {theChosenRoom} av typen {theList.Doors[doorIndexNb]}");
                Console.ReadKey();
                run();
                break;

            case "Vindu":
                bool windowSwitch = true;
                int windowIndexNb = 0;
                
                foreach (var room in theList.TheRooms)
                {
                    if (room.Name == theChosenRoom)
                    {
                        while (windowSwitch)
                        {
                            Console.WriteLine($"""
                                               Velg vindu: {theList.Windows[windowIndexNb]}
                                               """);
                            ConsoleKeyInfo windowChoice = Console.ReadKey();
                            Console.Clear();
                            switch (windowChoice.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                case ConsoleKey.UpArrow:
                                    theKeys.KeyPressLogicForStringLists(ref windowIndexNb, "<", theList.Windows);
                                    break;

                                case ConsoleKey.RightArrow:
                                case ConsoleKey.DownArrow:
                                    theKeys.KeyPressLogicForStringLists(ref windowIndexNb, ">", theList.Windows);
                                    break;

                                case ConsoleKey.Enter:
                                    windowSwitch = false;
                                    break;
                            }
                        }

                        room.Window = theList.Windows[windowIndexNb];
                    }
                }


                Console.WriteLine($"Du har nå satt inn nytt vindu på {theChosenRoom} av typen {theList.Windows[windowIndexNb]}");
                Console.ReadKey();
                run();
                break;
            
            case "Fliser":
                int theWallOrFloorIndexNb = 0;
                string[] theWallOrFloorChoiceList = ["vegg", "gulv"];
                bool wallOrFloorSwitch = true;
                string theFinalChoice = null;

                foreach (var room in theList.TheRooms)
                {
                    if (room.Name == theChosenRoom)
                    {
                        while (wallOrFloorSwitch)
                        {
                            Console.WriteLine($"""
                                               Vegg eller gulv?
                                               
                                               Du velger: {theWallOrFloorChoiceList[theWallOrFloorIndexNb]}
                                               """);
                            ConsoleKeyInfo wallOrFloorChoice = Console.ReadKey();
                            Console.Clear();
                            switch (wallOrFloorChoice.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                case ConsoleKey.UpArrow:
                                    theKeys.KeyPressLogicForArrays(ref theWallOrFloorIndexNb, "<", theWallOrFloorChoiceList);
                                    break;
        
                                case ConsoleKey.RightArrow:
                                case ConsoleKey.DownArrow:
                                    theKeys.KeyPressLogicForArrays(ref theWallOrFloorIndexNb, ">", theWallOrFloorChoiceList);
                                    break;
                                
                                case ConsoleKey.Enter:
                                    theFinalChoice = theWallOrFloorChoiceList[theWallOrFloorIndexNb];
                                    wallOrFloorSwitch = false;
                                    break;
                            }
                        if (theFinalChoice == "vegg")
                        {
                            room.Walls = "fliser";
                            Console.WriteLine($"Du har nå lagt fliser på veggene på {theChosenRoom}");
                        }
        
                        if (theFinalChoice == "gulv")
                        {
                            room.Floor = "fliser";
                            Console.WriteLine($"Du har nå lagt fliser på gulvet på {theChosenRoom}");
                        }
                        }
        
                        Console.ReadKey();
                    }
                }

                Console.Clear();
                break;
            
            case "Tak":
                bool ceilingSwitch = true;
                int theCeilingIndexNb = 0;
                
                foreach (var room in theList.TheRooms)
                {
                    if (room.Name == theChosenRoom)
                    {
                        while (ceilingSwitch)
                        {
                            Console.WriteLine($"""
                                               Velg tak.

                                               Du velger: {theList.Ceiling[theCeilingIndexNb]}
                                               """);
                            ConsoleKeyInfo ceilingChoice = Console.ReadKey();
                            Console.Clear();
                            switch (ceilingChoice.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                case ConsoleKey.UpArrow:
                                    theKeys.KeyPressLogicForStringLists(ref theCeilingIndexNb, "<", theList.Ceiling);
                                    break;
        
                                case ConsoleKey.RightArrow:
                                case ConsoleKey.DownArrow:
                                    theKeys.KeyPressLogicForStringLists(ref theCeilingIndexNb, ">", theList.Ceiling);
                                    break;
                                
                                case ConsoleKey.Enter:
                                    theFinalChoice = theList.Ceiling[theCeilingIndexNb];
                                    room.Ceiling = theFinalChoice;
                                    ceilingSwitch = false;
                                    break;
                            }
                        }

                    }
                }
                Console.WriteLine($"Du har nå satt inn nytt tak på {theChosenRoom} av typen {theList.Ceiling[theCeilingIndexNb]}");
                Console.ReadKey();
                run();
                break;
            
            case "Tilbake":
                run();
                break;
        }

    }

    public void WhatToDoWithTheRoomSwitch(ref int detailListNb, string[] detailList, ref bool theInnerSwitch)
    {
        ConsoleKeyInfo theChoice = Console.ReadKey();
        Console.Clear();
        switch (theChoice.Key)
        {
            case ConsoleKey.LeftArrow:
            case ConsoleKey.DownArrow:
                theKeys.KeyPressLogicForArrays(ref detailListNb, "<", detailList);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.UpArrow:
                theKeys.KeyPressLogicForArrays(ref detailListNb, ">", detailList);
                break;

            case ConsoleKey.Enter:
                theInnerSwitch = false;
                break;

            default:
                Console.Clear();
                Console.WriteLine("\n\nBruk piltaster og \"Enter\"");
                Console.ReadKey();
                break;
        }
    }

    public void PaintJobAlternativeSwitch(ConsoleKeyInfo thePaintingChoice, ref int paintJobIndexNb, string[] paintJobAlternatives,
        ref string? theChosenPaintAlternative, ref bool paintJobSwitch)
    {
        switch (thePaintingChoice.Key)
        {
            case ConsoleKey.LeftArrow:
            case ConsoleKey.DownArrow:
                theKeys.KeyPressLogicForArrays(ref paintJobIndexNb, "<", paintJobAlternatives);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.UpArrow:
                theKeys.KeyPressLogicForArrays(ref paintJobIndexNb, ">", paintJobAlternatives);
                break;

            case ConsoleKey.Enter:
                theChosenPaintAlternative = paintJobAlternatives[paintJobIndexNb];
                paintJobSwitch = false;
                break;
        }
    }
    
    
    public void TheChosenPaintjobAlternativeSwitch(string theChosenRoom, Action run, TheListAndArrayClass theList, string? theChosenPaintAlternative, Room room)
    {
        switch (theChosenPaintAlternative)
        {
            case "Tak":
                int colorIndexForCeiling = 0;
                bool colorSwitch = true;
                string theChosenColor = null;
                while (colorSwitch)
                {
                                
                    Console.WriteLine($"""
                                       Ditt fargevalg: {theList.Colors[colorIndexForCeiling]}

                                       """);
                    ConsoleKeyInfo theColorChoice = Console.ReadKey();
                    Console.Clear();
                    switch (theColorChoice.Key)
                    {
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.DownArrow:
                            theKeys.KeyPressLogicForStringLists(ref colorIndexForCeiling, "<", theList.Colors);
                            break;

                        case ConsoleKey.RightArrow:
                        case ConsoleKey.UpArrow:
                            theKeys.KeyPressLogicForStringLists(ref colorIndexForCeiling, ">", theList.Colors);
                            break;

                        case ConsoleKey.Enter:
                            theChosenColor = theList.Colors[colorIndexForCeiling];
                            if (room.Ceiling != "Åpen himmel")
                            {
                                Console.WriteLine($"Du har nå malt taket på {theChosenRoom} i fargen {theChosenColor}");
                                room.Ceiling = theChosenColor;
                            }
                            else
                            {
                                Console.WriteLine("Du må få ordnet tak først...");
                            }
                            colorSwitch = false;
                            break;
                    }
                }
                Console.ReadKey();
                run();
                break;
                        
            case "Vegger":
                int colorIndexforWalls = 0;
                bool colorSwitch2 = true;
                string theChosenColorForWalls = null;
                while (colorSwitch2)
                {
                                
                    Console.WriteLine($"""
                                       Ditt fargevalg: {theList.Colors[colorIndexforWalls]}

                                       """);
                    ConsoleKeyInfo theColorChoice = Console.ReadKey();
                    Console.Clear();
                    switch (theColorChoice.Key)
                    {
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.DownArrow:
                            theKeys.KeyPressLogicForStringLists(ref colorIndexforWalls, "<", theList.Colors);
                            break;

                        case ConsoleKey.RightArrow:
                        case ConsoleKey.UpArrow:
                            theKeys.KeyPressLogicForStringLists(ref colorIndexforWalls, ">", theList.Colors);
                            break;

                        case ConsoleKey.Enter:
                            theChosenColorForWalls = theList.Colors[colorIndexforWalls];
                            Console.WriteLine($"Du har nå malt veggene på {theChosenRoom} i fargen {theChosenColorForWalls}");
                            room.Walls = theChosenColorForWalls;
                            colorSwitch2 = false;
                            break;
                    }
                }
                Console.ReadKey();
                run();
                break;
                        
            case "Alt":
                int colorIndexforAll = 0;
                bool colorSwitch3 = true;
                string theChosenColorForAll = null;
                while (colorSwitch3)
                {
                                
                    Console.WriteLine($"""
                                       Ditt fargevalg: {theList.Colors[colorIndexforAll]}

                                       """);
                    ConsoleKeyInfo theColorChoice = Console.ReadKey();
                    Console.Clear();
                    switch (theColorChoice.Key)
                    {
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.DownArrow:
                            theKeys.KeyPressLogicForStringLists(ref colorIndexforAll, "<", theList.Colors);
                            break;

                        case ConsoleKey.RightArrow:
                        case ConsoleKey.UpArrow:
                            theKeys.KeyPressLogicForStringLists(ref colorIndexforAll, ">", theList.Colors);
                            break;

                        case ConsoleKey.Enter:
                            theChosenColorForAll = theList.Colors[colorIndexforAll];
                            if (room.Ceiling != "Åpen himmel")
                            {
                                room.Walls = theChosenColorForAll;
                                room.Ceiling = theChosenColorForAll;
                                room.Floor = theChosenColorForAll;
                                Console.WriteLine($"Du har nå malt alt på {theChosenRoom} i fargen {theChosenColorForAll}");
                            }
                            else
                            {
                                Console.WriteLine("Du må få ordnet tak først...");
                            }
                            colorSwitch3 = false;
                            break;
                    }
                }
                Console.ReadKey();
                run();
                break;
        }
    }
    
    
    public void DeocrateChoice(string theChosenRoom, ConsoleKeyInfo theDecoChoice,
        ref int deocrateChoiceNb, string[] decorateChoices, ref bool decoSwitch)
    {
        switch (theDecoChoice.Key)
        {
            case ConsoleKey.LeftArrow:
            case ConsoleKey.DownArrow:
                theKeys.KeyPressLogicForArrays(ref deocrateChoiceNb, "<", decorateChoices);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.UpArrow:
                theKeys.KeyPressLogicForArrays(ref deocrateChoiceNb, ">", decorateChoices);
                break;
                
            case ConsoleKey.Enter:
                switch (deocrateChoiceNb)
                {
                    case 0:
                        int theCount = 0;
                        int theItemNb = 0;
                        bool decorateWithItemsSwitch = true;
                        while (decorateWithItemsSwitch)
                        {
                            Console.WriteLine("""

                                              Her er et utvalg inventar du kan dekorere med:
                                              
                                              (Trykk backspace for å gå tilbake)

                                              """);
                            foreach (var theListItem in theList.Items)
                            {
                                Console.Write(theListItem + "   ");
                            }
                            Console.WriteLine($"\n\nVelg vare: {theList.Items[theItemNb]}");
                            ConsoleKeyInfo decorateItemsKey = Console.ReadKey();
                            Console.Clear();
                            switch (decorateItemsKey.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                case ConsoleKey.DownArrow:
                                    theKeys.KeyPressLogicForStringLists(ref theItemNb, "<", theList.Items);
                                    break;

                                case ConsoleKey.RightArrow:
                                case ConsoleKey.UpArrow:
                                    theKeys.KeyPressLogicForStringLists(ref theItemNb, ">", theList.Items);
                                    break;
                                    
                                case ConsoleKey.Enter:
                                    foreach (var room in theList.TheRooms)
                                    {
                                        if (room.Name == theChosenRoom)
                                        {

                                            switch (room)
                                            {
                                                case BathRoom bathRoom:
                                                    bathRoom.AddItem(theList.Items[theItemNb]);
                                                    Console.WriteLine("her er inventaret så langt: ");
                                                    bathRoom.ShowItems();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    break;
                                                        
                                                case BedRoom bedRoom:
                                                    bedRoom.AddItem(theList.Items[theItemNb]);
                                                    Console.WriteLine("her er inventaret så langt: ");
                                                    bedRoom.ShowItems();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    break;
                                                        
                                                case LivingRoom livingRoom:
                                                    livingRoom.AddItem(theList.Items[theItemNb]);
                                                    Console.WriteLine("her er inventaret så langt: ");
                                                    livingRoom.ShowItems();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    break;
                                                        
                                                case Kitchen kitchen:
                                                    kitchen.AddItem(theList.Items[theItemNb]);
                                                    Console.WriteLine("her er inventaret så langt: ");
                                                    kitchen.ShowItems();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    break;
                                                        
                                                case Office office:
                                                    office.AddItem(theList.Items[theItemNb]);
                                                    Console.WriteLine("her er inventaret så langt: ");
                                                    office.ShowItems();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    break;

                                            }
                                        }
                                            
                                    }
                                    break;
                                    
                                case ConsoleKey.Backspace:
                                    decorateWithItemsSwitch = false;
                                    break;
                            }
                        }
                        break;
                        
                    case 1:
                        foreach (var room in theList.TheRooms)
                        {
                            if (room.Name == theChosenRoom)
                            {

                                switch (room)
                                {
                                    case BathRoom bathRoom:
                                        bathRoom.ShowItems();
                                        break;

                                    case BedRoom bedRoom:
                                        bedRoom.ShowItems();
                                        break;

                                    case LivingRoom livingRoom:
                                        livingRoom.ShowItems();
                                        break;

                                    case Kitchen kitchen:
                                        kitchen.ShowItems();
                                        break;

                                    case Office office:
                                        office.ShowItems();
                                        break;

                                }
                            }
                        }

                        break;
                }
                decoSwitch = false;
                break;
        }
    }
}