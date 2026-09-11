using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI endGameScoreText;
    void Start()
    {
        endGameScoreText.text = $"You scored {GameManager.GetScore()} points";
    }
}
