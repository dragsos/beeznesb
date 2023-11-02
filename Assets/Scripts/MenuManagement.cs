using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;


public class MenuManagement : MonoBehaviour
{
    public UnityAction OnPause;

    public GameObject optionMenu;
    public GameObject pauseMenu;

    public AudioSource ClickSound;

    [SerializeField] private InputActionReference triggerAction;

    void Start()
    {
        pauseMenu.SetActive(false); //Start game without pause menu visible
        optionMenu.SetActive(false); //Start game without options menu visible
        triggerAction.action.Enable();
        triggerAction.action.performed += OnTriggerButtonPress;
    }

    private void OnDestroy()
    {
        triggerAction.action.Disable();
        triggerAction.action.performed -= OnTriggerButtonPress;
    }


    #region Main Game Menu Buttons
    public void StartButton() //Start the game
    {
        Debug.Log("LETS GO");
        ClickSound.Play();
        SceneManager.LoadScene("Greybox");
    }

    public void OptionButton() //Show Options Menu in the main menu
    {
        optionMenu.SetActive(true);
        ClickSound.Play();
    }

    public void CreditsButton() //Play credits
    {
        Debug.Log("Aaaaaand, Roll credits");
        ClickSound.Play();
        //SceneManager.LoadScene("");
    }

    public void QuitButton() //Quit the game
    {
        Debug.Log("What? Not person enough? Pathetic");
        ClickSound.Play();
        Application.Quit();
    }
    #endregion

    #region Main Game Options Buttons

    public void OpenOptionMenu() //Open the pause menu
    {

        if (SceneManager.GetActiveScene().name == "Main Menu" && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Thingy");
            optionMenu.SetActive(true);
        }
    }

    public void ControlesButton() //Show the game controles
    {
        Debug.Log("You use a controle obviously");
        ClickSound.Play();
        // TODO Make picture appear
    }

    public void CloseButton() //Hide Options Menu in the main menu
    {
        optionMenu.SetActive(false);
        ClickSound.Play();
    }

    #endregion

    #region Pause Buttons
    public void OnTriggerButtonPress(InputAction.CallbackContext context) //Open the pause menu
    {
        Debug.Log("Opens Thingy");
        //Time.timeScale = 0.0f; //If this the player can not look around
        pauseMenu.SetActive(true);
    }

    void BackButton() //Hide Pause Menu and go back to the game
        {
            //pauseMenu.SetActive(false);
            //ClickSound.Play();
            // TODO Unpause game
        }
    #endregion

}
