using System;
using System.Collections.Generic;

int[] nums1 = { 1, 2, 3, 3 };
int[] nums2 = { 1, 2, 3, 4 };

var solution = new Solution();
Console.WriteLine($"[1, 2, 3, 3] → {solution.hasDuplicate(nums1)}");
Console.WriteLine($"[1, 2, 3, 4] → {solution.hasDuplicate(nums2)}");
