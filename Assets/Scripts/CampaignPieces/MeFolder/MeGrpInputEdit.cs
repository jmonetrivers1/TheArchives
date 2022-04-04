using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeGrpInputEdit : MonoBehaviour
{
    public int stat= -1;
    public GameObject charSheetObject;
    public GameObject inputField; //input parent object (not text file)
    //str (0)   dex (1) con (2) intel (3) str (4) wis (5) cha (6) 

    //Hold Function to transfer inputs give in Me Grp
    public void StatChange() //takes a stat, inputs it into holder and translates into mod
    {
        string value = inputField.GetComponent<TMP_InputField>().text;
        int statNum = int.Parse(value);
        CharacterSheet charSheet = charSheetObject.GetComponent<CharacterSheet>();

        switch (stat)
        {
            case 0:
                charSheet.str = statNum;
                charSheet.modUpdate(0);
                break;
            case 1:
                charSheet.dex = statNum;
                charSheet.modUpdate(1);
                break;
            case 2:
                charSheet.con = statNum;
                charSheet.modUpdate(2);
                break;
            case 3:
                charSheet.intel = statNum;
                charSheet.modUpdate(3);
                break;
            case 4:
                charSheet.wis = statNum;
                charSheet.modUpdate(4);
                break;
            case 5:
                charSheet.cha = statNum;
                charSheet.modUpdate(5);
                break;
        }

    }
}
