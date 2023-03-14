using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Veloshow : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private float showingspeed2;
    private void Start()
    {
        Text = transform.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        showingspeed2 = Mathf.Ceil(playerbehaviou.showingspeed);
        Text.text = "Speed:" + showingspeed2 + "km/h";
    }
}