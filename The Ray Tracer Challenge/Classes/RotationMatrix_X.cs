using System;

namespace The_Ray_Tracer_Challenge
{
    public class RotationMatrix_X : Matrix
    {

        public RotationMatrix_X(float angle)
        {
            floatMatrix = new float[4, 4];
            RowNumber = 4;
            ColNumber = 4;

           
            floatMatrix[0, 0] = 1;

            floatMatrix[1, 1] = MathF.Cos(angle);
            floatMatrix[1, 2] = -(MathF.Sin(angle));

            floatMatrix[2, 1] = MathF.Sin(angle);
            floatMatrix[2, 2] = MathF.Cos(angle);

            floatMatrix[3, 3] = 1;


        }



    }
}
