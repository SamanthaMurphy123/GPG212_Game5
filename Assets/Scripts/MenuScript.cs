using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public string LevelToLoad;
    //this is to try and remove other UI
    public GameObject[] gameObjectsToDisable;
    public GameObject[] gameObjectsToEnable;

    public GameObject ObjectToDisable;
    public GameObject Plot;


    public void DisableObjectsOnClick()
    {
        foreach (GameObject gameObjectToDisable in gameObjectsToDisable)
        {
            gameObjectToDisable.SetActive(false);
        }
    }

    public void EnableObjectsOnClick()
    {
        foreach (GameObject gameObjectToEnable in gameObjectsToEnable)
        {
            gameObjectToEnable.SetActive(true);
        }
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }


    // 
    public void Case1()
    {
        SceneManager.LoadScene("AbusiveFather");
    }

    public void CrazyBizzareCourt()
    {
        SceneManager.LoadScene("CrazyNoisyBizareCourt");
    }

    public void LobbyHub()
    {
        SceneManager.LoadScene("LobbyHub");
    }

    public void Dance()
    {
        SceneManager.LoadScene("TwitchFollowers");
    }

    public void explination()
    {
        ObjectToDisable.SetActive(false);
    }

    public void Plotdetail()
    {
        Plot.SetActive(true);
    }
}

