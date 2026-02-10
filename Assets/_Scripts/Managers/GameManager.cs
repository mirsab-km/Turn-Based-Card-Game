using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateOpponentFoldCount(int count)
    {
        Debug.Log("Opponent folded cards count: " + count);
    }
}
