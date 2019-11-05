using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   
    public int ObjLife = 3;

    public Rigidbody IncreasePlatPrefab;
     
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball_t") )
        {
            if (ObjLife == 1)
            {
                Creat(gameObject.transform);
                Destroy(gameObject);
                
            }
            else
            {
                ObjLife--;
                Change_color();
            }

        }
    }
    void Change_color()
    {

        switch (ObjLife)
        {
            case 1:
                GetComponent<Renderer>().material.color = new Color(0f, 1f, 0.1282372f, 1f);
                break;
            case 2:
                GetComponent<Renderer>().material.color = new Color(1f, 1f, 0f, 1f);
                break;
            case 3:
                GetComponent<Renderer>().material.color = new Color(0f, 0.503f, 0.06509408f, 1f);
                break;
            case 4:
                GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0f, 1f);
                break;
            default:
                GetComponent<Renderer>().material.color = new Color(0f, 1f, 0.1282372f, 1f);
                break;
        }
    }


    void Creat(Transform xyz)
    {
        if (IncreasePlatPrefab != null)
        {
            Rigidbody Bonus;
            Bonus = Instantiate(IncreasePlatPrefab, xyz.position, xyz.rotation) as Rigidbody;
        }      

    }
}
