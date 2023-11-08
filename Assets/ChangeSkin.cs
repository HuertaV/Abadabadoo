using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public int skin;
    private void OnEnable()
    {
        skin = PlayerPrefs.GetInt("PlayerSkin", 0);
    }
    public void Change()
    {
        skin++; 
        if (skin > 3)
        {
            skin = 0;
        }
        PlayerPrefs.SetInt("PlayerSkin", skin);
    }
    
}
