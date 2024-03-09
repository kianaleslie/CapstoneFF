using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SnowballManager : MonoBehaviour
{

    bool leftPressed, rightPressed;
    public float forwardMovementspeed, sideMovementSpeed;

    public bool playingGame;

    public bool canAccel;
    public bool canBoost;
    public bool canSlow;
    public bool canStop;

    public int powerBallCount;
    public bool canPowerBoost = false;
    public bool powerBoosting = false;

    // Start is called before the first frame update
    void Start()
    {
        forwardMovementspeed = 0.0f;
        sideMovementSpeed = 0.15f;
        playingGame = false;

        canAccel = true;
        canBoost = true;
        canSlow = true;
        canStop = true;

        powerBallCount = 0;
        canPowerBoost = false;
        powerBoosting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playingGame == true)
        {
            if (canAccel == true)
            {
                if (forwardMovementspeed <= 0.5f)
                {
                    canAccel = false;
                    StartCoroutine(Accelerate());
                }
            }

            if (powerBallCount >= 20)
            {
                canPowerBoost = true;
            }
            else
            {
                canPowerBoost = false;
            }


            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                leftPressed = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rightPressed = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                leftPressed = false;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                rightPressed = false;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(powerBallCount >= 20)
                {
                    PowerBoostButtonPressed();
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                ResetScene();
            }
        }
    }

    public void FixedUpdate()
    {
        if (playingGame == true)
        {
            MovePlayer();
        }
    }

    public void MovePlayer() // Called in FixedUpdate
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1.0f * forwardMovementspeed);

        if (leftPressed == true)
        {
            //Debug.Log("LEFT");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f * sideMovementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (rightPressed == true)
        {
            //Debug.Log("RIGHT");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.0f * sideMovementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else
        {
            //Debug.Log("NONE");
        }
    }

    public IEnumerator Accelerate() // Called in Update
    {
        yield return new WaitForSeconds(0.1f);
        forwardMovementspeed += 0.01f;
        canAccel = true;
    }

    public IEnumerator BoostSnowball()
    {
        forwardMovementspeed = 1.0f;
        yield return new WaitForSeconds(1.0f);
        if (forwardMovementspeed > 0.5f)
        {
            forwardMovementspeed = 0.5f;
        }
        if (powerBoosting == false)
        {
            canBoost = true;
        }
    }

    public IEnumerator SlowSnowball()
    {
        forwardMovementspeed = 0.1f;
        yield return new WaitForSeconds(0.5f);
        if (powerBoosting == false)
        {
            canSlow = true;
        }
    }

    public IEnumerator StopSnowball()
    {
        forwardMovementspeed = 0.0f;
        yield return new WaitForSeconds(0.5f);
        if (powerBoosting == false)
        {
            canStop = true;
        }
    }

    public IEnumerator PowerBoostSnowball()
    {
        canBoost = false;
        canSlow = false;
        canStop = false;
        canPowerBoost = false;
        powerBallCount = 0;
        forwardMovementspeed = 1.5f;
        yield return new WaitForSeconds(4.0f);
        canBoost = true;
        canSlow = true;
        canStop = true;
        powerBoosting = false;
        forwardMovementspeed = 0.5f;
    }

    public void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            if (other.GetComponentInParent<Rigidbody>().tag == "SpeedBoost")
            {
                if (canBoost == true)
                {
                    StartCoroutine(BoostSnowball());
                }
            }

            if (other.GetComponentInParent<Rigidbody>().tag == "SlowObstacle")
            {
                if (canSlow == true)
                {
                    StartCoroutine(SlowSnowball());
                }
            }

            if (other.GetComponentInParent<Rigidbody>().tag == "StopObstacle")
            {
                if (canStop == true)
                {
                    StartCoroutine(StopSnowball());
                }
            }

            if (other.GetComponentInParent<Rigidbody>().tag == "PowerBall")
            {
                Debug.Log("BALLS");
                powerBallCount += 1;
                Destroy(other.gameObject);
            }
        }
    }

    // ON SCREEN BUTTONS
    #region
    public void ResetScene() // ResetButton
    {
        SceneManager.LoadScene(0);
    }

    public void MoveLeftPressed() // Left Button
    {
        leftPressed = true;
    }
    public void MoveLeftReleased() // Left Button
    {
        leftPressed = false;
    }
    public void LeftExited() // Left Button
    {
        //Debug.Log("Left Exited");
        leftPressed = false;
    }
    public void MoveRightPressed() // Right Button
    {
        rightPressed = true;
    }
    public void MoveRightReleased() // Right Button
    {
        rightPressed = false;
    }
    public void RightExited() // Right Button
    {
        //Debug.Log("Right Exited");
        rightPressed = false;
    }

    public void PowerBoostButtonPressed() // Power Boost Button
    {
        powerBallCount = 0;
        canPowerBoost = false;
        powerBoosting = true;
        StartCoroutine(PowerBoostSnowball());
    }
    #endregion
}
