using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5;
    public Transform obj;
    public float ChangeDirection_x = -1;
    public float ChangeDirection_y = 1;
    public float ChangeDirectionPl_x = 1;
    float h;
    float v;
    bool platfSpeed = false;

    public void Update()
    {
        //float h = Input.GetAxis("Horizontal")* ChangeDirection_x;
        //float v = Input.GetAxis("Vertical") * ChangeDirection_y;
        if (platfSpeed)
        {
            ChangeDirection_x += Input.GetAxis("Horizontal");
            platfSpeed = false;
        }
        
        h =  ChangeDirection_x;
        v =  ChangeDirection_y;


        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        obj.transform.position += tempVect;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall_t"))
        { ChangeDirection_x *= -1;
         
        }
        if (other.gameObject.CompareTag("top_t"))
        {
              ChangeDirection_y *= -1;
        }
        if (other.gameObject.CompareTag("platform_t"))
        {
            ChangeDirection_y *= -1;
            platfSpeed = true;

        }
        if (other.gameObject.CompareTag("cube_t"))
        {
            ChangeDirection_y *= -1;
            ChangeDirection_x *= -1;
        }
        if (other.gameObject.CompareTag("floor_t"))
        {
            Invoke("ChDr", 1);
            
        }
        


        }
    void ChDr()
    {
        ChangeDirection_y = -1;
        ChangeDirection_x = 1;
    }

}
