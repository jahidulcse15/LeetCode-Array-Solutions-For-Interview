public class Solution {
    public int Candy(int[] ratings) {
        int length=ratings.Length,TotalCandy=0;
        int[] candy=new int[length];
        for(int i=0;i<length;i++){
            candy[i]=1;
        }
        for(int i=1;i<length;i++){
            if(ratings[i]>ratings[i-1]){
                candy[i]=Math.Max(candy[i],candy[i-1]+1);
            }
        }
        for(int i=length-2;i>=0;i--){
            if(ratings[i]>ratings[i+1]){
                candy[i]=Math.Max(candy[i],candy[i+1]+1);
            }
        }
        foreach(var item in candy){
            TotalCandy+=item;
        }
        return TotalCandy;
    }
}