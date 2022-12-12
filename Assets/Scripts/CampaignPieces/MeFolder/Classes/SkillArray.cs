using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillArray
{//18 skills
    public Skill[] skillArray;
    public SkillArray()
    {
        
    }
}
public class Skill
{
    public string skillName;
    public enum statEnum { STR, DEX, CON, INTEL, WIS, CHA };    //stat type enum
    public statEnum statType;                //stat type ex Strength (STR)
    public int mod;                          //modifier from stat
    public bool prof;                        //proficiency in saving throw?
    public bool adv;                         //advantage in saving throw?
    public bool disadv;                      //disadvantage in saving throw?

    //default constructor
    public Skill()
    {
        skillName = "DefaultSkillName";
        statType = statEnum.STR;
        mod = 0;
        prof = false;
        adv = false;
        disadv = false;
    }
    //customize constructor
    public Skill(string Svname, statEnum SVType, int SVmod, bool SVprof, bool SVadv, bool SVdisadv)
    {
        skillName = Svname;
        statType = SVType;
        mod = SVmod;
        prof = SVprof;
        adv = SVadv;
        disadv = SVdisadv;
    }
    public void SkillDetails()
    {
        Debug.Log("ST Name: " + skillName +
                  "\nST Stat Type: " + statType +
                  "\nST Modifier: " + mod +
                  "\nST Prof?: " + prof +
                  "\nST ADV?: " + adv +
                  "\nST DISADV?: " + disadv);
    }
}
/*
Acrobatics (Dex)
Animal Handling (Wis)
Arcana (Int)
Athletics (Str)
Deception (Cha)
History (Int)
Insight (Wis)
Intimidation (Cha)
Investigation (Int)
Medicine (Wis)
Nature (Int)
Perception (Wis)
Performance (Cha)
Persuasion (Cha)
Religion (Int)
Sleight of Hand (Dex)
Stealth (Dex)
Survival (Wis)
*/
