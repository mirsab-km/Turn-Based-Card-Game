using UnityEngine;
using TMPro;
using Photon.Pun;

public class Username : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInput;

    public void SaveUsername()
    {
        PhotonNetwork.NickName = usernameInput.text;
        Debug.Log("Username set: " + PhotonNetwork.NickName);
    }
}
