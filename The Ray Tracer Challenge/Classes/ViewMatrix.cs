using System;

namespace The_Ray_Tracer_Challenge
{
    public class ViewMatrix : Matrix
    {

        
        public ViewMatrix(Tuple from, Tuple to, Tuple up)
        {


            floatMatrix = new float[4, 4]; 
            RowNumber = 4;
            ColNumber = 4;

            Tuple forward = (to - from).Normalise();
            Tuple upn = up.Normalise();
            Tuple left = Tuple.Cross(forward,upn);
            Tuple trueUp = Tuple.Cross(left,forward);
         
        

            floatMatrix[0, 0] = left.x;
            floatMatrix[0, 1] = left.y;
            floatMatrix[0, 2] = left.z;


            floatMatrix[1, 0] = trueUp.x;
            floatMatrix[1, 1] = trueUp.y;
            floatMatrix[1, 2] = trueUp.z;

            floatMatrix[2, 0] = -forward.x;
            floatMatrix[2, 1] = -forward.y;
            floatMatrix[2, 2] = -forward.z;

            floatMatrix[3, 3] = 1;
            

            TranslationMatrix move =  new TranslationMatrix(-from.x, -from.y,-from.z);   
            this.floatMatrix = (this * move).floatMatrix; 
            
         
        }

    }
}
