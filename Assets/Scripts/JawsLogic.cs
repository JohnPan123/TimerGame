using UnityEngine;

public class JawsLogic : MonoBehaviour
{
    public Animator jawsAnimator;

    /// <summary>
    /// Sets the animator to play the close jaw animations
    /// for the upper and lower jaws.
    /// </summary>
    public void Bite()
    {
        jawsAnimator.SetBool("FoodPresent" , true);
    }

    /// <summary>
    /// Sets the animator to play the open jaw animations
    /// for the upper and lower jaws.
    /// </summary>
    public void Open()
    {
        jawsAnimator.SetBool("FoodPresent", false);
    }
}
