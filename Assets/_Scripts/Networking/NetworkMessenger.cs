using UnityEngine;
using Photon.Pun;

public class NetworkMessenger : MonoBehaviourPun
{
    public static NetworkMessenger Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Send JSON message to opponent
    public void SendMessageToOther(string jsonMessage)
    {
        photonView.RPC("ReceiveMessage", RpcTarget.Others, jsonMessage);
    }

    // Receive JSON message
    [PunRPC]
    void ReceiveMessage(string jsonMessage)
    {
        Debug.Log("Received JSON: " + jsonMessage);
        GameEvents.HandleNetworkMessage(jsonMessage);
    }
}
