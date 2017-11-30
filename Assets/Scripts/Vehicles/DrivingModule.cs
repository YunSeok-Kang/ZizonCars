using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*  차 종류별 기본 값
    F1 : 12 / 4 / 10 / 4 / 100
*/

public class DrivingModule : MonoBehaviour {

    private Rigidbody vehicleRigidbody = null;

    public float accerationForce = 0.0f;
    public float deAccerationForce = 0.0f;
    public float maxSpeed = 0.0f;
    public float minSpeed = 0.0f;
    public float rotationRatio = 0.0f;
    
    private int forceUnit = 1000;


    // ======================================================= Driving Methods ======================================================= //

    private bool useBreak = false;
    private bool turnLeft = false;
    private bool turnRight = false;
    private bool useSkill = false;

    public void Break(bool use)
    {
        useBreak = use;
    }

    public void TurnLeft(bool use)
    {
        turnLeft = use;
    }

    public void TurnRight(bool use)
    {
        turnRight = use;
    }

    public void UseSkill(bool use)
    {
        useSkill = use;
    }

    // ======================================================= Unity Methods ======================================================= //
    // Use this for initialization
    void Start()
    {
        if (vehicleRigidbody == null)
            vehicleRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    // go forward part
    void FixedUpdate()
    {
        Vector3 currentRotation = transform.localRotation.eulerAngles;

        if (turnLeft || Input.GetKey(KeyCode.LeftArrow))
        {
            currentRotation.y -= (rotationRatio * Time.deltaTime);
            //vehicleRigidbody.AddRelativeForce(Vector3.left * vehicleRigidbody.velocity.magnitude / 6 * forceUnit);
            if (vehicleRigidbody.velocity.magnitude > minSpeed)
                vehicleRigidbody.AddRelativeForce(Vector3.back * deAccerationForce * forceUnit);
        }
        if (turnRight || Input.GetKey(KeyCode.RightArrow))
        {
            currentRotation.y += (rotationRatio * Time.deltaTime);
            //vehicleRigidbody.AddRelativeForce(Vector3.right * accerationForce/6 * forceUnit);
            if (vehicleRigidbody.velocity.magnitude > minSpeed)
                vehicleRigidbody.AddRelativeForce(Vector3.back * deAccerationForce * forceUnit);
        }
        transform.localRotation = Quaternion.Euler(currentRotation);

        if (useBreak || Input.GetKey(KeyCode.Space)) // break
        {
            vehicleRigidbody.AddRelativeForce(Vector3.back * deAccerationForce * 17/10 * forceUnit);
        }

        if (vehicleRigidbody.velocity.magnitude < maxSpeed)
        {
            vehicleRigidbody.AddRelativeForce(Vector3.forward * accerationForce * forceUnit);
            //Debug.Log(vehicleRigidbody.velocity.magnitude);
            Debug.Log("NOW speeed : " + vehicleRigidbody.velocity.magnitude);
        }
        else if(vehicleRigidbody.velocity.magnitude > maxSpeed) // speed down
        {
            vehicleRigidbody.AddRelativeForce(Vector3.back * accerationForce * forceUnit);
        }
        
    }
}
