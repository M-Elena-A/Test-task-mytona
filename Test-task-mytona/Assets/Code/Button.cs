using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        { case "level_1": 
                Application.LoadLevel("Level_1");
                break;
          case "level_2": 
                Application.LoadLevel("Level_2");
                break;
            case "level_3": 
                Application.LoadLevel("Level_3");
                break;
            case "menu":
                Application.LoadLevel("Menu");
                break;
            case "replay1":
                Application.LoadLevel("Level_1");
                break;
            case "replay2":
                Application.LoadLevel("Level_2");
                break;
            case "replay3":
                Application.LoadLevel("Level_3");
                break;
        }
    }
    
}
