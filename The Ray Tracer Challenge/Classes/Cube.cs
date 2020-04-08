using System;


namespace The_Ray_Tracer_Challenge
{
    public class Cube : Shape
    {

        public Cube()
        {
           
        }

        public override Intersection[] LocalIntersect(Ray localRay){
         
            float [] xtMinMax = CheckAxis(localRay.Origin.x,localRay.Direction.x);
            float [] ytMinMax = CheckAxis(localRay.Origin.y,localRay.Direction.y);
            float [] ztMinMax = CheckAxis(localRay.Origin.z,localRay.Direction.z);
            //new float [2];

            float tmin = MathF.Max(xtMinMax[0],MathF.Max(ytMinMax[0],ztMinMax[0]));
            float tmax =  MathF.Min(xtMinMax[1],MathF.Min(ytMinMax[1],ztMinMax[1]));

            if(tmin > tmax){
                 return new Intersection[0];
            }

            return new Intersection[] {new Intersection(tmin, this), new Intersection(tmax, this)};

        }

        public override Tuple LocalNormalAt(Tuple localPoint) {

            float maxC =  MathF.Max(MathF.Abs(localPoint.x),MathF.Max(MathF.Abs(localPoint.y),MathF.Abs(localPoint.z)));

            if(maxC == MathF.Abs(localPoint.x)){

                return new Tuple(localPoint.x,0,0,0);

            }else if(maxC == MathF.Abs(localPoint.y)){

                return new Tuple(0,localPoint.y,0,0);

            }else{
                return new Tuple(0,0,localPoint.z,0);
            }
            
        }

        public static float [] CheckAxis(float origin, float direction){
            float tmin, tmax;

            float tmin_numerator = (-1 - origin);
            float tmax_numerator = (1 - origin);
            

            if(MathF.Abs(direction) >= Arithmetic.EPSILON){
                tmin = tmin_numerator / direction;
                tmax = tmax_numerator / direction;
            }else{
                tmin = tmin_numerator * float.PositiveInfinity;
                tmax = tmax_numerator * float.PositiveInfinity;
            }
            if(tmin > tmax){
                return new float[] {tmax,tmin};
            }else{
                return new float[] {tmin,tmax};
            }
        }

    }
}
