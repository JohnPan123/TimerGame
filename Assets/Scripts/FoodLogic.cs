using UnityEngine;

public class FoodLogic : MonoBehaviour
{
    public Rigidbody2D foodRB;
    public Animator foodAnimator;
    private float speedMultiplier = 0.85f;
    private void Start()
    {
        foodRB.linearVelocity = new Vector2(-transform.position.x * speedMultiplier , -transform.position.y * speedMultiplier);
    }
    private float timeAlive = 0f;
    private float maxAliveTime = 2f;
    private void Update()
    {
        timeAlive += Time.deltaTime;

        if (timeAlive >= maxAliveTime)
            foodAnimator.SetBool("AliveTooLong" , true);
    }
    public void DestroyFood()
    {
        Destroy(gameObject);
    }
}
