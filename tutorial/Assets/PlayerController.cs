using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRigidbody2D;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody2D.AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody2D.AddForce(Vector2.left * speed);
        }
    }
}
