using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharSelectorManager : MonoBehaviour
{
    public TMP_InputField otherIdField;
    public NewNetworkManager nnm;

    public GameObject gameOver;
    public GameObject youWin;

    public void SelectChar(int i) 
    {
        CharSelector.GetInstance().Select(i);
    }

    public void SelectHost()
    {
        MultiplayerSettingsHolder.GetInstance().mode = MultiplayerSettingsHolder.ConnectionMode.Host;

        nnm.Init();
        this.gameObject.SetActive(false);
    }
    public void SelectClient()
    {
        MultiplayerSettingsHolder.GetInstance().otherId = otherIdField.text;
        MultiplayerSettingsHolder.GetInstance().mode = MultiplayerSettingsHolder.ConnectionMode.Client;

        nnm.Init();
        this.gameObject.SetActive(false);
    }

    public void StartGame() 
    {
        nnm.Init();
    }

    public void OnBack() 
    {
        gameOver.SetActive(false);
        youWin.SetActive  (false);
        if(MultiplayerSettingsHolder.GetInstance().mode == MultiplayerSettingsHolder.ConnectionMode.Client)
            nnm.StopClient();
        else
            nnm.StopHost();
        gameObject.SetActive(true);
    }
}
