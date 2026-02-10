using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public int cardId;
    public bool isSelected = false;

    [SerializeField] private Image highlight;

    private void Start()
    {
        highlight.enabled = isSelected;
    }


    public void OnCardClicked()
    {
        if (TurnManager.Instance == null) return;
        isSelected = !isSelected;
        highlight.enabled = isSelected;
        Debug.Log("Pressed");
        CardSelectionManager.Instance.UpdateSelection(this);
    }

    public void SetFolded()
    {
        isSelected = false;
        highlight.enabled = false;
        gameObject.transform.SetParent(CardSelectionManager.Instance.foldArea);
    }
}
