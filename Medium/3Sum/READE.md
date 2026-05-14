Problem Statement

Given an integer array nums, return all the unique triplets [a, b, c] such that:

a + b + c == 0

The solution set must not contain duplicate triplets.
1. Sort the Array

Sorting helps in:

Using the two-pointer technique
Skipping duplicate values easily

Example:

[-4, -1, -1, 0, 1, 2]

2. Fix One Element

Loop through the array and treat each element as the first number of the triplet.

For every nums[i], find two numbers whose sum equals:

-target = nums[i]

3. Use Two Pointers

Initialize:

left = i + 1
right = nums.Length - 1

Calculate:

sum = nums[i] + nums[left] + nums[right]

Cases
If sum == 0
Store the triplet
If sum < 0
Move left pointer forward
If sum > 0
Move right pointer backward
4. Skip Duplicates

To avoid duplicate triplets:

Skip duplicate values for i
Skip duplicate values for left
Skip duplicate values for right
Time Complexity

O(n²)

Sorting takes O(n log n)
Two-pointer traversal takes O(n²)

Overall complexity: O(n²)

Space Complexity

O(1)

Ignoring the output list.
