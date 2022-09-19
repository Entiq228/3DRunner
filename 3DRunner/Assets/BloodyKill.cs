using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodyKill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Block"))
        {
            Destroy(gameObject);
        }
    }
}
