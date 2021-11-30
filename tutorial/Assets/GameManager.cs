using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    static GameManager instance;
    public int money;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            name = "最初的遊戲管理物件";
            money = 0;
        }
        else if (this != instance)
        {
            string sceneName = SceneManager.GetActiveScene().name;
            Debug.Log("刪除場景" + sceneName + "的" + name);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
