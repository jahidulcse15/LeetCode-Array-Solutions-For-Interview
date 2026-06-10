public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
        int hIndex=0;
        for(int i=0;i<citations.Length;i++){
            if(citations[i]>hIndex){
                hIndex++;
            }
        }
        return hIndex;
    }
}