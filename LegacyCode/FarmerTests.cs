using System.Collections.Generic;
using refactoring_chest;
using Xunit;


public class FarmerTests
{
    public class SpellShould
    {
        [Fact]
        public void Chests_WhenTheyAreEmpty()
        {
            var items = new List<Item>
            {
                new Item("wood", 5),
                new Item("wood", 2),
                new Item("stone", 3),
                new Item("mushroom", 1),
                new Item("wheat seed", 4),
                new Item("potato seed", 2),
                new Item("trout", 1),
                new Item("cooper ore", 3)
            };
            var expectedSortedMaterials = new[]
            {
                new Item("cooper ore", 3),
                new Item("stone", 3),
                new Item("wood", 5),
                new Item("wood", 2)
            };
            var expectedSortedSeeds = new[]
            {
                new Item("potato seed", 2),
                new Item("wheat seed", 4)
            };
            var expectedSortedFood = new[]
            {
                new Item("mushroom", 1),
                new Item("trout", 1)
            };
            var farmer = new Farmer();
            farmer.Fill(items);

            farmer.Spell();

            Assert.Equal(expectedSortedMaterials, farmer.GetChest1());
            Assert.Equal(expectedSortedSeeds, farmer.GetChest2());
            Assert.Equal(expectedSortedFood, farmer.GetChest3());
        }

        [Fact]
        public void EmptyTheBackpackAfterSorting()
        {
            var items = new List<Item>
            {
                new Item("wood", 5),
                new Item("wood", 2),
                new Item("stone", 3),
                new Item("mushroom", 1),
                new Item("wheat seed", 4),
                new Item("potato seed", 2),
                new Item("trout", 1),
                new Item("cooper ore", 3)
            };
            var farmer = new Farmer();
            farmer.Fill(items);

            farmer.Spell();

            Assert.Empty(farmer.GetBackpack());
        }

        [Fact]
        public void DiscardItemsThatDoNotFitInChests()
        {
            var farmer = new Farmer();
            var items1 = new List<Item>
            {
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 2),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 3)
            };
            farmer.Fill(items1);
            farmer.Spell();

            var items2 = new List<Item>
            {
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 4),
                new Item("coal", 2)
            };
            farmer.Fill(items2);
            farmer.Spell();

            var items3 = new List<Item>
            {
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("coal", 5),
                new Item("coal", 5),
                new Item("coal", 5),
                new Item("cooper ore", 5)
            };
            farmer.Fill(items3);

            farmer.Spell();

            var expectedSortedMaterials = new[]
            {
                new Item("coal", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 5),
                new Item("stone", 2),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5),
                new Item("wood", 5)
            };
            Assert.Equal(expectedSortedMaterials, farmer.GetChest1());
        }
    }
}