using System;

class Potion : Item
{
    public int HealAmount;

    public Potion(string name, int price, int healAmount) : base(name, price)
    {
        HealAmount = healAmount;
    }

    public override string ToString()
    {
        return $"{{ Name = {Name}, Price = {Price}, HealAmount = {HealAmount}}}";
    }
}
