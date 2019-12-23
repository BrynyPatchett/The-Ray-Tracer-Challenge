using System;

namespace The_Ray_Tracer_Challenge
{
    public class RotationMatrix_Y : Matrix
    {

        public RotationMatrix_Y(float angle)
        {
            floatMatrix = new float[4, 4];
            RowNumber = 4;
            ColNumber = 4;

           
            floatMatrix[0, 0] = MathF.Cos(angle);
            floatMatrix[0, 2] = MathF.Sin(angle);

            floatMatrix[1, 1] = 1;
        

            floatMatrix[2, 0] = -MathF.Sin(angle);
            floatMatrix[2, 2] = MathF.Cos(angle);
        
            floatMatrix[3, 3] = 1;


        }



    }
}
