using System;

namespace The_Ray_Tracer_Challenge
{
    public class ScaleMatrix : Matrix
    {

        public ScaleMatrix(float x, float y, float z)
        {
            floatMatrix = new float[4, 4];
            RowNumber = 4;
            ColNumber = 4;

           
            floatMatrix[0, 0] = x;
            floatMatrix[1, 1] = y;
            floatMatrix[2, 2] = z;
            floatMatrix[3, 3] = 1;


        }



    }
}
