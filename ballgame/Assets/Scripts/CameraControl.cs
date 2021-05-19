using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakimesafe;
    void Start()
    {
        aradakimesafe = transform.position - top.transform.position;
    }

  
    void LateUpdate()
    {
        transform.position = top.transform.position +aradakimesafe;
    }
}
