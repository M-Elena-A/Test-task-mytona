using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_bonus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("platform_t"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("floor_t"))
        {
            Destroy(gameObject);
        }
    }
}
