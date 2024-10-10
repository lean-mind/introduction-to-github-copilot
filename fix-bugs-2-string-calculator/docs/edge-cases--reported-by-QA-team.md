## Edge Cases
### Separator at the End
- Issue: Input ending in a separator is not handled correctly.
- Expected: "1,3," should return the message "Number expected but EOF found."

### Missing Number in Last Position
- Issue: Missing number in the last position is not handled correctly.
- Expected: "175.2,\n35" should return the message "Number expected but '\n' found at position 6."

### Negative Numbers
- Issue: Negative numbers are not handled correctly.
- Expected: Calling `add` with negative numbers should return the message "Negative not allowed: " listing all negative numbers.
  - "-1,2" should return the message "Negative not allowed: -1"
  - "2,-4,-5" should return the message "Negative not allowed: -4, -5"

### Multiple Errors
- Issue: Multiple errors are not handled correctly.
- Expected: Calling `add` with multiple errors should return all error messages separated by newlines.
  - "-1,,2" should return the message "Negative not allowed: -1\nNumber expected but ',' found at position 3."
  - "-1,,-2" should return the message "Negative not allowed: -1\nNumber expected but ',' found at position 3.\nNegative not allowed: -2"

### Error Management
- Issue: Error messages are not managed correctly.
- Expected: Introduce an internal `add` function that returns a number instead of a string and test many solutions for the error messages.