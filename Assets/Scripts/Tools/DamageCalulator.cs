using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageCalulator : MonoBehaviour
{
    //damage decimals/fractions rounded down
    public TMP_InputField originalDamage;
    public TextMeshProUGUI halfDamage;
    public TextMeshProUGUI quarterDamage;
    public TextMeshProUGUI eigthDamage;
    public TextMeshProUGUI doubleDamage;
    public void SpellSaveDamage()
    {
        if (int.Parse(originalDamage.text) > 0) //passes check int, positive
        {
            int ogInt = int.Parse(originalDamage.text);
            //.ToString(); BELOW ROUNDS DOWN
            halfDamage.text = (ogInt/2).ToString(); 
            quarterDamage.text = (ogInt / 4).ToString();
            eigthDamage.text = (ogInt / 8).ToString();
            doubleDamage.text = (ogInt * 2).ToString();
            return;
        }
        else if (int.Parse(originalDamage.text) == 0) //equals zero
        {
            originalDamage.text = "0";
            halfDamage.text = "0"; 
            quarterDamage.text = "0"; 
            eigthDamage.text = "0"; 
            doubleDamage.text = "0"; 
        }
        else //invalid number entered
        {
            originalDamage.text = "0";
            halfDamage.text = "x"; //removes number/texts and puts an x in box
            quarterDamage.text = "x"; 
            eigthDamage.text = "x";
            doubleDamage.text = "x"; 
        }
    }

}
