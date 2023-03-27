using UnityEngine;

public class Enemy : MonoBehaviour,IDamageable
{
    [SerializeField] PlayerLive live;

    public void TakeDamage(int less)
    {
        if (live != null) { live.TakeDamage(less); }
    }

    // Start is called before the first frame update
    void Start()
    {
        live = new PlayerLive();
    }
}

