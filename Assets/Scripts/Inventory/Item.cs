using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
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

    public virtual bool use()
    {
        return false;
    }
    public bool isUnlocked()
    {
        return unlock;
    }
}
