using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerLive live;
    [SerializeField] InventoryS inv;
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
}
