using System.Collections.Generic;
using UnityEngine;


enum InventoryItems
{
    PISTOL,
    UZI,
    MAX
}

public class Inventory : MonoBehaviour
{
    [SerializeField] private KeyCode next;
    [SerializeField] private KeyCode prev;

    [SerializeField] private int selectItem = 0;
    List<Item> items;
    // Start is called before the first frame update
    void Start()
    {
        items = new List<Item>();
        items.Add(new Gun("Pistol",int.MaxValue));
        items.Add(new Gun("Uzi",200));
        items[0].Unlock();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(next))
            selectNext();
        if (Input.GetKey(prev))
            SelectPrev();
    }

    void selectNext()
    {
        selectItem++;
        if (selectItem>=(int)InventoryItems.MAX)
        {
            selectItem = (int)InventoryItems.PISTOL;
        }
        if (!items[selectItem].isUnlocked())
        {
            selectNext();
        }
    }
    void SelectPrev()
    {
        selectItem--;
        if (selectItem <= (int)InventoryItems.PISTOL)
        {
            selectItem = (int)InventoryItems.MAX-1;
        }
        if (!items[selectItem].isUnlocked())
        {
            SelectPrev();
        }
    }
    void UnlockByIndex(int index)
    {
        if ((index<= (int)InventoryItems.MAX) && (index>=(int)InventoryItems.PISTOL))
        {
            items[index].Unlock();
        }
    }

}