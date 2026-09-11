using UnityEngine;

public class FoodLogic : MonoBehaviour
{
    public Rigidbody2D foodRB;

    private void Start()
    {
        foodRB.linearVelocity = new Vector2(0 - transform.position.x, 0 - transform.position.y);
    }
    public void DestroyFood()
    {
        Destroy(gameObject);
    }
}
