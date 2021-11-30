using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        Score.score++;
    }

    /*
    補充:
    OnCollision – 碰撞事件  >> 當兩個非觸發區(Is Trigger未勾選)的物件碰撞，且一方帶有Rigidbody(剛體)，就會發生Collision事件
    OnTrigger – 觸發事件
     */

}
