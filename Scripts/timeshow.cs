using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeshow : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public float timer = 0.0f;
    public float showingtime = 0.0f;
    private void Start()
    {
        Text = transform.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        showingtime = Mathf.Ceil(timer);
        Text.text = "Time:" + showingtime + "s";
    }
    /*
    private void OnGUI()
    {
        GUI.Box(new Rect(120, 260, 160, 40), "Time:" + showingtime + "s");
    }
    */

}
