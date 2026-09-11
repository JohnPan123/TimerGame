using UnityEngine;

public class JawsLogic : MonoBehaviour
{
    public Animator jawsAnimator;
    public void Bite()
    {
        jawsAnimator.SetBool("FoodPresent" , true);
    }
    public void Open()
    {
        jawsAnimator.SetBool("FoodPresent", false);
    }
}
