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
    public void IncreaseScore()
    {
        scoreText.text = $"Score: {++score}";
    }
}
