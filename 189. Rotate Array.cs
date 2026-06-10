public class Solution {
    public void Rotate(int[] nums, int k) {
        int sz=nums.Length;
        k%=sz;
        int l=0,r=sz-1;
        while(l<r){
            int a=nums[l];
            int b=nums[r];
            nums[l]=nums[r];
            nums[r]=a;
            l++;r--;
        }
        l=0;r=k-1;
        while(l<r){
            int a=nums[l];
            int b=nums[r];
            nums[l]=nums[r];
            nums[r]=a;
            l++;r--;
        }
        l=k;r=sz-1;
        while(l<r){
            int a=nums[l];
            int b=nums[r];
            nums[l]=nums[r];
            nums[r]=a;
            l++;r--;
        }
    }
}