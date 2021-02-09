﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject optionsPanel;

    [SerializeField] string sceneName;

    float waitTillAnimationFinished = 3f;

    public void StartGame()
    {
        StartCoroutine(RemovePanel());
        //TODO: Let the game begin.
    }

    public void MarketPlaceOpened()
    {
        //TODO: Play animation for closing the menu
        StartCoroutine(RemovePanel());
        SceneManager.LoadSceneAsync(sceneName);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        Debug.Log("I loaded the Marketplace");
        mainPanel.SetActive(true);
    }
    public void OptionsMenuOpened()
    {
        StartCoroutine(RemovePanel());
        optionsPanel.SetActive(true);
        Debug.Log("You are now in the options menu");
        mainPanel.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    IEnumerator RemovePanel()
    {
        //TODO: Play animation for closing the menu
        yield return new WaitForSeconds(waitTillAnimationFinished);
        mainPanel.SetActive(false);
    }
}
