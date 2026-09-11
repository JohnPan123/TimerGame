using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnerLogic spawnerScript;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private float timerForNextSpawn = 0f;
    private float timeToSpawnFood = 1f;
    // Update is called once per frame
    void Update()
    {
        timerForNextSpawn += Time.deltaTime;

        if (timerForNextSpawn >= timeToSpawnFood)
        {
            spawnerScript.SpawnFood();
            timerForNextSpawn = 0;
        }
    }

    /// <summary>
    /// Increases the score by one and updates the score text on the player's screen.
    /// </summary>
    public void IncreaseScore()
    {
        scoreText.text = $"Score: {++score}";
    }

    public void DecreaseScore()
    {
        scoreText.text = $"Score: {--score}";
    }
}
