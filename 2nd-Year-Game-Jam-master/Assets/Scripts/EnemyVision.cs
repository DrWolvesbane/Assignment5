using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyVision : MonoBehaviour {

    public bool seen;

    void Start()
    {
        seen = false;
    }
    void Update()
    {
        if (seen == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            seen = true;
            print("seen");
        }
    }
}
