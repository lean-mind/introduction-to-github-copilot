# Refactoring

## 1. Chest Kata

### 1.1. Description

It is an automatic sorting system for objects in chests. The chests are divided into three categories:
materials, food, and seeds. Each chest has a maximum capacity of 16 objects.

### 1.2. Requirements

1. **Backpack Capacity**
   - The backpack has a capacity of 8 objects.

2. **Object Sorting**
   - Objects will be sorted alphabetically in their respective chests.
   - Objects will be grouped by quantity, from highest to lowest.

3. **Chest Capacity**
   - Each chest has a maximum capacity of 16 objects.
   - If a chest is full, additional objects will be discarded.

4. **Object Grouping**
   - If an object is already in the chest, the quantity will be added up to a maximum of 5 per position.

### Object Types

- **Building Materials:**
  - Wood
  - Stone
  - Coal
  - Copper Ore
  - Iron Ore

- **Seeds:**
  - Wheat Seed
  - Potato Seed
  - Carrot Seed
  - Corn Seed
  - Kale Seed

- **Food:**
  - Raspberry
  - Apricot
  - Wild Onion
  - Mushroom
  - Trout

### Example

#### Input:
- Backpack:
  - 2 Wood
  - 5 Wood
  - 3 Stone
  - 1 Mushroom
  - 4 Wheat Seed
  - 2 Potato Seed
  - 1 Trout
  - 3 Copper Ore

#### Output:
- **Materials Chest:**
  - 5 Wood
  - 2 Wood
  - 3 Copper Ore
  - 3 Stone

- **Seeds Chest:**
  - 2 Potato Seed
  - 4 Wheat Seed

- **Food Chest:**
  - 1 Mushroom
  - 1 Trout

### Requirements in Given-When-Then Format

1. **Backpack Capacity**
   - **Given** a backpack
   - **When** objects are added
   - **Then** the backpack can hold up to 8 objects

2. **Object Sorting**
   - **Given** objects in the backpack
   - **When** they are sorted into chests
   - **Then** objects are sorted alphabetically in their respective chests
   - **And** objects are grouped by quantity, from highest to lowest

3. **Chest Capacity**
   - **Given** a chest
   - **When** objects are added
   - **Then** the chest can hold up to 16 objects
   - **And** if the chest is full, additional objects are discarded

4. **Object Grouping**
   - **Given** an object already in the chest
   - **When** more of the same object is added
   - **Then** the quantity is added up to a maximum of 5 per position