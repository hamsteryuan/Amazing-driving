using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerbehaviou : MonoBehaviour
{
    public float addingSpeed = 0.002f;
    public float rotateSpeed = 45f;
    public  float nowSpeed = 0f;
    public float maxSpeed = 30f;
    private float vInput;
    private float vheiInput; //brake when it is too high
    public bool showlosescreen=false;
    public bool showwinscreen = false;
    private float hinput;
    private float dInput;
    private float drInput;
    public TextMeshProUGUI Text;
    public static float Skytime;
    public static float showingspeed;
    private float sInput; //brake or speed up quickly
    private void Start()
    {
       nowSpeed = 0f;
        Skytime = 0f;
        Text = transform.GetComponent<TextMeshProUGUI>(); //need to be moved
    }
    // Update is called once per frame
    void Update()
    {
        
        vheiInput = 0;
        if (nowSpeed >= 22) {

            vInput = (float)(Input.GetAxis("Vertical") * addingSpeed * 0.5);
        }
        else if(nowSpeed >=8)
        {
            vInput = (float)(Input.GetAxis("Vertical") * addingSpeed * 1.0);
        }
        else
        {
            vInput = (float)(Input.GetAxis("Vertical") * addingSpeed * 1.5);
    }
        if (nowSpeed >= 2) {
            drInput = Input.GetAxis("drift") * rotateSpeed*3;
            dInput = -Mathf.Abs((float)(Input.GetAxis("drift") * addingSpeed * 1.6));
        }

        hinput = Input.GetAxis("Horizontal") * rotateSpeed;
        if (nowSpeed >= 0)
        {
            sInput = Input.GetAxis("Jump") * addingSpeed * 5;
        }
        //this only for some maps
        if (this.transform.localPosition.y >=0.68)
        {
            vheiInput = (float)(addingSpeed * 1.2);
            Skytime = Skytime+0.02f;
        }
        nowSpeed = vInput + sInput + nowSpeed+dInput-vheiInput;
        hinput = hinput + drInput;
        showingspeed =(vInput + sInput + nowSpeed+dInput-vheiInput)*15;
        if (nowSpeed >= maxSpeed)
        {
            nowSpeed = maxSpeed-1;
        }
        if (nowSpeed <=-0.5)
        { 
            nowSpeed = 0;
        }
        if (this.transform.localPosition.y < -4)
        {
            showlosescreen = true;
        }
        /*
        if (this.transform.localPosition.y > -2&& this.transform.localPosition.z >=1&& this.transform.localPosition.x<=6&& this.transform.localPosition.x>=-2)
        {
            showwinscreen = true;
        }
        */
        if (showingspeed<=0)
        {
            showingspeed = 0;
        }
        showingspeed = showingspeed * 0.88f;  //fixed
        showingspeed = Mathf.Ceil(showingspeed);
        
        this.transform.Translate(Vector3.forward * nowSpeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hinput * Time.deltaTime);
        Text.text = "Speed" + showingspeed + "km / h";
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "WinWall")
        {
            showwinscreen = true;
            SceneManager.LoadScene(0);
        }

    }
    private void OnGUI()
    {
        //GUI.Box(new Rect(50, 100, 160, 40), "Speed" + showingspeed + "km / h");
        if(showlosescreen)
        {
            if (!showwinscreen)
            {
                if (GUI.Button(new Rect(1050, 900, 800, 600), "Car broken!"))
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
        if (showwinscreen)
        {
            if (GUI.Button(new Rect(1050,900,800,600), "You win!"))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    
}
