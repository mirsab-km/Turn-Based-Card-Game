using UnityEngine;
using Photon.Pun;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    private int currentTurn = 1;
    private bool myTurnEnded = false;
    private bool opponentTurnEnded = false;

    private void Awake()
    {
        Instance = this;
    }

    public void EndMyTurn()
    {
        if (myTurnEnded) return;

        myTurnEnded = true;

        Debug.Log("I ended my turn");

        CardSelectionManager.Instance.FoldSelectedCards();
        // Send JSON to opponent
        EndTurnMessage msg = new EndTurnMessage();
        msg.action = "endTurn";
        msg.playerId = PhotonNetwork.NickName;

        string json = JsonUtility.ToJson(msg);
        NetworkMessenger.Instance.SendMessageToOther(json);

        CheckBothPlayersReady();
    }

    public void OnOpponentEndedTurn()
    {
        Debug.Log("Opponent ended turn");
        opponentTurnEnded = true;

        CheckBothPlayersReady();
    }

    private void CheckBothPlayersReady()
    {
        if (myTurnEnded && opponentTurnEnded)
        {
            Debug.Log("Both players ended turn. Start Reveal Phase");
            RevealManager.Instance.StartRevealPhase();

            PrepareNextTurn();
        }
    }

    private void PrepareNextTurn()
    {
        myTurnEnded = false;
        opponentTurnEnded = false;

        currentTurn++;

        if (currentTurn > 6)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Starting Turn: " + currentTurn);
        }
    }
}
