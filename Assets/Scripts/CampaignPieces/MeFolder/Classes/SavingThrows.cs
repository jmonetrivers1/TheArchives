using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingThrows
{
    public string STname;
    public enum statEnum { STR, DEX, CON, INTEL, WIS, CHA };    //stat type enum
    public statEnum statType;                //stat type ex Strength (STR)
    public int mod;                          //modifier from stat
    public bool prof;                        //proficiency in saving throw?
    public bool adv;                         //advantage in saving throw?
    public bool disadv;                      //disadvantage in saving throw?

    //default constructor
    public SavingThrows()
    {
        STname = "DefaultName";
        statType = statEnum.STR;
        mod = 0;
        prof = false;
        adv = false;
        disadv = false;
    }
    //customize constructor
    public SavingThrows(string Svname, statEnum SVType, int SVmod, bool SVprof, bool SVadv, bool SVdisadv)
    {
        STname = Svname;
        statType = SVType;
        mod = SVmod;
        prof = SVprof;
        adv = SVadv;
        disadv = SVdisadv;
    }
    public void SavingThrowsDetails()
    {
        Debug.Log("ST Name: " + STname +
                  "\nST Stat Type: " + statType +
                  "\nST Modifier: " + mod +
                  "\nST Prof?: " + prof +
                  "\nST ADV?: " + adv +
                  "\nST DISADV?: " + disadv);
    }

}
