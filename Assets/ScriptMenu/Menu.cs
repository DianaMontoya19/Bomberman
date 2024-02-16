using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void Player1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Multiplayer");
   }
    public void menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

}
