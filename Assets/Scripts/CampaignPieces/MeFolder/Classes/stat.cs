using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat
{
    public string statName;         //stat name         strength
    public int statScore;           //stat score        16
    public int statMod;             //stat modifier     +3

    //basic constructor
    public stat()
    {
        statName = "Strength";
        statScore = 10;
        statMod = 0;
    }
    //customize constructor
    public stat(string sName, int sScore, int sMod)
    {
        statName = sName;
        statScore = sScore;
        statMod = sMod;
    }
    public void statDetails()
    {
        Debug.Log("Stat Name: " + statName +
                  "\nStat Score: " + statScore +
                  "\nStat Mod: " + statMod);
    }
}
