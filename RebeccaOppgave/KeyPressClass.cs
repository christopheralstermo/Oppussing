namespace RebeccaOppgave;

public class KeyPressClass
{
    
    public void KeyPressLogicForArrays(ref int indexNumber, string compare, string[] list)
    {
        if (compare == "<")
        {
            indexNumber--;
            if (indexNumber < 0)
            {
                indexNumber = 0;
            }
        }
        else if (compare == ">")
        {
            indexNumber++;
            if (indexNumber > list.Length - 1)
            {
                indexNumber = list.Length - 1;
            }
        }
    }
    public void KeyPressLogicForStringLists(ref int indexNumber, string compare, List<string> list)
    {
        if (compare == "<")
        {
            indexNumber--;
            if (indexNumber < 0)
            {
                indexNumber = 0;
            }
        }
        else if (compare == ">")
        {
            indexNumber++;
            if (indexNumber > list.Count - 1)
            {
                indexNumber = list.Count - 1;
            }
        }
    }
    
    public void KeyPressLogicForClassLists(ref int indexNumber, string compare, List<Room> list)
    {
        if (compare == "<")
        {
            indexNumber--;
            if (indexNumber < 0)
            {
                indexNumber = 0;
            }
        }
        else if (compare == ">")
        {
            indexNumber++;
            if (indexNumber > list.Count - 1)
            {
                indexNumber = list.Count - 1;
            }
        }
    }
}