using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        if (s.Length % 2 !=0)
        {
            return false;
        }
        Stack<char> newStack = new Stack<char> ();
        foreach (char c in s) {
            switch (c) { 
                case '(':
                case '{':
                case '[':
                    newStack.Push (c); break;
                case ')':
                    if (newStack.Count == 0 || newStack.Pop()!='(') { return false; }
                    break;
                case '}':
                    if (newStack.Count == 0 || newStack.Pop() != '{') { return false; }
                    break;
                case ']':
                    if (newStack.Count == 0 || newStack.Pop() != '[') { return false; }
                    break;
            }
        }
        return newStack.Count == 0;
    }
}