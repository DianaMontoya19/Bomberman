using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Realiza cambio de escenarios al oprimir botones, que se encuentran en unity,
    public void Player1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Player1");
    }
    public void Multiplayer()
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
