using System;


namespace The_Ray_Tracer_Challenge
{
    public abstract class Shape
    {


        public static long GlobalId = 0;
        public long Id { get; set; }

        public Matrix Transform { get; set; }

        public Material Material { get; set; }

        public Ray LocalRay { get; set; }
      

        public Shape()
        {
           setGlobalId(this);
           Transform = new IdentityMatrix();
           Material = new Material();
          
        }
        public static void setGlobalId(Shape s){
            s.Id = GlobalId++;
        }

        
        public abstract Intersection[] LocalIntersect(Ray localRay);
        public abstract Tuple LocalNormalAt(Tuple localPoint);
        public static Tuple NormalAt(Shape s,Tuple worldPoint) {
            Matrix inverse = s.Transform.Inverse();

            Tuple localPoint = inverse * worldPoint;
            Tuple localNormal = s.LocalNormalAt(localPoint);
            Tuple worldNormal = inverse.Transpose() * localNormal;
            worldNormal.w = 0;
            return(worldNormal.Normalise());
        }
     


    }
}
