using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManagement : MonoBehaviour
{
    public GameObject pauseMenu;
    //public AudioSource ClickSound;

    void Start()
    {
        pauseMenu.SetActive(false); //Start game without pause menu
    }

        #region Main Game Menu Buttons
        public void StartButton() //Start the game
    {
        Debug.Log("LETS GO");
        //ClickSound.Play();
        //SceneManager.LoadScene("");
    }

    public void OptionButton() //Show Options Menu in the main menu
    {
        pauseMenu.SetActive(true); 
        //ClickSound.Play();
    }

    public void CreditsButton() //Play credits
    {
        Debug.Log("Aaaaaand, Roll credits");
        //ClickSound.Play();
        //SceneManager.LoadScene("");
    }

    public void QuitButton() //Quit the game
    {
        Debug.Log("What? Not person enough? Pathetic");
        //ClickSound.Play();
        //Application.Quit();
    }
    #endregion

    #region Main Game Options Buttons

    public void ControlesButton() //Show the game controles
    {
        Debug.Log("You use a controle obviously");
        //ClickSound.Play();
        //TODO: Make picture appear
    }

    public void CloseButton() //Hide Options Menu in the main menu
    {
        pauseMenu.SetActive(false);
        //ClickSound.Play();
    }

    #endregion

}
