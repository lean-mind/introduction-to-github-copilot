## Specification Requirements

### Introduction
Given that we are a small inn with a prime location in a prominent city, run by a friendly innkeeper named Allison, we buy and sell only the finest goods. Unfortunately, our goods are constantly degrading in quality as they approach their sell-by date.

### Inventory System
Given that we have a system that updates our inventory, developed by a pragmatic guy named Leeroy, who has moved on to new adventures, your task is to add a new feature to our system so that we can begin selling a new category of items.

### General Rules
- Given that all items have a `SellIn` value which denotes the number of days we have to sell the items.
- And that all items have a `Quality` value which denotes how valuable the item is.
- When the day ends, our system lowers both values for every item.

### Specific Rules
- Given that the sell-by date has passed,
  - Then the quality degrades twice as fast.
- Given that the quality of an item is never negative.
- Given that "Aged Brie" increases in quality as it gets older.
- Given that the quality of an item is never more than 50.
- Given that "Sulfuras", being a legendary item, never has to be sold nor decreases in quality.
- Given that "Backstage passes" increase in quality as their `SellIn` value approaches;
  - Then the quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less.
  - But the quality drops to 0 after the concert.

### New Requirements
- Given that we have recently signed a supplier of conjured items,
  - Then "Conjured" items degrade in quality twice as fast as normal items.

### Constraints
- Given that you can make any changes to the `UpdateQuality` method and add any new code as long as everything still works correctly.
- Then you must not alter the `Item` class or the `Items` property as those belong to the goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code ownership (you can make the `UpdateQuality` method and `Items` property static if you like, we'll cover for you).

### Clarification
- Given that an item can never have its quality increase above 50,
  - Then "Sulfuras" is a legendary item and, as such, its quality is 80 and it never alters.