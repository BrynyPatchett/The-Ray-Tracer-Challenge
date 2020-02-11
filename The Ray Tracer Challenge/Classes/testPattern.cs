using System;

namespace The_Ray_Tracer_Challenge
{
    public class testPattern : Pattern{
    Tuple A{ get; set; }
    Tuple B{ get; set; }

     public testPattern(Tuple ColourA, Tuple ColourB){
        A = ColourA;
        B = ColourB;
      

    }

    
    public override Tuple PatternAt(Tuple point){
        if(MathF.Floor(point.x) % 2 == 0){
            return A;
        }
        else{
            return B;
        }
    }
    }
 
}
