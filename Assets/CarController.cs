using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    // 車の初速を設定
    float speed = 0;

    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            // マウスのクリックを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 1000.0f;

            // 効果音再生
            GetComponent<AudioSource>().Play();
        }

        // 車の移動速度を設定
        transform.Translate(this.speed, 0, 0);

        // 車の減速処理
        this.speed *= 0.98f;
    }
}
