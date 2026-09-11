using UnityEngine;

public class FoodLogic : MonoBehaviour
{
    Rigidbody2D foodRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foodRB = GetComponent<Rigidbody2D>();
    }

    public void SetFoodVelocity()
    {
        foodRB.linearVelocity = new Vector2(0 - transform.position.x , 0 - transform.position.y);
    }
}
