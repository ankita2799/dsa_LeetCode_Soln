Two Sum II (Sorted Array) — C# Solution
?? Problem Overview

HERE:

The input array is sorted in non-decreasing order
You must find two numbers such that they add up to a given target
Return their 1-based indices
?? Approach: Two-Pointer Technique

Since the array is already sorted, we can avoid using extra space (like a hashmap) and instead use a two-pointer approach:

Steps:
Initialize two pointers:
left at the beginning of the array
right at the end of the array
Calculate the sum:
If numbers[left] + numbers[right] == target, return indices
If the sum is less than target ? move left forward
If the sum is greater than target ? move right backward
Continue until a match is found