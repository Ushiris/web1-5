using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float speed = 0;
    Vector2 startPos;
    public bool isMove = false;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0) && isMove == false)
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
            isMove = true;
        }

        if(speed>=0)
        {
            transform.Translate(speed, 0, 0);
            speed *= 0.98f;
        }
	}
}
