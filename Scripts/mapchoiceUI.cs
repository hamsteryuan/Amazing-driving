using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapchoiceUI : MonoBehaviour
{
    public int mapchoice = 1;

    public int Mapchoice
    {
        get { return mapchoice; }
        set
        {
            mapchoice = value;
        }
    }



        public void toMap1() { 
            SceneManager.LoadScene(2);
        }
        
        public void toMapInform()
        {
            SceneManager.LoadScene(7);
        }
      
    

}