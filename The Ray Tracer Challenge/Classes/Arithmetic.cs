using System;

namespace The_Ray_Tracer_Challenge
{
    static class Arithmetic
    {
        ///<summary>
        ///Compares two floating point values for equality
        ///</summary>
        public static bool compareTwoFloats(float a, float b)
        {
            const float EPSILON = 0.00001f;

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
