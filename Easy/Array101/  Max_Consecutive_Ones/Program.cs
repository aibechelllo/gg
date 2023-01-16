public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxValue = 0;

        int count = 0;

        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i] == 1){
                count++;
                maxValue = Math.Max(maxValue, count);
            }
            else{
                count = 0;
            }  
         }
         
         return maxValue;
    }
}