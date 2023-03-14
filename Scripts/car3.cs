using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car3 : MonoBehaviour
{
    public float car3exist ;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        car3exist = transform.Find("choiceUIs").gameObject.GetComponent<choiceUI>().carchoice;
        //get the value from the choosing scene
        if (car3exist == 3)
        {
            gameObject.SetActive(true);
        }
        else
        {
            Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (car3exist == 3)
        {
            gameObject.SetActive(true);
        }
        else
        {

            Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
    }
}
