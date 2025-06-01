using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallControll : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    bool isTouch;
    public GameObject g;
    //public Text score;
    //int s = 0;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouch)
        {
            ballBounce();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isTouch=true;
    }

    void ballBounce()
    {
        if (isTouch)
        {
            isTouch = false;
            rb.linearVelocity = Vector3.zero;
            rb.linearVelocity = Vector3.up * 6f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Score")
        {
            Transform parent= other.transform.parent.transform;

            foreach(Transform child in parent)
            {
                if(child.tag!="Score")
                {
                    child.GetComponent<MeshCollider>().convex = true;
                    child.GetComponent<Rigidbody>().useGravity=true;
                    child.GetComponent<Rigidbody>().isKinematic= false;
                }
                Destroy(child.gameObject, 0.7f);
            }
        }

        if(other.tag=="Red")
        {
            Time.timeScale = 0;
            g.SetActive(true);
        }

        if (other.tag == "Win")
        {
            SceneManager.LoadScene("Level2");
        }
        if (other.tag == "Win2")
        {
            SceneManager.LoadScene("Level3");
        }
        if (other.tag == "Win3")
        {
            SceneManager.LoadScene("Level4");
        }

    }
}
