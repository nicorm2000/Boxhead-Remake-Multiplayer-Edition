using UnityEngine;

public class InventoryS :MonoBehaviour, IPicapeable
{
    public void Onpick()
    {
        Debug.Log("OnPik");
        //give life if low or give ammo.
    }
}
public interface IPicapeable
{
    void Onpick();
}
