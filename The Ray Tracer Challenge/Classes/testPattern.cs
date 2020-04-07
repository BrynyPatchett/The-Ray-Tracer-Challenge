using System;

namespace The_Ray_Tracer_Challenge
{
    public class testPattern : Pattern{
 
    public testPattern(){

    }

    public override Tuple PatternAt(Tuple point){
        return new Tuple(point.x, point.y, point.z);
    }
    }
}
