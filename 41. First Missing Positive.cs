public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Dictionary<int,int> cnt=new Dictionary<int,int>();
        foreach(var item in nums){
            if(!cnt.ContainsKey(item)){
                cnt[item]=0;
            }
            cnt[item]++;
        }
        for(int i=1;i<=1000001;i++){
            if(!cnt.ContainsKey(i)){
                return i;
            }
        }
        return -1;
    }
}