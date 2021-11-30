using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject gameOverCanvans;

    // Start is called before the first frame update
    void Start() {
        Time.timeScale = 1;
    }

    public void GameOver() {
        gameOverCanvans.SetActive(true); // 顯示隱藏物件 ( 失敗畫面 )
        Time.timeScale = 0; // 遊戲時間暫停
    }

    public void Reply() {
        SceneManager.LoadScene(0);
    }

}
