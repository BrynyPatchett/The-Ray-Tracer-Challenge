﻿

namespace The_Ray_Tracer_Challenge
{
    public class Precomputation
    {


        public float T_Value{get;set;}
        public Tuple T_Value_Tuple{get;set;}
        public Sphere Object{get;set;}       

        public Tuple Point{get;set;}

        public Tuple EyeVector{get;set;}

        public Tuple NormalVector{get;set;}

        public bool Inside{get;set;}

        public Precomputation()
        {
            
        }

    }
}
