using System;


namespace The_Ray_Tracer_Challenge
{
    public class Sphere
    {


        public static long GlobalId = 0;
        public long Id { get; set; }

        public Matrix Transform { get; set; }

        public Material Material { get; set; }
      

        public Sphere()
        {
           setGlobalId(this);
           Transform = new IdentityMatrix();
           Material = new Material();
        }
        public static void setGlobalId(Sphere s){
            s.Id = GlobalId++;
        }

        public Tuple NormalAt(Tuple worldPoint) {
            Matrix inverse = Transform.Inverse();
            Tuple objectPoint = inverse * worldPoint;
            Tuple objectNormal = objectPoint - new Tuple(0,0,0,1);
            Tuple worldNormal = inverse.Transpose() * objectNormal;
            worldNormal.w = 0;
            return(worldNormal.Normalise());




        }
        public static Tuple NormalAt(Sphere s,Tuple worldPoint) {
            Matrix inverse = s.Transform.Inverse();
            Tuple objectPoint = inverse * worldPoint;
            Tuple objectNormal = objectPoint - new Tuple(0,0,0,1);
            Tuple worldNormal = inverse.Transpose() * objectNormal;
            worldNormal.w = 0;
            return(worldNormal.Normalise());
        }
     


    }
}
