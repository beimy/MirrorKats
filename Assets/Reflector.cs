using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflector : MonoBehaviour
{
    public GameObject RaycastOrigin;
    public int layerMask = 8;
    
    void Start()
    {
        
    }

    void Update()
    {
        ShootRay(RaycastOrigin);
    }

    void ShootRay(GameObject myOrigin)
    {
        myOrigin = RaycastOrigin;

        RaycastHit hit;
        
        if (Physics.Raycast(myOrigin.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
