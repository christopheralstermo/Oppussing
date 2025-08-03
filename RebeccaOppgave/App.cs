using RebeccaOppgave;

public class App
{
    
    private IntroClass introClass = new IntroClass();
    private TheRenovateChoiceLogic _theRenovateChoices = new TheRenovateChoiceLogic();
    private TheSwitches switchClass = new TheSwitches();
    string theChosenRoom;
    
    public void Run()
    {
        bool goForwardSwitch = true;
        int theRoomIndexNb = 0;
        int buildChoiceCount = 0;
        
        introClass.TheIntro(ref goForwardSwitch, ref theRoomIndexNb, Run);
        
        
        _theRenovateChoices.TheRenovateChoices
        (
            ref theRoomIndexNb, 
            ref buildChoiceCount,
            ref goForwardSwitch, 
            ref theChosenRoom
        );
        
        
        switchClass.RenovationChoiceSwitch
        (
            ref buildChoiceCount, 
            ref theRoomIndexNb, 
            Run, 
            ref theChosenRoom, 
            new WhatToChangeClass()
        );
        
    }
}












