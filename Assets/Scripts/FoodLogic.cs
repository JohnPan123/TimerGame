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
        /*
         * This timer makes sense to have on the food objects themselves. They each track
         * how long they were alive for. The global spawn timer cannot do this (not simply, 
         * at least). This is a one time use timer.
         */
        if (timeAlive >= maxAliveTime)
            foodAnimator.SetBool("AliveTooLong" , true);
    }

    /// <summary>
    /// Not used in code; used by the animator to destroy the food when the "squish" animation 
    /// is finished or when the "FadeAwayDeath" animation is finished.
    /// </summary>
    public void DestroyFood()
    {
        Destroy(gameObject);
    }
}
