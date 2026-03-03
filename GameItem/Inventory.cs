using System;

class Inventory
{
    private int itemNum = 0;
    object[] Inventories = new Item[10];

    public void AddItem(object item)
    {
        Inventories[itemNum++] = item;
    }

    public void ShowInventory()
    {
        for(int i = 0; i < itemNum; i++)
        {
            Console.Write($"슬롯 {i+1}: {Inventories[i].GetType()} ");
            Console.WriteLine($"{Inventories[i]} [{Inventories[i].GetType()}]");
        }
    }
}