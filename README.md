# Specification

1. user inputs a word
2. user inputs one or several words
3. program tells user if any words are anagrams of first words
 ex "bread" anagram of "beard"

optional
4. program tells user if any words are a partial match
    ex "hat" partial match to "path"


    split user input into character array
    "bread" becomes 'b' 'r' 'e' 'a' 'd'
    "beard" becomes 'b' 'e' 'a' 'r' 'd'

    Array.Sort() method for both input arrays
    'b' 'r' 'e' 'a' 'd' becomes 'a' 'b' 'd' 'e' 'r'
    'b' 'e' 'a' 'r' 'd' becomes 'a' 'b' 'd' 'e' 'r'

    compare sorted arrays and if they are same, they are anagram
