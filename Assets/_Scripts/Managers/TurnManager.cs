using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void OnOpponentEndedTurn()
    {
        Debug.Log("Opponent ended turn");
    }
}
