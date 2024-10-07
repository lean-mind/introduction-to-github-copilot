namespace refactoring_chest;

using System;
using System.Collections.Generic;
using System.Linq;

public class Farmer
{
    private readonly List<Item> backpack = new List<Item>();
    private readonly List<Item> chest1 = new List<Item>();
    private readonly List<Item> chest2 = new List<Item>();
    private readonly List<Item> chest3 = new List<Item>();

    public List<Item> GetBackpack()
    {
        return backpack;
    }

    public List<Item> GetChest1()
    {
        return chest1;
    }

    public List<Item> GetChest2()
    {
        return chest2;
    }

    public List<Item> GetChest3()
    {
        return chest3;
    }

    public void Fill(List<Item> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (backpack.Count < 16)
            {
                backpack.Add(items[i]);
            }
        }
    }

    public void Spell()
    {
        foreach (var item in backpack)
        {
            switch (item.GetName())
            {
                // materials
                case "wood":
                case "stone":
                case "coal":
                case "cooper ore":
                case "iron ore":
                    var items1 = chest1.Where(chestItem => chestItem.GetName().Equals(item.GetName())).ToList();
                    // if not exist any item with the same name, add the item to the chest
                    if (!items1.Any() && chest1.Count < 16)
                    {
                        chest1.Add(item);
                    }
                    else
                    {
                        for (int i = 0; i < items1.Count; i++)
                        {
                            if (items1[i].GetQuantity() < 5)
                            {
                                while (item.GetQuantity() != 0 && items1[i].GetQuantity() < 5)
                                {
                                    items1[i].SetQuantity(items1[i].GetQuantity() + 1);
                                    item.SetQuantity(item.GetQuantity() - 1);
                                }
                            }
                        }

                        if (item.GetQuantity() != 0 && chest1.Count < 16)
                        {
                            chest1.Add(item);
                        }
                    }

                    break;
                // seeds
                case "wheat seed":
                case "potato seed":
                case "carrot seed":
                case "corn seed":
                case "kale seed":
                    var items2 = chest2.Where(chestItem => chestItem.GetName().Equals(item.GetName())).ToList();
                    if (!items2.Any() && chest2.Count < 16)
                    {
                        chest2.Add(item);
                    }
                    else
                    {
                        for (int i = 0; i < items2.Count; i++)
                        {
                            if (items2[i].GetQuantity() < 5)
                            {
                                while (item.GetQuantity() != 0 && items2[i].GetQuantity() < 5)
                                {
                                    items2[i].SetQuantity(items2[i].GetQuantity() + 1);
                                    item.SetQuantity(item.GetQuantity() - 1);
                                }
                            }
                        }

                        if (item.GetQuantity() != 0 && chest2.Count < 16)
                        {
                            chest2.Add(item);
                        }
                    }

                    break;
                // food
                case "raspberry":
                case "apricot":
                case "wild onion":
                case "mushroom":
                case "trout":
                    var items3 = chest3.Where(chestItem => chestItem.GetName().Equals(item.GetName())).ToList();
                    if (!items3.Any() && chest3.Count < 16)
                    {
                        chest3.Add(item);
                    }
                    else
                    {
                        for (int i = 0; i < items3.Count; i++)
                        {
                            if (items3[i].GetQuantity() < 5)
                            {
                                while (item.GetQuantity() != 0 && items3[i].GetQuantity() < 5)
                                {
                                    items3[i].SetQuantity(items3[i].GetQuantity() + 1);
                                    item.SetQuantity(item.GetQuantity() - 1);
                                }
                            }
                        }

                        if (item.GetQuantity() != 0 && chest3.Count < 16)
                        {
                            chest3.Add(item);
                        }
                    }

                    break;
                default:
                    // if the object not in the list, do nothing
                    break;
            }
        }

        chest1.Sort((x, y) => string.Compare(x.GetName(), y.GetName(), StringComparison.Ordinal));
        chest2.Sort((x, y) => string.Compare(x.GetName(), y.GetName(), StringComparison.Ordinal));
        chest3.Sort((x, y) => string.Compare(x.GetName(), y.GetName(), StringComparison.Ordinal));

        backpack.Clear();
    }
}