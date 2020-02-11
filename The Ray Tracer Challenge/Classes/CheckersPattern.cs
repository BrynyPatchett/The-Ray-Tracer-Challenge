using System;

namespace The_Ray_Tracer_Challenge
{
    public class CheckersPattern : Pattern{
    Tuple A{ get; set; }
    Tuple B{ get; set; }

     public CheckersPattern(Tuple ColourA, Tuple ColourB){
        A = ColourA;
        B = ColourB;
      

    }

    
    public override Tuple PatternAt(Tuple point){
        if((MathF.Floor(point.x) + MathF.Floor(point.y) + MathF.Floor(point.z)) % 2 == 0)
        {
            return A;
        }
        else{
            return B;
        }
    }
    }
 
}
