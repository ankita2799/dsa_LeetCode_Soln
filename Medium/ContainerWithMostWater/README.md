?? Container With Most Water

This project implements an efficient solution to the classic “Container With Most Water” problem using the two-pointer technique.

?? Problem Statement

Given an array of integers heights, where each element represents the height of a vertical line on the x-axis, find two lines that together with the x-axis form a container that holds the maximum amount of water.

?? Approach

We use a two-pointer strategy:

Start with:
left at the beginning
right at the end
Calculate the area between them
Move the pointer pointing to the shorter line
Repeat until pointers meet
Why this works:

The area is limited by the shorter height:

area = width × min(height[left], height[right])

So we try to improve the limiting height while reducing width.