using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManagement : MonoBehaviour
{
    public GameObject optionMenu;
    public GameObject pauseMenu;

    //public AudioSource ClickSound;

    void Start()
    {
        pauseMenu.SetActive(false); //Start game without pause menu visible
        optionMenu.SetActive(false); //Start game without options menu visible
    }

    #region Main Game Menu Buttons
    public void StartButton() //Start the game
    {
        Debug.Log("LETS GO");
        //ClickSound.Play();
        SceneManager.LoadScene("Greybox");
    }

    public void OptionButton() //Show Options Menu in the main menu
    {
        optionMenu.SetActive(true);
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

    public void OpenOptionMenu() //Open the pause menu
    {

        if (SceneManager.GetActiveScene().name == "Main Menu" && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Thingy");
            //optionMenu.SetActive(true);
            // TODO Pause game and make menu apear
        }
    }

    public void ControlesButton() //Show the game controles
    {
        Debug.Log("You use a controle obviously");
        //ClickSound.Play();
        // TODO Make picture appear
    }

    public void CloseButton() //Hide Options Menu in the main menu
    {
        optionMenu.SetActive(false);
        //ClickSound.Play();
    }

    #endregion

    #region Pause Buttons
    public void OpenPauseMenu() //Open the pause menu
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Thingy");
            //pauseMenu.SetActive(true);
            // TODO Pause game and make menu apear
        }
    }

    public void BackButton() //Hide Pause Menu and go back to the game
    {
        //pauseMenu.SetActive(false);
        //ClickSound.Play();
        // TODO Unpause game
    }
    #endregion

}
