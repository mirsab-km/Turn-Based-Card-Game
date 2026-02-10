using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    public void OnEndTurnPressed()
    {
        TurnManager.Instance.EndMyTurn();
    }
}
