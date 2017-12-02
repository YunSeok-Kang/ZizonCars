using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alphaca_spit : MonoBehaviour {

    private Rigidbody vehicleRigidbody = null;
    public float spitSpeed = 0.0f;

    // Use this for initialization
    void Start () {
        vehicleRigidbody.AddForce(Vector3.forward * spitSpeed);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
