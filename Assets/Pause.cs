using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject g;
    void Start()
    {
        
    }

    public void onClickRestart()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
        g.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
