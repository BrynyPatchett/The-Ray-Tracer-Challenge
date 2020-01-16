using System;


namespace The_Ray_Tracer_Challenge
{
    //Intersect class contains methods that deal with returning intesections
    public static class Intersect
    {


       
        public static Intersection[] SphereIntersection(Sphere s, Ray r){

            
            //Calculating the discriminant
            //- new Tuple, is treating sphere as centered at world origin
            Ray transformedRay = r.Transform(s.Transform.Inverse());

            Tuple sphereToRay = transformedRay.Origin - new Tuple(0,0,0,1);
            float a = transformedRay.Direction.Dot(transformedRay.Direction);
            float b = 2 * transformedRay.Direction.Dot(sphereToRay);
            float c = sphereToRay.Dot(sphereToRay) - 1;

            float discriminant = (b * b) - 4 * a * c; 

            if(discriminant < 0){
                Intersection[] empty = new Intersection[0];
                return empty;
            }

            

            Intersection i1 = new Intersection ((-b - MathF.Sqrt(discriminant)) / (2 * a),s);
            Intersection i2 = new Intersection ((-b + MathF.Sqrt(discriminant)) / (2 * a),s);
            return Intersections(i1,i2);






        
        }//params alllows unlimited number of arguments of given type, turns given params into an array
            public static Intersection[] Intersections(params Intersection[] i){
                Intersection[] arrayOfIntersections = new Intersection[i.Length];
                for(int j = 0; j < i.Length; j++){
                    arrayOfIntersections[j] = i[j];
                }

             
            return arrayOfIntersections;




        }

        public static Intersection Hit(Intersection[] intersections){

           if(intersections.Length == 0){
               return null;
           }
            Intersection lowestFound = null; 

            for(int i = 0; i < intersections.Length; i ++){
                float val = intersections[i].T_Value;
                if(lowestFound == null && val > 0){
                    lowestFound = intersections[i];

                } else if (lowestFound != null){
                        if(val < lowestFound.T_Value && val > 0){
                        lowestFound = intersections[i];
                    }
                }  
            }
            if(lowestFound == null){
                return null;
            }
            if(lowestFound.T_Value < 0){
                return null;
            }
             return lowestFound;
            
        }
        public static Intersection[] SortIntersections(Intersection[] array){

           
           Array.Sort(array,(i1,i2) => (int)i1.T_Value.CompareTo(i2.T_Value));

            return array;
        }
     
        public static Precomputation PrepareComputations(Intersection i,  Ray ray){

            Precomputation comp = new Precomputation();
            comp.T_Value = i.T_Value;
            comp.T_Value_Tuple = i.T_Value_Tuple;
            comp.Object = i.Object;
            comp.Point = ray.Position(comp.T_Value_Tuple);
            comp.EyeVector = -ray.Direction;


            comp.NormalVector = comp.Object.NormalAt(comp.Point);
            if(comp.NormalVector.Dot(comp.EyeVector) < 0){
                comp.Inside = true;
                comp.NormalVector = -comp.NormalVector;
            }else{
                comp.Inside = false;
            }
            comp.OverPoint = comp.Point + (comp.NormalVector * Arithmetic.EPSILON);
            return comp;
          
        }

    }
}
