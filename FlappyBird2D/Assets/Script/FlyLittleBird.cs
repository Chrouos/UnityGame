using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour {

    //new
    public GameManager GameManager;

    public float velocity = 1; //飛行上升數 預設為 1
    private Rigidbody2D rb; //引入 Rigidbody2D 的物件

    // 在一開始的時候會被執行一次
    void Start() {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // 遊戲中被執行的部分
    void Update() {

        //只要點擊滑鼠左鍵，就會上升 ( Jump )
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up * velocity;  // Bird上升速度 = 往上 * 上升數
        }
    }

    //當兩個2D碰撞器碰撞時會發生的事件
    private void OnCollisionEnter2D(Collision2D collision) {
        GameManager.GameOver();
    }

    /*
     補充:
     OnCollisionEnter2D – 碰撞事件
        當兩個2D碰撞器碰撞時會發生的事件
     OnCollisionExit2D – 分開事件
        當兩個2D碰撞器碰撞後，分開時所發生的事件
     OnCollisionStay2D – 停滯事件
        當兩個2D碰撞器碰撞後，未分開時會持續發生的事件，也可以想做是接觸著碰撞
     */


}
