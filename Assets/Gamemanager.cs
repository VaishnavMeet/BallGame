using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject ringPrefab;
    void Start()
    {
        float y=ringPrefab.transform.position.y;
        for (int i=0;i<5;i++)
        {
            y=y - 25f;
            Instantiate(ringPrefab,ringPrefab.transform.parent.position,Quaternion.Euler(0,Random.Range(0,100),0));
        }
    }
}
