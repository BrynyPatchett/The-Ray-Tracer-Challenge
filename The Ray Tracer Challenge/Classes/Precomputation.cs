

namespace The_Ray_Tracer_Challenge
{
    public class Precomputation
    {


        public float T_Value{get;set;}
        public Tuple T_Value_Tuple{get;set;}
        public Shape Object{get;set;}       

        public Tuple Point{get;set;}

        public Tuple EyeVector{get;set;}

        public Tuple NormalVector{get;set;}

        public bool Inside{get;set;}

        public Tuple OverPoint{get;set;}

         public Tuple ReflectVector{get;set;}

         public float n1{get;set;}

         public float n2{get;set;}

         public Tuple UnderPoint{get;set;}

        public Precomputation()
        {
            
        }

    }
}
