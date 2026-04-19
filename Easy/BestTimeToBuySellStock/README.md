# Best Time to Buy and Sell Stock (Max Profit)

## Problem Statement

You are given an array `nums` where `nums[i]` represents the price of a stock on day `i`.

You are allowed to complete **at most one transaction** (buy one and sell one share of the stock).

Return the maximum profit you can achieve. If no profit is possible, return `0`.

---

## Approach

This solution uses a **greedy algorithm** to track:

- The **minimum price** seen so far (best day to buy)
- The **maximum profit** possible at each step

### Idea

For each price:
1. Update the minimum price if a lower value is found.
2. Calculate profit if selling at the current price.
3. Keep track of the maximum profit.

---

## Algorithm

1. Initialize:
   - `minValue = +?`
   - `profit = 0`

2. Loop through the array:
   - If current price < `minValue`, update `minValue`
   - Otherwise, calculate `currentProfit = price - minValue`
   - Update `profit` if `currentProfit` is higher

3. Return `profit`

---

## Complexity Analysis

- **Time Complexity:** `O(n)`  
  Single pass through the array.

- **Space Complexity:** `O(1)`  
  Uses only constant extra variables.

---