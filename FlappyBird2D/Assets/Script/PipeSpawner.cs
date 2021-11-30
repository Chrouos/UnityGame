using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float maxTime = 1; //生成時間
    private float timer = 0; // 經過時間
    public GameObject pipe; // PIPE
    public float height; //改變的高度

    // Start is called before the first frame update
    void Start() {

    }

    // 每一偵都在進行
    void Update() {

        //如果時間大於某一時段，則
        if(timer > maxTime) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); //改變位置(隨機值 = height以內)
            Destroy(newpipe, 15); // 15秒後破壞物件
            timer = 0; //時間歸零
        }
        timer += Time.deltaTime; //時間繼續
    }
}
