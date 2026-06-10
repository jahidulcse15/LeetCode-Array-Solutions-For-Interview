public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int r1=0,r2=matrix.Length-1,c1=0,c2=matrix[0].Length-1;
        IList<int> list=new List<int>();
        while(r1<=r2&&c1<=c2){
            for(int i=c1;i<=c2;i++){
                list.Add(matrix[r1][i]);
            }
            r1++;
            if(r2<r1) break;
            for(int i=r1;i<=r2;i++){
                list.Add(matrix[i][c2]);
            }
            c2--;
            if(c2<c1) break;
            for(int i=c2;i>=c1;i--){
                list.Add(matrix[r2][i]);
            }
            r2--;
            if(r2<r1) break;
            for(int i=r2;i>=r1;i--){
                list.Add(matrix[i][c1]);
            }
            c1++;
        }
        return list;
    }
}