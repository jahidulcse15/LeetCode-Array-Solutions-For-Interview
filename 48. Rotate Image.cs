public class Solution {
     private void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public void Rotate(int[][] matrix) {
        for(int i=0;i<matrix.Length;i++){
            for(int j=0;j<matrix[0].Length;j++){
                if(j>i){
                    swap(ref matrix[i][j],ref matrix[j][i]);
                }
            }
        }
        for(int i=0;i<matrix.Length;i++){
            int l=0,r=matrix.Length-1;
            while(l<r){
                swap(ref matrix[i][l],ref matrix[i][r]);
                l++;r--;
            }
        }
    }
}