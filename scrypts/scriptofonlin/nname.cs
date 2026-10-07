using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class nname : MonoBehaviour
{
    public string n;
   [SerializeField] PhotonView pv;
    public Text nick;
    void Start()
    {
        n = pv.Owner.NickName;
        nick.text = pv.Owner.NickName;
    }

}
