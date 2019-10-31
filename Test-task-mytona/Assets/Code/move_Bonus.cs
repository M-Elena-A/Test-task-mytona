using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 2;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.up * speed * Time.deltaTime);
        /*
        Vector3 tempVect = new Vector3(0, -1, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        
        gameObject.transform.position += tempVect;
        gameObject.transform.up;
        */
    }
}
