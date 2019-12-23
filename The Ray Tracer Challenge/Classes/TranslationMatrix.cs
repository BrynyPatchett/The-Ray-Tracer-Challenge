using System;

namespace The_Ray_Tracer_Challenge
{
    public class TranslationMatrix : Matrix
    {

        public TranslationMatrix(float x, float y, float z)
        {
            floatMatrix = new float[4, 4];
            RowNumber = 4;
            ColNumber = 4;

            for (int r = 0; r < RowNumber; r++)
            {
                for (int c = 0; c < ColNumber; c++)
                {
                    if (r == c)
                    {
                        floatMatrix[r, c] = 1;
                    }
                }
            }
            floatMatrix[0, 3] = x;
            floatMatrix[1, 3] = y;
            floatMatrix[2, 3] = z;



        }



    }
}
