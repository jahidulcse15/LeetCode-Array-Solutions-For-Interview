public class Solution {
    public int MajorityElement(int[] nums) {
        int MajorityElement=nums[0];
        int CountElement=1;
        for(int i=1;i<nums.Length;i++){
            if(MajorityElement==nums[i]){
                CountElement++;
            }
            else{
                CountElement--;
                if(CountElement<=0){
                    CountElement=1;
                    MajorityElement=nums[i];
                }
            }
        }
        return MajorityElement;
    }
}