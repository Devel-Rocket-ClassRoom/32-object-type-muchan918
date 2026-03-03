using System;

class Weapon : Item
{
    public int Damage;

    public Weapon(string name, int price, int damage):base(name, price)
    {
        Damage = damage;
    }

    public override string ToString()
    {
        return $"{{ Name = {Name}, Price = {Price}, Damage = {Damage}}}";
    }
}