using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform BallLocation;
    Vector3 offset;
    void Start()
    {

        offset = transform.position-BallLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,BallLocation.position.y+offset.y,transform.position.z);
    }
}
