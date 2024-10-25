namespace refactoring_chest;

using System;

public sealed class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetQuantity()
    {
        return Quantity;
    }

    public void SetQuantity(int quantity)
    {
        Quantity = quantity;
    }

    public override bool Equals(object obj)
    {
        if (this == obj) return true;
        if (obj is not Item item) return false;
        return Quantity == item.Quantity && Name == item.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Quantity);
    }
}