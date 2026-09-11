using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnerLogic spawnerScript;
    public TextMeshProUGUI scoreText;
    private static int score;
    private float timerForNextSpawn = 0;
    private float timeToSpawnFood = 1f;
    private void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        timerForNextSpawn += Time.deltaTime;

        if (timerForNextSpawn >= timeToSpawnFood)
        {
            spawnerScript.SpawnFood();
            timerForNextSpawn = 0;
        }

        scoreText.text = $"Score: {score}";
    }
    public static void IncreaseScore()
    {
        score++;
    }
}
