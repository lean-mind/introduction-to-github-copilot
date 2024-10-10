### System Description

#### Overview

The `String Calculator` is a utility designed to process string inputs and return results based on specific rules.
This system is implemented to practice refactoring, incremental implementation, and Test-Driven Development (TDD).

#### Functional Requirements
*Basic Addition*: 
    - Function: `add` 
    - Input: A string containing 0, 1, or 2 numbers separated by commas. 
    - Output: The sum of the numbers as a string. - Special Case: An empty string returns "0". 
    - Example: `""`, `"1"`, `"1.1,2.2"`.
*Multiple Numbers*: 
    - The `add` method can handle an unknown number of arguments.  
*Newline as Separator*: 
    - The `add` method can handle newlines as separators. 
    - Example: `"1\n2,3"` returns `"6"`.
*Custom Separators*: 
    - The `add` method can handle different delimiters specified at the beginning of the input.
    - Example: `"//;\n1;2"` returns `"3"`. 
    - returns `"'|' expected but ',' found at position 3."`.  
