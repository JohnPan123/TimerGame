using UnityEngine;
using System.Collections.Generic;

public class SpawnerLogic : MonoBehaviour
{
    public GameObject food;
    private List<Vector2> locations = new List<Vector2>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float maxX = Camera.main.aspect * Camera.main.orthographicSize;
        float maxY = Camera.main.orthographicSize;

        locations.Add(new Vector2(maxX + 2 , 0));
        locations.Add(new Vector2(-(maxX + 2) , 0));
        locations.Add(new Vector2(0 , maxY + 2));
        locations.Add(new Vector2(0 , -(maxY + 2)));
    }

    private void Update()
    {
        transform.position = locations[Random.Range(0, 4)];
    }

    /// <summary>
    /// Spawns food in the proper orientation. This is because the animator only has one animation
    /// for squishing the food; it does this in the y-direction. Thus, the spawner is rotated
    /// as it teleports around so that the spawned food can takes on its rotation for the squish animation.
    /// </summary>
    public void SpawnFood()
    {
        if (transform.position.x > 0)
            transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (transform.position.x < 0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (transform.position.y > 0)
            transform.rotation = Quaternion.Euler(0, 0, -90);
        else if (transform.position.y < 0)
            transform.rotation = Quaternion.Euler(0, 0, 90);

        Instantiate(food, transform.position , transform.rotation);
    }
}