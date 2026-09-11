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
    /// <summary>
    /// Returns a boolean value that represents whether or not there is food in 
    /// the player's mouth.
    /// </summary>
    /// <returns>Return true if food is not in the player's mouth. False otherwise</returns>
    public static bool NoFoodInMouth()
    {
        return foodAbsent;
    }
}
