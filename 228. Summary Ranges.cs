public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> list=new List<string>();
        if(nums.Length==0) return list;
        string StartingValue="*";
        int DigitCounter=0;
        for(int i=0;i<nums.Length;i++){
            if(StartingValue=="*"){
                StartingValue=Convert.ToString(nums[i]);
            }
            else if(nums[i]-nums[i-1]!=1){
                if(DigitCounter!=1) StartingValue+="->"+Convert.ToString(nums[i-1]);
                list.Add(StartingValue);
                StartingValue=Convert.ToString(nums[i]);
                DigitCounter=0;
            }
            DigitCounter++;
        }
        if(nums.Length>1&&nums[nums.Length-1]-nums[nums.Length-2]==1){
            StartingValue+="->"+Convert.ToString(nums[nums.Length-1]);
            list.Add(StartingValue);
        }
        else{
            list.Add(StartingValue);
        }
        return list;
    }
}