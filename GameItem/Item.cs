using System;

class Item
{
    public string Name;
    public int Price;

    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"아이템명: {Name}, 가격: {Price}원";
    }
}