using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{

    public void LoadScene1()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("__Prospector_Scene_0");
    }
}