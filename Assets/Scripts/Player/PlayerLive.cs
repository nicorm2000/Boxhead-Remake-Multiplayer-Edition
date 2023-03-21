using System;
using UnityEngine;
[SerializeField]
public class PlayerLive
{
    [SerializeField] private int life = 100;
    [SerializeField] private Func<float,float> OnValueChange = null;
    public void Init(Func<float,float> OnValueChange)
    {
        OnValueChange = this.OnValueChange;
    }
    public void TakeDamage(int less)
    {
        life-=less;
        OnValueChange?.Invoke(life);
        if (life <= 0)
            Die();
    }

    private void Die()
    {
        Debug.Log("Die");
    }
    public int GetLive()
    {
        return life;
    }
}
public interface IDamageable
{
    void TakeDamage(int less);
}
