using System;

namespace The_Ray_Tracer_Challenge
{
    public class ShearingMatrix: Matrix
    {

        public ShearingMatrix(float xy,float xz, float yx, float yz, float zx, float zy)
        {
            floatMatrix = new float[4, 4];
            RowNumber = 4;
            ColNumber = 4;

            floatMatrix[0, 0] = 1;
            floatMatrix[1, 1] = 1;
            floatMatrix[2, 2] = 1;
            floatMatrix[3, 3] = 1;

            floatMatrix[0, 1] = xy;
            floatMatrix[0, 2] = xz;

            floatMatrix[1, 0] = yx;
            floatMatrix[1, 2] = yz;

            floatMatrix[2, 0] = zx;
            floatMatrix[2, 1] = zy;



           
            

            


        }



    }
}
