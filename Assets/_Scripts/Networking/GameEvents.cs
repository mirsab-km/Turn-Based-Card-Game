using UnityEngine;

public static class GameEvents
{
    public static void HandleNetworkMessage(string json)
    {
        BaseMessage baseMsg = JsonUtility.FromJson<BaseMessage>(json);

        switch (baseMsg.action)
        {
            case "endTurn":
                TurnManager.Instance.OnOpponentEndedTurn();
                break;

            case "syncBoard":
                SyncBoardMessage sync =
                    JsonUtility.FromJson<SyncBoardMessage>(json);
                GameManager.Instance.UpdateOpponentFoldCount(sync.opponentCardCount);
                break;

            case "revealSingleCard":
                RevealCardMessage reveal =
                    JsonUtility.FromJson<RevealCardMessage>(json);
                RevealManager.Instance.OnReceiveReveal(reveal);
                break;
        }
    }
}
