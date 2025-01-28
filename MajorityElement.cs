using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWannaStareAtTheMoonForever
{// [4,3,5,7,3,4,3,3]
    private int Democracy(int[] nums)
    {
        Dictionary<int, int> LaylaBook = new();

        LaylaBook.Add(nums[0], 0);

        for (int i = 1; i < nums.Count(); i++)
        {
            if (LaylaBook.ContainsKey(nums[i]))
            {
                LaylaBook[nums[i]]++;
            }
            else
            {
                LaylaBook.Add(nums[i], 0);
            }
        }
    }
}