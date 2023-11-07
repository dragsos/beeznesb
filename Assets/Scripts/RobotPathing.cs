using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPathing : MonoBehaviour
{
    // Reference to the waypoints system
    [SerializeField] private Waypoints waypoints;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotateSpeed = 2f;
    [SerializeField] private float distanceThreshold = 0.1f;
    [SerializeField] public Transform stationaryLookTarget;
    [SerializeField] public float lookSpeed = 5f;

    public GameManager gameManagerScript;
    public GameObject blueprint;

    private float intro1CountdownTimer = 5f;
    private float intro2CountdownTimer = 6f;
    private float bikeCountdownTimer = 12f;
    private float firstLadderCountdownTimer = 23f;
    private float boat1CountdownTimer = 7f;
    private float boat2CountdownTimer = 16f;
    private float finalLadderCountdownTimer = 5f;



    // Current waypoint the robot is moving towards
    private Transform currentWaypoint;

    // The rotation target for the current frame
    private Quaternion rotationGoal;
    // The direction to the next waypoint that the robot needs to rotate towards
    private Vector3 directionToWaypoint;

    void Start()
    {
        // Set initial position to the first waypoint
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        // Set the next waypoint target
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.LookAt(currentWaypoint);
    }

    void Update()
    {
        if (currentWaypoint == waypoints.transform.GetChild(1))
        {

            FindObjectOfType<AudioManager>().Play("Voice_Line01");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(2) && !gameManagerScript.intro1Cleared)
        {
            LookAtPlayer();
            if (intro1CountdownTimer > 0)
            {
                intro1CountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.intro1Cleared = true;
            }
            if (gameManagerScript.intro1Cleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(4))
        {

            FindObjectOfType<AudioManager>().Play("Voice_Line02");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(5) && !gameManagerScript.intro2Cleared)
        {
            LookAtPlayer();
            if (intro2CountdownTimer > 0)
            {
                intro2CountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.intro2Cleared = true;
            }
            if (gameManagerScript.intro2Cleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(7))
        {

            FindObjectOfType<AudioManager>().Play("Voice_Line03");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(20))
        {

            FindObjectOfType<AudioManager>().Play("Voice_Line12");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(21) && !gameManagerScript.bikeCleared)
        {
            LookAtPlayer();
            if (bikeCountdownTimer > 0)
            {
                bikeCountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.bikeCleared = true;
            }
            if (gameManagerScript.bikeCleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(22))
        {

            FindObjectOfType<AudioManager>().Play("Voice_Line13");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(27))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line14");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(30) && !gameManagerScript.bridgeCleared)
        {
            LookAtPlayer();
            if (gameManagerScript.bridgeCleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(31))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line17");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(35))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line21");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(39))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line23");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(40) && !gameManagerScript.firstLadderCleared)
        {
            LookAtPlayer();
            if (firstLadderCountdownTimer > 0)
            {
                firstLadderCountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.firstLadderCleared = true;
            }
            if (gameManagerScript.firstLadderCleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(42))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line19");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(43) && !gameManagerScript.boat1Cleared)
        {
            LookAtPlayer();
            if (boat1CountdownTimer > 0)
            {
                boat1CountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.boat1Cleared = true;
            }
            if (gameManagerScript.boat1Cleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(45))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line18");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(46) && !gameManagerScript.boat2Cleared)
        {
            if (blueprint != null)
            {
                blueprint.SetActive(true);
            }
            LookAtPlayer();
            if (boat2CountdownTimer > 0)
            {
                boat2CountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.boat2Cleared = true;
            }
            if (gameManagerScript.boat2Cleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(47) && !gameManagerScript.gunCleared)
        {
            LookAtPlayer();
            if (gameManagerScript.gunCleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
        else if (currentWaypoint == waypoints.transform.GetChild(49))
        {
            FindObjectOfType<AudioManager>().Play("Voice_Line29");
            // Set the next waypoint and resume movement
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
        else if (currentWaypoint == waypoints.transform.GetChild(50) && !gameManagerScript.finalLadderCleared)
        {
            LookAtPlayer();
            if (finalLadderCountdownTimer > 0)
            {
                finalLadderCountdownTimer -= Time.deltaTime;
            }
            else
            {
                gameManagerScript.finalLadderCleared = true;
            }
            if (gameManagerScript.finalLadderCleared)
            {
                // Set the next waypoint and resume movement
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }

        else
        {
            //Debug.Log("X Rotation: " + transform.rotation.eulerAngles.x);
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
            {
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
                //transform.LookAt(currentWaypoint);
            }
            RotateTowardsWaypoint();
        }
    }

    // Will slowly rotate robot towards the current waypoint it is moving towards
    private void RotateTowardsWaypoint()
    {
        directionToWaypoint = (currentWaypoint.position - transform.position).normalized;
        rotationGoal = Quaternion.LookRotation(directionToWaypoint);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationGoal, rotateSpeed * Time.deltaTime);
    }

    private void LookAtPlayer()
    {
        Vector3 direction = stationaryLookTarget.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);
    }
}
