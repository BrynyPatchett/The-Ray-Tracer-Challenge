using System;

namespace The_Ray_Tracer_Challenge
{
    public class RingPattern : Pattern{
    Tuple A{ get; set; }
    Tuple B{ get; set; }

     public RingPattern(Tuple ColourA, Tuple ColourB){
        A = ColourA;
        B = ColourB;
      

    }

    
    public override Tuple PatternAt(Tuple point){
        if(MathF.Floor(MathF.Sqrt((point.x * point.x) + (point.z * point.z))) % 2 == 0){
            return A;
        }
        else{
            return B;
        }
    }
    }
 
}
