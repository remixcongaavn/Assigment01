﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }  
}
