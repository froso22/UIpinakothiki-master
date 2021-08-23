/*using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class LanguageIcon : MonoBehaviour
{
    public Sprite OnSprite;
    public Sprite OffSprite;
    Image icon;
    Button lang;
    // Start is called before the first frame update
    void Start()
    {
        icon=GameObject.Find("Language").GetComponent<Image>();
        lang = GameObject.Find("Language").GetComponent<Button>();
        lang.onClick.AddListener(changeLangIcon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     void changeLangIcon()
    {
        if (icon.sprite== OnSprite)
        {
            icon.sprite = OffSprite;
        }
        else
        {
            icon.sprite = OnSprite;

        }
        
    }
}*/
