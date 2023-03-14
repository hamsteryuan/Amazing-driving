using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Skytimeshow : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private float showingskytime;
    private void Start()
    {
        Text = transform.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        showingskytime = Mathf.Ceil(playerbehaviou.Skytime);
        Text.text = "Skytime:" +showingskytime  + "s";
    }
}
