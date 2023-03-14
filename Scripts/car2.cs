using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2 : MonoBehaviour
{
    public float car2exist ;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        car2exist = transform.Find("choiceUIs").gameObject.GetComponent<choiceUI>().carchoice;
        //get the value from the choosing scene
        if (car2exist == 2)
        {
            gameObject.SetActive(true);
        }
        else
        {
            
            Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        if (car2exist == 2)
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

