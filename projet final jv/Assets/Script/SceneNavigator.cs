using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         OpenMenu();
    }

    //va ouvrir le menu
    public static void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //va ouvrir le jeu proprement dit
    public static void OpenGame()
    {
        SceneManager.LoadScene("Jeu");
    }

    //va quitter le jeu
    public static void QuitGame()
    {
        Application.Quit();
    }
}
