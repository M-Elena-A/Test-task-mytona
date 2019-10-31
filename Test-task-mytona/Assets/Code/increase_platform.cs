using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increase_platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform obj;
    

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("increaseP_t"))
        {
            
            gameObject.transform.localScale += new Vector3(1.0f, 0.0f, 0.0f);
            Invoke("SetWall", 10);
        }
    }
    void SetWall()
    { gameObject.transform.localScale -= new Vector3(1.0f, 0.0f, 0.0f); }
}
