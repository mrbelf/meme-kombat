using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using Mirror.FizzySteam;

public class GameManager : NetworkBehaviour
{
    public string mainMenuSceneName = "MainMenu";
    public void OnBackToMenu() 
    {
        var nnm = FindObjectOfType<NewNetworkManager>();
        nnm.StopHost();
        nnm.OnStopClient();
        Destroy(nnm.gameObject);
        Destroy(FindObjectOfType<SteamManager>().gameObject);
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
