using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startUI : MonoBehaviour
{

    public void start_test()
    {
        SceneManager.LoadScene(3);
    }

    public void leave_test()

    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void learn_test()
    {
        SceneManager.LoadScene(8);
    }
    public void knowabout_test()
    {
        SceneManager.LoadScene(9);
    }

}
