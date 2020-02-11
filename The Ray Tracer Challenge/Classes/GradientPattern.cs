using System;

namespace The_Ray_Tracer_Challenge
{
    public class GradientPattern : Pattern{
    Tuple A{ get; set; }
    Tuple B{ get; set; }

     public GradientPattern(Tuple ColourA, Tuple ColourB){
        A = ColourA;
        B = ColourB;
      

    }

    
    public override Tuple PatternAt(Tuple point){
        Tuple Distance = B-A;
        float fraction = point.x - MathF.Floor(point.x);
        return A + (Distance * fraction);

    }
    }
 
}
