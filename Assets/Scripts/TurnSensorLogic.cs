using UnityEngine;

public class TurnSensorLogic : MonoBehaviour
{
    private static bool foodAbsent = true;
    private void OnTriggerStay2D(Collider2D collision)
    {
        foodAbsent = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        foodAbsent = true;
    }

    public static bool NoFoodInMouth()
    {
        return foodAbsent;
    }
}
