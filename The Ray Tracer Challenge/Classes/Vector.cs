using System;

namespace The_Ray_Tracer_Challenge
{
    public class ThreeVector
    {
       
        public float x {get; set;}
        public float y {get; set;}
        public float z {get; set;}

        public ThreeVector(){}
        
        public ThreeVector(float X, float Y,float Z)
        {
                x = X;
                y = Y;   
                z = Z;
        }
        public float Magnitude ()
        {
            float mag = MathF.Sqrt((x * x) + (y * y) + (z * z));
            return mag;
        }
          public void Normalise ()
        {
            float mag = Magnitude();
            x = (x / mag);
            y = (y / mag);
            z = (z / mag);
            
        }





    }
}
