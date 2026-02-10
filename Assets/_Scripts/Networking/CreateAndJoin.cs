using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField inputCreate;
    [SerializeField] TMP_InputField inputJoin;
    [SerializeField] private Button createButton;
    [SerializeField] private Button joinButton;

    private void Start()
    {
        CheckInputFields(); //Run once when scene loades
    }
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(
            inputCreate.text,
            new RoomOptions() { MaxPlayers = 2 }
        );
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(inputJoin.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room as: " + PhotonNetwork.NickName);

        // Only Master loads scene
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel("GamePlay");
        }
    }

    public void CheckInputFields()
    {
        createButton.interactable = !string.IsNullOrEmpty(inputCreate.text);
        joinButton.interactable = !string.IsNullOrEmpty(inputJoin.text);
    }

}
