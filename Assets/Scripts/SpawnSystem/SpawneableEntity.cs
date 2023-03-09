using UnityEngine;

public class SpawneableEntity : MonoBehaviour
{
    public static uint cuantity = 0; // reset this when game start.


    private void Start()
    {
        cuantity++;
    }
    private void OnDestroy()
    {
        cuantity--;
        Debug.Log("This spawneableEntity was destroy");
    }
}
