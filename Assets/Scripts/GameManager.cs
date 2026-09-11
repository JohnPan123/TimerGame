using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SpawnerLogic spawnerScript;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeRemainingTimer;
    private static int score;
    private float totalGameTimeRemaining = 60f;
    private float timerForNextSpawn = 0f;
    private float timeToSpawnFood = 1f;
    private void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        totalGameTimeRemaining -= Time.deltaTime;
        timerForNextSpawn += Time.deltaTime;
        /*
         * This is the looping timer for the food spawn; Every so often it spawns another 
         * piece of food for the player to eat. The other timer, on the FoodLogic script
         * is a one time per food (if it was not eaten first) timer.
         */
        if (timerForNextSpawn >= timeToSpawnFood)
        {
            spawnerScript.SpawnFood();
            timerForNextSpawn = 0;
        }

        scoreText.text = $"Score: {score}";
        timeRemainingTimer.text = $"Time Remaining: {(int)totalGameTimeRemaining}";

        if ((int)totalGameTimeRemaining <= 0)
            SceneManager.LoadScene("GameOverScene");
    }

    /// <summary>
    /// Increases the score by one.
    /// </summary>
    public static void IncreaseScore()
    {
        score++;
    }

    /// <summary>
    /// Decreases the score by one.
    /// </summary>
    public static void DecreaseScore()
    {
        score--;
    }

    /// <summary>
    /// Returns the score value.
    /// </summary>
    /// <returns>Returns the score value.</returns>
    public static int GetScore()
    {
        return score;
    }
}