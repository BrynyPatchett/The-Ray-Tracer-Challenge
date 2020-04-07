using System;


namespace The_Ray_Tracer_Challenge
{
    public class Sphere : Shape
    {


        public override Intersection[] LocalIntersect(Ray localRay){


            Tuple sphereToRay = localRay.Origin - new Tuple(0,0,0,1);
            float a = localRay.Direction.Dot(localRay.Direction);
            float b = 2 * localRay.Direction.Dot(sphereToRay);
            float c = sphereToRay.Dot(sphereToRay) - 1;

            float discriminant = (b * b) - 4 * a * c; 

            if(discriminant < 0){
                Intersection[] empty = new Intersection[0];
                return empty;
            }

            

            Intersection i1 = new Intersection ((-b - MathF.Sqrt(discriminant)) / (2 * a),this);
            Intersection i2 = new Intersection ((-b + MathF.Sqrt(discriminant)) / (2 * a),this);
            return Intersect.Intersections(i1,i2);
        }

        public override Tuple LocalNormalAt(Tuple localPoint) {
            return localPoint - new Tuple(0,0,0,1);

        }



        public static Sphere GlassSphere(){
            Sphere S = new Sphere();
            S.Material.Transparency = 1.0f;
            S.Material.Refractive_index = 1.5f;
            return S;
        }
    }
}
