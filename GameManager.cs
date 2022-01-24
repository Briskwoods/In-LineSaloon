using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EndGameButton;


    public void EndTheGame()
    {
        EndGameButton.SetActive(true);
    }

    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
