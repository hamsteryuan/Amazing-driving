using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caraudio : MonoBehaviour
{

    
    private AudioSource au;//音频组件(zh
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();//获取音频组件
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space))//brake key on
            {
                au.Play();
            }
            /*
            else
            {
                au.Stop();
            }
            */
        
    }
}


