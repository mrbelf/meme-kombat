using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] string gameSceneName;
    [SerializeField] TMP_InputField field;
    [SerializeField] private string steamId;
    [SerializeField] private GameObject fieldPanel;
    [SerializeField] private GameObject gameModePanel;

    private void Start()
    {
        fieldPanel.SetActive(false);
        gameModePanel.SetActive(false);
    }

    public void OnPlayButton() 
    {
        fieldPanel.SetActive(true);
    }

    public void OnSetSteamID() 
    {
        steamId = field.text;
        fieldPanel.SetActive(false);
        gameModePanel.SetActive(true);
    }

    public void GoToGameScene() 
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
