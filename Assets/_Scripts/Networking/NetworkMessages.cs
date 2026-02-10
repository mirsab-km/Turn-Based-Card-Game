[System.Serializable]
public class BaseMessage
{
    public string action;
}

[System.Serializable]
public class EndTurnMessage
{
    public string action;
    public string playerId;
}

[System.Serializable]
public class SyncBoardMessage
{
    public string action;
    public int opponentCardCount;
}

[System.Serializable]
public class RevealCardMessage
{
    public string action;
    public string playerId;
    public int cardId;
    public int orderIndex;
}
