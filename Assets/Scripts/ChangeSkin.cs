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
        

    }
    private void Start()
    {
        skin = PlayerPrefs.GetInt("PlayerSkin", 0);
        skins = GameManager.instance.skins;
        if (skin > skins.Length - 1)
        {
            skin = 0;
        }
        skinImage.sprite = skins[skin];
        Debug.Log(skin);
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
        Debug.Log(skin);
    }
    
}
