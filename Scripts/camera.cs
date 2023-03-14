using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 camOffset = new Vector3(0f, 2.1f, -5.4f);
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("player").transform;
    }
    private void LateUpdate()
    {
        this.transform.position = target.TransformPoint(camOffset);
        this.transform.LookAt(target);
    }
    // Update is called once per frame
   
}
