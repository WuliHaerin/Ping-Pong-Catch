using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    public void LoadMainGame()
    {
        SceneManager.LoadScene("main");
    }

    public void LeaveGame()
    {
        Application.Quit();
    }

}
