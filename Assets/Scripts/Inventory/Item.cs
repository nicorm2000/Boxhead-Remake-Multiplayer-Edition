using UnityEngine;
using System;

[Serializable]
public abstract class Item
{
    [SerializeField] protected int bullets;
    [SerializeField] private string name;
    [SerializeField] private bool unlock;

    public Item(string name)
    {
        this.name = name;
        unlock = false;
    }
    public void Unlock()
    {
        unlock = true;
    }

    public abstract bool use(Vector3 pos, Vector3 dir);

    public abstract void Update();
    public bool isUnlocked()
    {
        return unlock;
    }
}
