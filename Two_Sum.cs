public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> pair = new  Dictionary <int,int>();
         int diff ;
        for (int i = 0 ; i < nums.Length ; i ++){
            pair[nums[i]] = i; 
        }
        for (int j = 0 ; j< nums.Length ; j++){
            diff = target - nums [j];
            if (pair.ContainsKey(diff)&& pair[diff]!=j ){
                return ([pair[diff] ,j]);
            }
        }
        return ([0]);
    }
}