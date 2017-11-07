using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleModule : MonoBehaviour
{
    public int rayDist = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 localForward = transform.InverseTransformDirection(transform.forward);

        Physics.Raycast(transform.position, localForward, out hit, 100, 0);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Vector3 destination = transform.position + this.transform.forward * 10;

        

        Gizmos.DrawLine(transform.position, destination);
    }
}
