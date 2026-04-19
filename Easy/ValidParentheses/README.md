# Valid Parentheses

## ?? Problem Statement
Given a string `s` containing just the characters `(`, `)`, `{`, `}`, `[` and `]`, determine if the input string is valid.

A string is valid if:
- Every opening bracket has a matching closing bracket
- Brackets are closed in the correct order
- Brackets are properly nested

---

## ?? Approach
We use a **Stack (LIFO - Last In First Out)** to track opening brackets.

### Idea:
- Push opening brackets onto the stack
- When a closing bracket appears:
  - Check if it matches the top of the stack
  - If yes ? pop it
  - If no ? string is invalid
- At the end, stack must be empty for a valid string

---

## ?? Example

### Input:
s = "{[()]}"
Push '{' ? stack: {
Push '[' ? stack: {[
Push '(' ? stack: {[(
')' matches '(' ? pop ? stack: {[
']' matches '[' ? pop ? stack: {
'}' matches '{' ? pop ? stack: empty


### Output:
-true


---

## ? Invalid Example

### Input:
-s = "([)]"

### Why invalid?
- '(' expects ')'
- But ')' is not in correct order (wrong nesting)

### Output:
-false

---

## ? Complexity
- Time Complexity: **O(n)** (single pass through string)
- Space Complexity: **O(n)** (stack storage)

---

## ?? Key Learnings
- Stack is ideal for matching pairs
- Order matters, not just count
- Useful pattern for parsing and validation problems