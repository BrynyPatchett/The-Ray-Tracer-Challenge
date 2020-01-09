using System;


namespace The_Ray_Tracer_Challenge
{
    public class Ray
    {


        public Tuple Origin { get; set; }
        public Tuple Direction { get; set; }

        
      

        public Ray(Tuple origin, Tuple direction)
        {
            if(direction.w != 0 ){
                 Console.WriteLine("FAIL:direction is a point, should be a vector");
            }
            Origin = origin;    
            Direction = direction;
        }
        public Tuple Position(Tuple t){
            return Origin + Direction * t;
        }
        
        public static Tuple Position(Ray ray, Tuple t){
            return ray.Origin + ray.Direction * t ;
        }
        public static Ray Transform(Ray ray, Matrix m){

            return new Ray( m * ray.Origin,  m * ray.Direction);
           
        }
        public Ray Transform(Matrix m){
         return  new Ray( m * Origin,  m * Direction);
        }


    }
}
