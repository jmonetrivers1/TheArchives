using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    //stats
    public int str = 0;
    public int dex = 0;
    public int con = 0;
    public int intel = 0;
    public int wis = 0;
    public int cha = 0;
    //stat modifiers
    public int strModifier = 0;
    public int dexModifier = 0;
    public int conModifier = 0;
    public int intModifier = 0;
    public int wisModifier = 0;
    public int chaModifier = 0;

    //flavor
    public string primaryClass = "";
    public string race = "";
    public string alignment = "";
    public string background = "";

    public double exp = 0;
    public int totalLevel = 0;
    public int armorClass = 0;  //do calculation for them?
    public int speed = 0;
    public int intiative = 0;


    //FUNCTIONS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /* Modifier Update --> updates mod values with current player stats
    /
    */
    public void modUpdate(int value)
    {
        switch (value)
        {
            case 0:
                strModifier = statTranslate(str);
                break;
            case 1:
                dexModifier = statTranslate(dex);
                break;
            case 2:
                conModifier = statTranslate(con);
                break;
            case 3:
                intModifier = statTranslate(intel);
                break;
            case 4:
                wisModifier = statTranslate(wis);
                break;
            case 5:
                chaModifier = statTranslate(cha);
                break;
        }
    }

    //converts stats into modifiers (ex +1)
    public int statTranslate(int value)
    {
        if (value == 1)
            return -5;
        else if (value == 2 || value == 3)
            return -4;
        else if (value == 4 || value == 5)
            return -3;
        else if (value == 6 || value == 7)
            return -2;
        else if (value == 8|| value == 9)
            return -1;
        else if (value == 10 || value == 11)
            return 0;
        else if (value == 12 || value == 13)
            return 1;
        else if (value == 14 || value == 15)
            return 2;
        else if (value == 16|| value == 17)
            return 3;
        else if (value == 18 || value == 19)
            return 4;
        else if (value == 20 || value == 21)
            return 5;
        else if (value == 22 || value == 23)
            return 6;
        else if (value == 24 || value == 25)
            return 7;
        else if (value == 26 || value == 27)
            return 8;
        else if (value == 28 || value == 29)
            return 9;
        else if (value == 30)
            return 10;
        else
            return -100;
    }
}
