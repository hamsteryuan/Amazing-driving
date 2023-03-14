using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class carInformationUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnGUI()
    {
        if (GUI.Button(new Rect(400, 300, 350, 160), "Leave"))
            {
            GUI.backgroundColor = Color.red;
            SceneManager.LoadScene(2);
        }
        //return2 car choices
    }
}


