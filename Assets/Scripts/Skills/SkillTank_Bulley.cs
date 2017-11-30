using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTank_Bulley : MonoBehaviour {

    private Rigidbody vehicleRigidbody = null;
    public float bulletSpeed = 0.0f;

	// Use this for initialization
	void Start () {
        vehicleRigidbody.AddForce(Vector3.forward * bulletSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
