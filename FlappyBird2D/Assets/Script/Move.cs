using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed; // 輸入速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //向左移動 * 速度 * 時間
    }
}
