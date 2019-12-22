using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI部品を使用する為に必要
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    // ゲームオブジェクトに対応する変数を宣言
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 【car.transform.position.x】
         * オブジェクト(car)にアタッチさせた
         * Transformコンポーネントが持つ座標(position)の情報
         */

        // 車と旗との距離を計算（旗の座標 - 車の座標）
        float length = this.flag.transform.position.x -
            this.car.transform.position.x;

        if(length >= 0)
        {
            this.distance.GetComponent<Text>().text =
                "ゴールまで" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "ゲームオーバー";
        }

        /*
         * 【ToStringの書式】
         *  例）D5
         *      → Dは整数型、5は桁数
         *  例) F2
         *      → Fは固定小数点型、2は小数点以下の桁数
         */
    }
}
