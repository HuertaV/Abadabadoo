using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    public int skin;
    private Sprite[] skins;
    public Image skinImage;
    private void OnEnable()
    {
        skin = PlayerPrefs.GetInt("PlayerSkin", 0);
       
    }
    private void Start()
    {
        skins = GameManager.instance.skins;
    }
    public void Change()
    {
        skin++; 
        if (skin > skins.Length - 1)
        {
            skin = 0;
        }
        skinImage.sprite = skins[skin];
        PlayerPrefs.SetInt("PlayerSkin", skin);
    }
    
}
