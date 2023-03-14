using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runaudio : MonoBehaviour
{


    private AudioSource au2;//音频组件2(throttle)
    // Start is called before the first frame update
    void Start()
    {
        au2 = GetComponent<AudioSource>();//获取音频组件
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))//is running now
        {
            au2.Play();//stop  
        }
        else
        {
            au2.Stop();//激活该组件
        }

    }
}