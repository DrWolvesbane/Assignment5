using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour {

    KeyCode escape = KeyCode.Escape;

    void Update()
    {
        if (Input.GetKey(escape))
        {
            Application.Quit();
        }
    }

    
}
