using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject parametrePanel;


    //au début on cache le panel
    void Start()
    {
        parametrePanel.SetActive(false);
       
        if (parametrePanel == null)
            Debug.LogError("Le GameObject avec le tag 'reglagePanel' n'a pas ete trouve.");
    }
        //va ouvrire la scene Game
        public void Continuer()
    {
        SceneManager.LoadScene("Jeu");
    }

    //va ouvrire la scene Game
    public void NouvellePartie()
    {
        SceneManager.LoadScene("Jeu");
    }

    //va ouvrire les parametres
    public void OuvrirParametres()
    {
        parametrePanel.SetActive(true);
    }


    //va fermer le jeu
    public void Quitter()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                        Application.Quit();
        #endif
    }
}
