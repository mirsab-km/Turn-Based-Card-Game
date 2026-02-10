using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CardSelectionManager : MonoBehaviour
{
    public static CardSelectionManager Instance;

    public Transform handArea;
    public Transform foldArea;

    private List<CardView> selectedCards = new List<CardView>();

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateSelection(CardView card)
    {
        if (card.isSelected)
            selectedCards.Add(card);
        else
            selectedCards.Remove(card);
    }

    public void FoldSelectedCards()
    {
        foreach (var card in selectedCards)
        {
            card.SetFolded();
        }

        // Send folded count to opponent
        SyncBoardMessage msg = new SyncBoardMessage();
        msg.action = "syncBoard";
        msg.opponentCardCount = selectedCards.Count;

        string json = JsonUtility.ToJson(msg);
        NetworkMessenger.Instance.SendMessageToOther(json);

        selectedCards.Clear();
    }
}
