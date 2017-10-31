using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerCam : MonoBehaviour {

    public Transform followingTarget = null;

    public bool followPosX = false;
    public bool followPosY = false;
    public bool followPosZ = false;

    // Use this for initialization
    void Start () {
        if (followingTarget == null)
            Debug.Log("FollowingTarget is null.");
	}
	
	// Update is called once per frame
	void LateUpdate () {

        Vector3 curCamPos = transform.position;

		if (followPosX)
        {
            curCamPos.x = followingTarget.position.x;
        }

        if (followPosY)
        {
            curCamPos.y = followingTarget.position.y;
        }

        if (followPosZ)
        {
            curCamPos.z = followingTarget.position.z;
        }

        transform.position = curCamPos;
	}
}
