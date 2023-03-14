using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceUI : MonoBehaviour
{
    public int carchoice = 1;
    public int scenechoice = 1; //1:sea island route
    public int Carchoice
    {
        get { return carchoice; }
        set
        {
            carchoice = value;
        }
    }

    private void Start()
    {
        scenechoice = transform.Find("mapUIs").gameObject.GetComponent<mapchoiceUI>().mapchoice;
    }

   
        public void toCar1Map1()
        {
            carchoice = 1;
            SceneManager.LoadScene(1);
        }
        public void toCar2Map1()
        {
            carchoice = 2;
            SceneManager.LoadScene(4);
        }
        public void toCar3Map1() { 
            carchoice = 3;
            SceneManager.LoadScene(5);
        }

        public void toCarsInform()
        {
            SceneManager.LoadScene(6);

        
        }
        /*
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
        */
   

}