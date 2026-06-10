public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool leftColumn=false,topRow=false,bottomRow=false,rightColumn=false;
        for(int i=0;i<matrix[0].Length;i++){
            if(matrix[0][i]==0){
                topRow=true;
            }
        }
        for(int i=0;i<matrix[0].Length;i++){
            if(matrix[matrix.Length-1][i]==0){
                bottomRow=true;
            }
        }
        for(int i=0;i<matrix.Length;i++){
            if(matrix[i][0]==0){
                leftColumn=true;
            }
        }
        for(int i=0;i<matrix.Length;i++){
            if(matrix[i][matrix[0].Length-1]==0){
                rightColumn=true;
            }
        }

        for(int i=1;i<matrix.Length;i++){
            for(int j=1;j<matrix[0].Length;j++){
                if(matrix[i][j]==0){
                    matrix[0][j]=0;
                    matrix[i][0]=0;
                }
            }
        }
        for(int i=1;i<matrix.Length;i++){
            if(matrix[i][0]==0){
                for(int j=0;j<matrix[i].Length;j++){
                    matrix[i][j]=0;
                }
            }
        }
        for(int i=1;i<matrix[0].Length;i++){
            if(matrix[0][i]==0){
                for(int j=0;j<matrix.Length;j++){
                    matrix[j][i]=0;
                }
            }
        }
        if(topRow==true){
            for(int i=0;i<matrix[0].Length;i++){
                matrix[0][i]=0;
            }
        }
        if(bottomRow==true){
            for(int i=0;i<matrix[0].Length;i++){
                matrix[matrix.Length-1][i]=0;
            }
        }
        if(leftColumn==true){
            for(int i=0;i<matrix.Length;i++){
                matrix[i][0]=0;
            }
        }
        if(rightColumn==true){
            for(int i=0;i<matrix.Length;i++){
                matrix[i][matrix[0].Length-1]=0;
            }
        }
    }
}