using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*  차 종류별 기본 값
    F1 : 10 / 4 / 10 / 4 / 100
*/

public class DrivingModule : MonoBehaviour {

    private Rigidbody vehicleRigidbody = null;

    public float accerationForce = 0.0f;
    public float deAccerationForce = 0.0f;
    public float maxAcceration = 0.0f;
    public float minAcceration = 0.0f;
    public float rotationRatio = 0.0f;
    
    private int forceUnit = 1000;


    // Use this for initialization
    void Start()
    {
        if (vehicleRigidbody == null)
            vehicleRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentRotation.y -= (rotationRatio * Time.deltaTime);
            //vehicleRigidbody.AddRelativeForce(Vector3.left * vehicleRigidbody.velocity.magnitude / 6 * forceUnit);
            if(vehicleRigidbody.velocity.magnitude > minAcceration)
                vehicleRigidbody.AddRelativeForce(Vector3.back * deAccerationForce * forceUnit);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentRotation.y += (rotationRatio * Time.deltaTime);
            //vehicleRigidbody.AddRelativeForce(Vector3.right * accerationForce/6 * forceUnit);
            if (vehicleRigidbody.velocity.magnitude > minAcceration)
                vehicleRigidbody.AddRelativeForce(Vector3.back * deAccerationForce * forceUnit);
        }
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    // go forward part
    void FixedUpdate()
    {
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        if (vehicleRigidbody.velocity.magnitude < maxAcceration)
        {
            vehicleRigidbody.AddRelativeForce(Vector3.forward * accerationForce * forceUnit);
            //Debug.Log(vehicleRigidbody.velocity.magnitude);
            Debug.Log(currentRotation.y);
        }

        if(Input.GetKey(KeyCode.Space)) // speed down
        {
            vehicleRigidbody.AddRelativeForce(Vector3.back * deAccerationForce * 3/2 * forceUnit);
        }
    }
}
