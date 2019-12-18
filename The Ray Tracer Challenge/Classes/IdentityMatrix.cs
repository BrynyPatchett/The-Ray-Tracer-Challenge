using System;

namespace The_Ray_Tracer_Challenge
{
    public class IdentityMatrix : Matrix
    {

        public IdentityMatrix() {
               floatMatrix = new float[4,4];
            RowNumber = 4;
            ColNumber = 4;
            floatMatrix[0,0] = 1;
            floatMatrix[1,1] = 1;
            floatMatrix[2,2] = 1;
            floatMatrix[3,3] = 1;


         }

        public IdentityMatrix(int rowNumber, int colNumber)
        {
            floatMatrix = new float[rowNumber,colNumber];
            RowNumber = rowNumber;
            ColNumber = colNumber;

            for(int r = 0; r < RowNumber; r++){
                for(int c = 0; c < ColNumber; c++){
                    if(r == c){
                        floatMatrix[r,c] = 1;
                    }
                } 
            }
            
        }
        

    }
}
