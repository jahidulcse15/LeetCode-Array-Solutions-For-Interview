public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var TotalGas=0;
        var TotalCost=0;
        for(int i=0;i<gas.Length;i++){
            TotalGas+=gas[i];
            TotalCost+=cost[i];
        }
        if(TotalGas<TotalCost) return -1;
        int index=0;
        TotalGas=0;
        for(int i=0;i<gas.Length;i++){
            TotalGas+=gas[i]-cost[i];
            if(TotalGas<0){
                TotalGas=0;
                 index=i+1;
            }
        }
        return index;
    }
}