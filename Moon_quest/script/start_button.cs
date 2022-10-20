using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_button : MonoBehaviour
{
    public void Onclick_LoadScene()
    {
    SceneManager.LoadScene(1);
    }

    public void Gotohowtoplay()
    {
    SceneManager.LoadScene(6);
    }

    public void GotoMenu()
    {
    SceneManager.LoadScene(0);
    }

    public void Editor_info()
    {
    SceneManager.LoadScene(7);
    }
}
