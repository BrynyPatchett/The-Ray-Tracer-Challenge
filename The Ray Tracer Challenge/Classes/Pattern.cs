using System;

namespace The_Ray_Tracer_Challenge
{
    public abstract class Pattern{

    public Matrix Transform { get; set; }
    public Pattern (){
         Transform = new IdentityMatrix();
    }

  
    public abstract Tuple PatternAt(Tuple point);
    public Tuple PatternAtShape(Shape shape, Tuple worldPoint){
        Tuple objectPoint = shape.Transform.Inverse() * worldPoint;
        Tuple patternPoint = Transform.Inverse() * objectPoint;
        return PatternAt(patternPoint);

    }

    }
 
}
