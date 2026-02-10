using UnityEngine;
using Photon.Pun;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;

        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Photon Connected. Loading Lobby...");
        PhotonNetwork.LoadLevel("Lobby");
    }
}
