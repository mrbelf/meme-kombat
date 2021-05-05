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
    [SerializeField] private GameObject otherIdPanel;
    [SerializeField] TMP_InputField otherIdField;
    [SerializeField] private string otherSteamId;

    ConnectionMode mode;

    public enum ConnectionMode 
    {
        Client = 0,
        Host = 1
    }

    private void Start()
    {
        fieldPanel.SetActive(false);
        //gameModePanel.SetActive(false);
    }

    public void OnPlayButton() 
    {
        fieldPanel.SetActive(true);
    }

    public void OnSetSteamID() 
    {
        steamId = field.text;
        //fieldPanel.SetActive(false);
        //gameModePanel.SetActive(true);
        ApplySettings();
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnClientButton() 
    {
        SelectMode(ConnectionMode.Client);
    }

    public void OnHostButton() 
    {
        SelectMode(ConnectionMode.Host);
    }

    public void SelectMode(ConnectionMode mode) 
    {
        this.mode = mode;
        if (mode == ConnectionMode.Client)
        {
            otherIdPanel.SetActive(true);
        }
        else 
        {
            ApplySettings();
            LoadGameScene();
        }
    }

    public void OnExitButton() 
    {
        Application.Quit();
    }

    public void SetOtherId() 
    {
        otherSteamId = otherIdField.text;
        ApplySettings();
        LoadGameScene();
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void GoToGameScene() 
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void ApplySettings() 
    {
        var msh = MultiplayerSettingsHolder.GetInstance();
        msh.playerId = this.steamId;
       // msh.otherId = this.otherSteamId;
       // msh.mode = (MultiplayerSettingsHolder.ConnectionMode)this.mode;
    }
}
