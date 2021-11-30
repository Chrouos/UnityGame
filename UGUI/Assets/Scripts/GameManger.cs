using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public void OnstartGame(string ScneneName)
    {
        Application.LoadLevel(ScneneName);//讀取場景，場景名稱
    }
}
