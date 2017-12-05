using UnityEngine;
using System.Collections;

public class MenuAction : MonoBehaviour
{

    public void MENU_ACTION_GotoScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}