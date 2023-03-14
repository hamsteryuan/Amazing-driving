using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choicetransform : MonoBehaviour
{
    public int cartransform;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        cartransform=transform.Find("choiceUIs").gameObject.GetComponent<choiceUI>().carchoice;
    }
}
