using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//a script for calculating the hypothenus
//a2 + b2 = c2
//c = sq(a2 + b2
public class Hypothesus : MonoBehaviour
{
    public TMP_InputField aVariable;
    public TMP_InputField bVariable;
    public TextMeshProUGUI cVariable;
    //check a Variable (positive, less than 10,000?)
    
    public void a_VariableCheck()
    {
        if (aVariable.text == "" ||int.Parse(aVariable.text) <=0|| int.Parse(aVariable.text) > 10000) //if the number is out of bounds / les than 0 or greater than 10,000
        {
            cVariable.text = "-"; //removes number/texts and puts a dash in hypothenus
            aVariable.text = "0";
            return;
        }
        else if (bVariable.text == "" || int.Parse(bVariable.text) <= 0 || int.Parse(bVariable.text) > 10000) //check bvariable
        {
            cVariable.text = "-"; //removes number/texts and puts a dash in hypothenus
            bVariable.text = "0";
            return;
        }
        else //all clear (i hope so lol?)
        {
            float cNum = Mathf.Sqrt(int.Parse(aVariable.text) * int.Parse(aVariable.text) + int.Parse(bVariable.text) * int.Parse(bVariable.text));
            cNum = Mathf.Round(cNum * 100) / 100;
            cVariable.text = cNum.ToString(); return;
        }
    }
    public void b_VariableCheck()
    {
        if (bVariable.text == "" || int.Parse(bVariable.text) <= 0 || int.Parse(bVariable.text) > 10000) //check bvariable
        {
            cVariable.text = "-"; //removes number/texts and puts a dash in hypothenus
            bVariable.text = "0";
            return;
        }
        else if (aVariable.text == "" || int.Parse(aVariable.text) <= 0 || int.Parse(aVariable.text) > 10000) //if the number is out of bounds / les than 0 or greater than 10,000
        {
            cVariable.text = "-"; //removes number/texts and puts a dash in hypothenus
            aVariable.text = "0";
            return;
        }
        else //all clear (i hope so lol?)
        {
            float cNum = Mathf.Sqrt(int.Parse(aVariable.text) * int.Parse(aVariable.text) + int.Parse(bVariable.text) * int.Parse(bVariable.text));
            cNum = Mathf.Round(cNum * 100) / 100;
            cVariable.text = cNum.ToString();
            return;
        }
    }
}
