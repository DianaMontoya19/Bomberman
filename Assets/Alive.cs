using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alive : MonoBehaviour
{
    public bool isMultiPlayer;
    public Fire p1;
    public Fire p2;


    private void Update()
    {
        if (isMultiPlayer)
        {
            if (p1.Alive == false && p2.Alive == false)
            {
                Time.timeScale = 0f;
                SceneManager.LoadScene("GameOver");
                //Debug.Log("gameOver");

            }
        }
        else
        {
            if (p1.Alive == false)
            {
                Time.timeScale = 0f;
                SceneManager.LoadScene("GameOver");

            }
        }
    }

}
