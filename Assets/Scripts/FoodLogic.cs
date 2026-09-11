using UnityEngine;

public class FoodLogic : MonoBehaviour
{
    public Rigidbody2D foodRB;
    public Animator foodAnimator;
    private void Start()
    {
        foodRB.linearVelocity = new Vector2(0 - transform.position.x, 0 - transform.position.y);
    }
    float timeAlive = 0f;
    private void Update()
    {
        timeAlive += Time.deltaTime;

        if (timeAlive > 5f)
            foodAnimator.SetBool("AliveTooLong" , true);
    }
    public void DestroyFood()
    {
        Destroy(gameObject);
    }
}
