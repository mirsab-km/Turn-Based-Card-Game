using Photon.Pun;
using UnityEngine;

public class TestJsonSend : MonoBehaviour
{
    public void SendTest()
    {
        EndTurnMessage msg = new EndTurnMessage();
        msg.action = "endTurn";
        msg.playerId = PhotonNetwork.NickName;

        string json = JsonUtility.ToJson(msg);

        NetworkMessenger.Instance.SendMessageToOther(json);
    }
}
