using UnityEngine;

public class SensorLogic : MonoBehaviour
{
    public GameObject upperJaw;
    public GameObject lowerJaw;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedWith = collision.gameObject;
        
        if (collidedWith.CompareTag("Food"))
        {
            upperJaw.GetComponent<JawsLogic>().Bite();
            lowerJaw.GetComponent<JawsLogic>().Bite();
            collidedWith.GetComponent<Animator>().SetBool("BeingEaten" , true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject collidedWith = collision.gameObject;

        if (collidedWith.CompareTag("Food"))
        {
            upperJaw.GetComponent<JawsLogic>().Open();
            lowerJaw.GetComponent<JawsLogic>().Open();
        }
    }
}
