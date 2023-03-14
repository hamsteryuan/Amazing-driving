using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapInformationUI : MonoBehaviour
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
        if (GUI.Button(new Rect(160, 250, 150, 40), "Leave"))
        {
            GUI.backgroundColor = Color.red;
            SceneManager.LoadScene(3);
        }
        //return2 map choices
    }
}

