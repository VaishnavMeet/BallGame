using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourManager : MonoBehaviour
{
    public Material[] allMat;
    public string[] allTag;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform) {
            if (!child.GetComponent<MeshCollider>().isTrigger)
            {
                int r = Random.Range(0, allMat.Length);
                child.GetComponent<Renderer>().material = allMat[r];
                child.tag = allTag[r];
                if(child.tag=="Red")
                {
                    child.GetComponent<MeshCollider>().convex = true;
                    child.GetComponent<MeshCollider>().isTrigger = true;
                }
            }
            else
            {
                child.tag = "Score";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
