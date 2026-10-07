using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class sp : MonoBehaviour
{
    public GameObject Player;
    public float MinX, MinY, MaxX, MaxY;
    void Start()
    {
        Vector2 randomposition = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
        PhotonNetwork.Instantiate(Player.name, randomposition, Quaternion.identity);
    }

}
