using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamMovement : MonoBehaviour
{
    public GameObject SubMenuPanel_Inactive;
    public GameObject SubMenuPanel_Active;
    public GameObject SubMenuPanel;
    public bool moveSubMenu;
    public bool moveSubMenuBack;
    public float moveSpeed;
    private float tempPos;
    // Start is called before the first frame update
    void Start()
    {
        SubMenuPanel.transform.position = SubMenuPanel_Inactive.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveSubMenu)
        {
            SubMenuPanel.transform.position = Vector3.Lerp(SubMenuPanel.transform.position, SubMenuPanel_Active.transform.position, moveSpeed * Time.deltaTime);

            if (SubMenuPanel.transform.localPosition.x == tempPos)//no need to move anymore
            {
                moveSubMenu = false;
                SubMenuPanel.transform.position = SubMenuPanel_Active.transform.position;
                tempPos = -999999999999999999f;//never gonna be this number
            }
            if (moveSubMenu)
            {
                tempPos = SubMenuPanel.transform.position.x;//set to current position
            }
        }
        if (moveSubMenuBack)
        {
            SubMenuPanel.transform.position = Vector3.Lerp(SubMenuPanel.transform.position, SubMenuPanel_Inactive.transform.position, moveSpeed * Time.deltaTime);

            if (SubMenuPanel.transform.localPosition.x == tempPos)//no need to move anymore
            {
                moveSubMenuBack = false;
                SubMenuPanel.transform.position = SubMenuPanel_Inactive.transform.position;
                tempPos = -999999999999999999f;//never gonna be this number
            }
            if (moveSubMenuBack)
            {
                tempPos = SubMenuPanel.transform.position.x;//set to current position
            }
        }

    }

    public void MoveSubMenu()
    {
        moveSubMenu = true;
        moveSubMenuBack = false;
    }

    public void MoveSubMenuBack()
    {
        moveSubMenu = false;
        moveSubMenuBack = true;
    }
}
