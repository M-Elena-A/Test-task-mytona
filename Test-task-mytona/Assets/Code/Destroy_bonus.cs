using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_bonus : MonoBehaviour
{
 
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
