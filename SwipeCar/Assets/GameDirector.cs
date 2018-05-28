using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject
        car,
        flag,
        distance;
	// Use this for initialization
	void Start ()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
	}

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        if (length >= 0)
        {
            distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
        }
        else
        {
            distance.GetComponent<Text>().text = "オーバーラン！";
        }

        if (car.GetComponent<CarController>().speed <= 0.0001f && car.GetComponent<CarController>().isMove)
        {
            float leng = length;
            distance.GetComponent<Text>().text = "記録：" + leng.ToString("F2") + "m　　" + "スペースでリトライ";
            if (Input.GetKeyDown("space"))
                Application.LoadLevel("GameScene");

        }
    }
}
