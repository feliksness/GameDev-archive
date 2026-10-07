using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class contoserv : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void OnDisconnectedFromMasterServer()
    {
        SceneManager.LoadScene(0);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        SceneManager.LoadScene(0); 
    }
    public void disconnect()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene(0);
    }
}
       
