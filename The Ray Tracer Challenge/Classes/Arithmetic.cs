using System;

namespace The_Ray_Tracer_Challenge
{
    static class Arithmetic
    {
         public const float EPSILON = 0.002f;
        ///<summary>
        ///Compares two floating point values for equality
        ///</summary>
        public static bool compareTwoFloats(float a, float b)
        {
           

            if (Math.Abs(a - b) < EPSILON)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
