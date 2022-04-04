using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the draft base script for the PC (Player Character)
public class PlayerCharacter : MonoBehaviour
{
    //PlayerCharacter Variables
        //Player Stats
        public class playerStats{
            public int str = 0;
            public int dex = 0;
            public int con = 0;
            public int intel = 0;
            public int wis = 0;
            public int cha = 0;
    }
        public class playerFlavor{
            public string primaryClass = "";
            public string race = "";
            public string alignment = "";
            public string background = "";
        }
        //public string[] languages = new string[]; //?

        public float exp = 0;
        public int totalLevel = 0;
        public int armorClass = 0;  //do calculation for them?
        public int speed = 0;
        public int intiative = 0;




    //debug function to relay character information
    public void PlayerInformationDebug(){
        Debug.Log("Test");
        }

}
