public class Solution { 
    public bool IsValidPalindrome (string s) {
        if (string.IsNullOrEmpty(s))
            return true;
        ReadOnlySpan<char> palindrome = s.AsSpan();
        int left = 0;
        int right = palindrome.Length-1;



        while (left < right) {
            while (left < right  && !char.IsLetterOrDigit(palindrome[left])) left++;
            while (left < right  && !char.IsLetterOrDigit(palindrome[right])) right--;
            if (char.ToLowerInvariant(palindrome[left]) != char.ToLowerInvariant(palindrome[right])) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}