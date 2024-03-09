using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public bool MoveLeft;
    public bool MoveRight;

    public int Randomizer;
    // Start is called before the first frame update
    void Start()
    {
        Randomizer = Random.Range(1, 3);
        if (Randomizer == 1)
        {
            MoveLeft = true;
            MoveRight = false;
        }
        else
        {
            MoveLeft = false;
            MoveRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f * sideMovementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
