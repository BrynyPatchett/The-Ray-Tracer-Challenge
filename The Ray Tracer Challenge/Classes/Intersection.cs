using System;


namespace The_Ray_Tracer_Challenge
{
    //Intersection class is used to represent an intersection in the scene, 
    //currently this is a sphere object, it has an t value for location and object for what object is intersected.
    public class Intersection
    {

        public float T_Value{get;set;}
        public Tuple T_Value_Tuple{get;set;}
        public Shape Object{get;set;}
       
        public Intersection(float t , Shape obj){
            T_Value = t;
            T_Value_Tuple = new Tuple(t,1);
            Object = obj;

        }
     

    }
}
