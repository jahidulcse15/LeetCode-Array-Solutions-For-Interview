public class Solution {
    public int[][] FlipAndInvertImage(int[][] matrix) {
        for(int i=0;i<matrix.Length;i++){
            int l=0,r=matrix[0].Length-1;
            while(l<r){
                 int a=matrix[i][l];
                 int b=matrix[i][r];
                 int c=a;
                 matrix[i][l]=b;
                 matrix[i][r]=c;
                l++;r--;
            }
        }
        for(int i=0;i<matrix.Length;i++){
            for(int j=0;j<matrix.Length;j++){
                matrix[i][j]=matrix[i][j]==1?0:1;
            }
        }
        return matrix;
    }
}