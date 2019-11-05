using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy_ball : MonoBehaviour
{
    public int PlayerLife = 3;
    public Text life;
    
    public Transform obj;
    public Transform obj2;
    bool d =true;

    public GameObject lostpanel;

    void Start()
    {
       
        life.text = "LIFE " + PlayerLife.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("floor_t") && d)
        {
            if (PlayerLife - 1 == 0)
            { Destroy(gameObject);
                life.text = "LIFE " + PlayerLife.ToString();
                lostpanel.SetActive(true);
            }
            else
            {
                d = false;
                PlayerLife--;
                life.text = "LIFE " + PlayerLife.ToString();

                Invoke("StartObject", 1);
                
            }

        }
    }

    void StartObject()
    {
        Vector3 tempVect = new Vector3(0, -3.5f, 5);
        obj.transform.position = tempVect;
        Vector3 tempVect2 = new Vector3(0, -4, 5);
        obj2.transform.position = tempVect2;
        d = true;

        
    }

    
   
   
}
