using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
public class lobbymanager : MonoBehaviourPunCallbacks
{
    public InputField joinIn;
    public InputField createIn;
    public string namemm;
    void Start()
    {
        if (PlayerPrefs.HasKey("name"))
        {
            namemm = PlayerPrefs.GetString("name");
        }
        else
        {
            namemm = "Unknown Soul" + (Random.Range(0,1000)).ToString();
        }
       
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinIn.text);
    }

    public void CreateRoom()
    {
        RoomOptions rm = new RoomOptions();
        rm.MaxPlayers = 8;
        PhotonNetwork.CreateRoom(createIn.text, rm);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.NickName = namemm;
        PhotonNetwork.LoadLevel("Onlineserver");
    }

    public void disconnect()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene(0);
    }
    public void OnDisconnectedFromMasterServer()
    {
        SceneManager.LoadScene(0);
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        SceneManager.LoadScene(0);
    }
}
