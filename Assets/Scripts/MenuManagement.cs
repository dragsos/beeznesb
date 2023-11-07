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
    public GameObject optionMenu;
    public GameObject pauseMenu;
    public GameObject creditMenu;
    public GameObject controlesPicture;

    public AudioSource ClickSound;

    [SerializeField] private InputActionReference triggerAction;

    void Start()
    {
        pauseMenu.SetActive(false); //Start game without pause menu visible
        optionMenu.SetActive(false); //Start game without options menu visible
        creditMenu.SetActive(false); //Start game without credit menu visible
        controlesPicture.SetActive(false); //Start game without picture of the controles visible

        triggerAction.action.Enable();
        triggerAction.action.performed += OnTriggerButtonPress;
    }

    private void OnDestroy()
    {
        triggerAction.action.Disable();
        triggerAction.action.performed -= OnTriggerButtonPress;
    }

    #region Menu Buttons
    public void StartButton() //Start the game
    {
        Debug.Log("LETS GO");
        ClickSound.Play();
        SceneManager.LoadScene("Greybox");
    }

    public void OptionButton() //Show Options Menu in the main menu
    {
        ClickSound.Play();
        optionMenu.SetActive(true);        
    }

    public void CreditsButton() //Play credits
    {
        Debug.Log("Aaaaaand, Roll credits");
        ClickSound.Play();
        optionMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void QuitButton() //Quit the game
    {
        Debug.Log("What? Not person enough? Pathetic");
        ClickSound.Play();
        Application.Quit();
    }
    #endregion

    #region Credit Buttons

    public void HideCreditsButton() //Get rid of credits
    {
        Debug.Log("Aaaaaand, back");
        ClickSound.Play();
        creditMenu.SetActive(false);
    }

    #endregion

    #region Options Buttons
    public void OpenOptionMenu() //Open the pause menu
    {
            Debug.Log("Choices");
            optionMenu.SetActive(true);
    }

    public void ControlesButton() //Show the game controles
    {
        Debug.Log("You use a controle obviously");
        ClickSound.Play();
        controlesPicture.SetActive(true);
    }

    public void HideControlesButton() //hide the game controles
    {
        Debug.Log("You don't use a controle obviously");
        ClickSound.Play();
        controlesPicture.SetActive(false); 
    }

    public void HideOptionsButton() //Hide Options Menu in the main menu
    {
        ClickSound.Play();
        optionMenu.SetActive(false);
        controlesPicture.SetActive(false);
    }
    #endregion

    #region Main Game Pause Buttons
    public void OnTriggerButtonPress(InputAction.CallbackContext context) //Open the pause menu
    {
        Debug.Log("Opens Thingy");
        //Time.timeScale = 0.0f; //If this the player can not look around
        pauseMenu.SetActive(true);
    }

    void BackButton() //Hide Pause Menu and go back to the game
    {
        ClickSound.Play();
        pauseMenu.SetActive(false);
    }
    #endregion

}
