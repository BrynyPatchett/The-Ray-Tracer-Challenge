using System;

namespace The_Ray_Tracer_Challenge
{
    public class RotationMatrix_Z : Matrix
    {

        public RotationMatrix_Z(float angle)
        {
            floatMatrix = new float[4, 4];
            RowNumber = 4;
            ColNumber = 4;

           
            floatMatrix[0, 0] = MathF.Cos(angle);
            floatMatrix[0, 1] = -MathF.Sin(angle);

            floatMatrix[1, 0] = MathF.Sin(angle);
            floatMatrix[1, 1] =  MathF.Cos(angle);
            
            floatMatrix[2, 2] = 1;
            floatMatrix[3, 3] = 1;


        }



    }
}
