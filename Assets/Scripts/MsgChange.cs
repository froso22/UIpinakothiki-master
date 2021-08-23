using DanielLochner.Assets.SimpleScrollSnap;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MsgChange : MonoBehaviour
{
    SimpleScrollSnap scroll;
    Text textmsg;
    // Start is called before the first frame update
    void Start()
    {
        scroll = GetComponent<SimpleScrollSnap>();
        textmsg = GameObject.Find("TextMsg").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scroll.TargetPanel == 0)
        {
            textmsg.text = "Please place yourself in front of erwtideas statue.";
            Debug.Log("erwtideas");
        }
        else if (scroll.TargetPanel == 1)
        {
            textmsg.text = "Please place yourself in front of clock statue.";
            Debug.Log("clock");
            //SceneManager.LoadScene("UIobjectsceneTemplate");
            //lang.onClick.AddListener(changeLangIcon);
        }
        else if (scroll.TargetPanel == 2)
        {
            textmsg.text = "Please place yourself in front of gun exhibit.";
            Debug.Log("gun");
        }
    }
}
