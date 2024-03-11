using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public bool moveLeft;
    public bool moveRight;

    public int randomizer;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 0.04f;

        randomizer = Random.Range(1, 3);
        if (randomizer == 1)
        {
            moveLeft = true;
            moveRight = false;
        }
        else
        {
            moveLeft = false;
            moveRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f * movementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
            if (gameObject.transform.position.x <= -5.5f)
            {
                moveLeft = false;
                moveRight = true;
            }
        }
        if (moveRight == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.0f * movementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
            if (gameObject.transform.position.x >= 5.5f)
            {
                moveLeft = true;
                moveRight = false;
            }
        }
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f * sideMovementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
