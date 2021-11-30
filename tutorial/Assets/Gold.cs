using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{

    GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("玩家"))
        {
            gameManager.money += 10;
            Debug.Log("金錢=" + gameManager.money);
        }
    }
}
