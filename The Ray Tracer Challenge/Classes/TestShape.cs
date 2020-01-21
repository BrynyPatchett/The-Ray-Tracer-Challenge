using System;


namespace The_Ray_Tracer_Challenge
{
    public class TestShape : Shape
    {


        public static long GlobalId = 0;
        public long Id { get; set; }

        public Matrix Transform { get; set; }

        public Material Material { get; set; }
      

        public TestShape()
        {
           
        }

        public override Intersection[] LocalIntersect(Ray localRay){
            LocalRay = localRay;

            
            return null;
        }

        public override Tuple LocalNormalAt(Tuple localPoint) {
            return new Tuple(localPoint.x,localPoint.y,localPoint.z,0);




        }
   
     


    }
}
