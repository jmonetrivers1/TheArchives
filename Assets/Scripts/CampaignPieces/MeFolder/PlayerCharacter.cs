using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the draft base script for the PC (Player Character)
public class PlayerCharacter
{
    /*            Stat Order --> (6 stats)
                    STR (0)         DEX(1) 
                    CON (2)         INT(3) 
                    WIS (4)         CHA(5)
    */
    //stat enum
    //enum statEnum { STR, DEX, CON, INTEL, WIS,CHA };
    //stat array(6 stats)
    public string characterName;
    public stat[] statValues = new stat[6];
    public SavingThrows[] savingTValues = new SavingThrows[6];
    public Health healthValues= new Health();

}


