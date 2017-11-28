using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleModule : MonoBehaviour
{
    public VehicleControl vehicleControl = null;

    public LayerMask rayingLayer;
    public int rayDist = 10;

    // Use this for initialization
    void Start()
    {
        if (vehicleControl == null)
        {
            vehicleControl = gameObject.GetComponent<VehicleControl>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 localForward = this.transform.forward;

        //Physics.Raycast(transform.position, localForward, rayDist, LayerMask.GetMask("Obstacle"));
        if (Physics.Raycast(transform.position, localForward, out hit, rayDist, rayingLayer))//LayerMask.GetMask("Player")))
        {
            Debug.Log(hit.collider.gameObject.name);
        }

        Debug.DrawRay(transform.position, localForward, Color.blue, rayDist);
        //Physics.Raycast(transform.position, localForward, out hit, 100, 0);
    }

    //void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.green;
    //    Vector3 destination = transform.position + this.transform.forward * 10;

        

    //    Gizmos.DrawLine(transform.position, destination);
    //}
}
