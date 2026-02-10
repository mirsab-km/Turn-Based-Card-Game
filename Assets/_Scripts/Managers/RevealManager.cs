using UnityEngine;

public class RevealManager : MonoBehaviour
{
    public static RevealManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void OnReceiveReveal(RevealCardMessage msg)
    {
        Debug.Log("Reveal card received. CardId: " + msg.cardId);
    }
}
