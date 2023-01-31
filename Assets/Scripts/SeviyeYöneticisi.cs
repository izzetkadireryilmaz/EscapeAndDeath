using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeviyeYöneticisi : MonoBehaviour
{
    public Button seviye1_button, seviye2_button, seviye3_button, seviye4_button, seviye5_button, seviye6_button, seviye7_button, seviye8_button, seviye9_button, seviye10_button, seviye11_button, seviye12_button, seviye13_button, seviye14_button, seviye15_button;
    public static bool seviye1, seviye2, seviye3, seviye4, seviye5, seviye6, seviye7, seviye8, seviye9, seviye10, seviye11, seviye12, seviye13, seviye14, seviye15;
    private void Start()
    {
        seviye1 = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if(seviye2 == true)
        {
            seviye2_button.interactable = true;
        }
        else if (seviye2 == false)
        {
            seviye2_button.interactable = false;
        }
        if (seviye3 == true)
        {
            seviye3_button.interactable = true;
        }
        else if (seviye3 == false)
        {
            seviye3_button.interactable = false;
        }
        if (seviye4 == true)
        {
            seviye4_button.interactable = true;
        }
        else if (seviye4 == false)
        {
            seviye4_button.interactable = false;
        }
        if (seviye5 == true)
        {
            seviye5_button.interactable = true;
        }
        else if (seviye5 == false)
        {
            seviye5_button.interactable = false;
        }
        if (seviye6 == true)
        {
            seviye6_button.interactable = true;
        }
        else if (seviye6 == false)
        {
            seviye6_button.interactable = false;
        }
        if (seviye7 == true)
        {
            seviye7_button.interactable = true;
        }
        else if (seviye7 == false)
        {
            seviye7_button.interactable = false;
        }
        if (seviye8 == true)
        {
            seviye8_button.interactable = true;
        }
        else if (seviye8 == false)
        {
            seviye8_button.interactable = false;
        }
        if (seviye9 == true)
        {
            seviye9_button.interactable = true;
        }
        else if (seviye9 == false)
        {
            seviye9_button.interactable = false;
        }
        if (seviye10 == true)
        {
            seviye10_button.interactable = true;
        }
        else if (seviye10 == false)
        {
            seviye10_button.interactable = false;
        }
        if (seviye11 == true)
        {
            seviye11_button.interactable = true;
        }
        else if (seviye11 == false)
        {
            seviye11_button.interactable = false;
        }
        if (seviye12 == true)
        {
            seviye12_button.interactable = true;
        }
        else if (seviye12 == false)
        {
            seviye12_button.interactable = false;
        }
        if (seviye13 == true)
        {
            seviye13_button.interactable = true;
        }
        else if (seviye13 == false)
        {
            seviye13_button.interactable = false;
        }
        if (seviye14 == true)
        {
            seviye14_button.interactable = true;
        }
        else if (seviye14 == false)
        {
            seviye14_button.interactable = false;
        }
        if (seviye15 == true)
        {
            seviye15_button.interactable = true;
        }
        else if (seviye15 == false)
        {
            seviye15_button.interactable = false;
        }
 
    }
    public void ResetButton()
    {
        SeviyeYöneticisi.seviye2 = false;
        SeviyeYöneticisi.seviye3 = false;
        SeviyeYöneticisi.seviye4 = false;
        SeviyeYöneticisi.seviye5 = false;
        SeviyeYöneticisi.seviye6 = false;
        SeviyeYöneticisi.seviye7 = false;
        SeviyeYöneticisi.seviye8 = false;
        SeviyeYöneticisi.seviye9 = false;
        SeviyeYöneticisi.seviye10 = false;
        SeviyeYöneticisi.seviye11 = false;
        SeviyeYöneticisi.seviye12 = false;
        SeviyeYöneticisi.seviye13 = false;
        SeviyeYöneticisi.seviye14 = false;
        SeviyeYöneticisi.seviye15 = false;
    }
    public void ResetButton_Ing()
    {
        SeviyeYöneticisi.seviye2 = false;
        SeviyeYöneticisi.seviye3 = false;
        SeviyeYöneticisi.seviye4 = false;
        SeviyeYöneticisi.seviye5 = false;
        SeviyeYöneticisi.seviye6 = false;
        SeviyeYöneticisi.seviye7 = false;
        SeviyeYöneticisi.seviye8 = false;
        SeviyeYöneticisi.seviye9 = false;
        SeviyeYöneticisi.seviye10 = false;
        SeviyeYöneticisi.seviye11 = false;
        SeviyeYöneticisi.seviye12 = false;
        SeviyeYöneticisi.seviye13 = false;
        SeviyeYöneticisi.seviye14 = false;
        SeviyeYöneticisi.seviye15 = false;
    }
}
