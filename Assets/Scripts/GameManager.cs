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
