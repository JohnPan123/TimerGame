using UnityEngine;

public class JawsLogic : MonoBehaviour
{
    Animator jawsAnimator;
    private void Start()
    {
        jawsAnimator = GetComponent<Animator>();
    }
    public void Bite()
    {
        jawsAnimator.SetBool("FoodPresent" , true);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3) //The jaws layer
            jawsAnimator.SetBool("FoodPresent" , false);
    }
}
