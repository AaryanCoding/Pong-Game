using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play game was pressed");

        //Moves us to the Game Scene
        SceneManager.LoadScene("Game");
    }
}
