using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text opponentFoldText;
    private void Awake()
    {
        Instance = this;
    }

    public void UpdateOpponentFoldCount(int count)
    {
        opponentFoldText.text = "Opponent Folded: " + count;
    }

}
