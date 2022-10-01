using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonActivity : MonoBehaviour
{
    public TMP_Text TextComponent;
    public TMP_Text[] UnselectedTextComponent;
    public Color SelectedColor;
    public Color UnselectedColor;
    public GameObject SelectedDot;
    public GameObject[] UnselectedDots;
    public void CharButton_Selected()
    {
        //selected tab
        //TextComponent.fontStyle = FontStyles.Underline | FontStyles.Bold | FontStyles.SmallCaps;
        TextComponent.color = SelectedColor;
        SelectedDot.SetActive(true);
        //other tabs
        foreach (TMP_Text s in UnselectedTextComponent)
        {
            //s.fontStyle = FontStyles.Bold | FontStyles.SmallCaps;
            s.color = UnselectedColor;
        }
        foreach (GameObject d in UnselectedDots)
        {
            d.SetActive(false);
        }
    }

}
