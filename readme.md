# Notes

## Implementation
I chose to loop through the characters from right to left. For each digit, I multiply it by 8^(number of digits) and add the result to a running total.

## Testing
I wrote test cases that represent a standard use case, the smallest allowed value, the largest allowed value, a parse error,
and an overflow error. 

## Error Handling
I used exceptions to implement error handling. The function throws and exception if the input is not a valid octal string. 
It also throws an overflow exception if the input octal string represents a number that is too large to fit in a uint.