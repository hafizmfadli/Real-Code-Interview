## Real Code Interview

This repository contains real coding question from interviews with companies I have interviewed with.

### Tiket.com Interview ( Software engineer II - Accomodation )

Problem statement : Given a sorted array, find the target value. Return the element if the target is found. If the target is not in the array, return the greatest element less than the target. Return -1 if an error occurs.

Example:

arr = [2, 4, 6, 8]

target = 4; f(arr, target) = 4

target = 100; f(arr, target) = 8

target = 1; f(arr, 1) = -1


Solution 1 (naive approach)

using for loop. Time complexity: O(n)

Solution 2 (optimization) : 

using binary search. Time complexity: O(log n)