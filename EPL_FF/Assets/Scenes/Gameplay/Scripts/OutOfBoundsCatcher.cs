using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsCatcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) // MAXWELL - Detects when the player reaches the finish line
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            if (other.GetComponentInParent<Rigidbody>().tag == "Player")
            {
                Debug.Log("TRIGGER ENTER");
                other.gameObject.transform.position = new Vector3(0, 2, other.gameObject.transform.position.z);
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            if (collision.gameObject.GetComponentInParent<Rigidbody>().tag == "Player")
            {
                Debug.Log("COLLISION ENTER");
                collision.gameObject.transform.position = new Vector3(0, 2, collision.gameObject.transform.position.z);
            }
        }
    }
}
