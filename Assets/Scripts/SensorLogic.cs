using UnityEngine;

public class SensorLogic : MonoBehaviour
{
    public GameObject upperJaw;
    public GameObject lowerJaw;
    /*
     * In both of these collisions, I do not check for what I am colliding with because I do not need to.
     * I modified the collision layer matrix so that the sensor layer can only collide with the food layer.
     * Thus, there is no concern for other collisions happening.
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        upperJaw.GetComponent<JawsLogic>().Bite();
        lowerJaw.GetComponent<JawsLogic>().Bite();
        collision.gameObject.GetComponent<Animator>().SetBool("BeingEaten" , true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.IncreaseScore();
        upperJaw.GetComponent<JawsLogic>().Open();
        lowerJaw.GetComponent<JawsLogic>().Open();
    }
}
