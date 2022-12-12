using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    public int maxHP;            //maximum health
    public int currentHP;           //current health
    public int tempHP;              //temporary health

    //basic constructor
    public Health()
    {
        maxHP = 0;
        currentHP = 0;
        tempHP = 0;
    }
    //customize constructor
    public Health(int mHP, int cHP, int tHP)
    {
        maxHP = mHP;
        currentHP = cHP;
        tempHP = tHP;
    }
    public void HealthDetails()
    {
        Debug.Log("Max Health: " + maxHP +
                  "\nCurrent Health: " + currentHP +
                  "\n Temporary Health: " + tempHP);
    }
}
