using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyliderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        float positin=Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up*positin * 30f * (-1));
    }
}
