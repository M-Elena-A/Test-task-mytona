using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_platform : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow)) && transform.position.x>= -2)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if ((Input.GetKey(KeyCode.RightArrow)) && transform.position.x <= 2)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
