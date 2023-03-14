using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car1 : MonoBehaviour
{
    public int car1exist ;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        car1exist = transform.Find("choiceUIs").gameObject.GetComponent<choiceUI>().carchoice;
   //get the value from the choosing scene

        if (car1exist == 1)
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
        if (car1exist == 1)
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
