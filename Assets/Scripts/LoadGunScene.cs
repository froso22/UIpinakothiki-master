using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGunScene : MonoBehaviour
{
    GameObject welcomeCanvas;
    // Start is called before the first frame update
    void Start()
    {
        welcomeCanvas = GameObject.Find("CanvasWelcome");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadScene()
    {
        SceneManager.LoadScene("GunScene");
        welcomeCanvas.SetActive(false) ;

    }
}
