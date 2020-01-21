using System;


namespace The_Ray_Tracer_Challenge
{
    public class Plane : Shape
    {


    
      

        public Plane()
        {
           
        }

        public override Intersection[] LocalIntersect(Ray localRay){
            LocalRay = localRay;

            if(MathF.Abs(LocalRay.Direction.y) < Arithmetic.EPSILON){
                return  new Intersection[0];
                
            }
            else{
                float t = -localRay.Origin.y / localRay.Direction.y;
                 Intersection i1 = new Intersection (t,this);
                return Intersect.Intersections(i1);
            }

            
            
        }

        public override Tuple LocalNormalAt(Tuple localPoint) {
            return new Tuple(0,1,0,0);




        }
   
     


    }
}
