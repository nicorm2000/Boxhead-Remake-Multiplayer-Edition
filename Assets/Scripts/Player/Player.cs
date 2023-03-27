using System;
using UnityEngine;

public class Player : MonoBehaviour, IPicapeable, IDamageable
{
    [SerializeField] PlayerLive live;
    private void Start()
    {
        live = new PlayerLive();
    }
    public void TakeDamage(int i)
    {
        if (live != null) { live.TakeDamage(i); }
    }

    public int GetLive()
    {
        if (live != null) { return live.GetLive(); } return -1;
    }

    public void InitCanvasLive(Func<float,float> actionOnLiveChange)
    {
        live.Init(actionOnLiveChange);
    }

    public void Onpick()
    {
        Debug.Log("OnPik");
        if (live !=null)
        {
            if (live.LiveAddWhenLow())
                return;
            else
                Debug.Log("Add Armor");
        }
        //give life if low or give ammo.
    }
}
