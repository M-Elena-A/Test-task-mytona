using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_platform : MonoBehaviour
{
    public float speed = 5f;
    float wallStop = 2f;

    void Update()
    {
        wallStop = 2.5f - transform.localScale.x / 2f;
        if ((Input.GetKey(KeyCode.LeftArrow)) && transform.position.x >= -wallStop)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if ((Input.GetKey(KeyCode.RightArrow)) && transform.position.x <= wallStop)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }

    
}
