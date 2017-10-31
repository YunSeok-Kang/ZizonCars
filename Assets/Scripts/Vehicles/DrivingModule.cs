using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingModule : MonoBehaviour {

    private Rigidbody vehicleRigidbody = null;

    public float accerationForce = 0.0f;
    public float rotationRatio = 0.0f;


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
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentRotation.y += (rotationRatio * Time.deltaTime);
        }
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    void FixedUpdate()
    {
        vehicleRigidbody.AddRelativeForce(Vector3.forward * accerationForce);
    }
}
