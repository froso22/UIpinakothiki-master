using System.Collections;
using DanielLochner.Assets.SimpleScrollSnap;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    SimpleScrollSnap scroll;
    Text textmsg;
    GameObject scrollObj;
    GameObject icon;
    Button iconButton;
    // Start is called before the first frame update
    void Start()
    {
        scrollObj = GameObject.Find("File Scroll-Snap");
        scroll = scrollObj.GetComponent<SimpleScrollSnap>();
       
        icon = GameObject.Find("clock");
        iconButton = icon.GetComponent<Button>();
        //StartCoroutine(WaitforClick());
        // textmsg = GameObject.Find("TextMsg").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        LoadSceneID();
    }

    /*IEnumerator WaitforClick()
    {
        Debug.Log("Waiting for princess to be rescued...");
        //yield return new WaitUntil(() => iconButton.onClick.AddListener(LoadSceneID));
        Debug.Log("Princess was rescued!");
    }*/
    public void LoadSceneID()
    {
        if (scroll.TargetPanel == 0)
        {
            //textmsg.text = "Please place yourself in front of erwtideas statue.";
            //Debug.Log("erwtideas");
        }
        else if (scroll.TargetPanel == 1)
        {
            //textmsg.text = "Please place yourself in front of clock statue.";
            // Debug.Log("clock");
            SceneManager.LoadScene("UIobjectsceneTemplate");
            //lang.onClick.AddListener(changeLangIcon);
        }
        else if (scroll.TargetPanel == 2)
        {
            //textmsg.text = "Please place yourself in front of gun exhibit.";
            // Debug.Log("gun");
        }
    }
}
