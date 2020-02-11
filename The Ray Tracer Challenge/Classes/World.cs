using System.Collections.Generic;

namespace The_Ray_Tracer_Challenge
{
    public class World
    {
        //Refactor this into objects array once objects superclass is implemented
        public Shape [] SceneObjects{get;set;}
        public PointLight SceneLight{get;set;}

        public int ReflectionDepth {get;set;}

        
        /*Default world constructor*/
        public World(int reflectionDepth = 5){
            SceneObjects = new Sphere[2];
            SceneObjects[0] = new Sphere();
            SceneObjects[0].Material.Colour = new Tuple(0.8f,1.0f,0.6f,0);
            SceneObjects[0].Material.Diffuse = 0.7f;
            SceneObjects[0].Material.Specular = 0.3f;
            SceneObjects[1] = new Sphere();
            SceneObjects[1].Transform = new ScaleMatrix(0.5f,0.5f,0.5f);
            SceneLight = new PointLight(new Tuple(-10,10,-10,1),new Tuple(1,1,1,0));
            ReflectionDepth = reflectionDepth;

        }

         public World(PointLight light, int reflectionDepth = 5){

             SceneLight = light;
             ReflectionDepth = reflectionDepth;

         }
          public World(PointLight light, Shape[] sceneObjects, int reflectionDepth = 5){

            SceneObjects = sceneObjects;
            SceneLight = light;
            ReflectionDepth = reflectionDepth;

         }
        public static Intersection[] IntersectWorld(World world, Ray r){
            //Create list that we will turn into array, it is done this way for now but refactoring other parts of the code to a list later will help
            int objCount = world.SceneObjects.Length; 
            List<Intersection> intersectionList = new List<Intersection>();
            for(int i = 0; i < objCount; i++ ){
                Intersection[] intersection = Intersect.IntersectShape(world.SceneObjects[i],r);
                //practicing foreach loops 
                foreach(Intersection elem in intersection){
                    intersectionList.Add(elem);
                }
            }

            Intersection[] intersections= Intersect.SortIntersections(intersectionList.ToArray());
            return intersections;
        }

        public static Tuple ShadeHit(World world, Precomputation comps, int remaining){
           bool shadowed = IsShadowed(world,comps.OverPoint);
            Tuple Colour = Material.Lighting(comps.Object.Material,comps.Object,world.SceneLight,comps.OverPoint,comps.EyeVector,comps.NormalVector,shadowed);
            Tuple reflectedColor = world.ReflectedColor(comps,remaining);
           return Colour + reflectedColor;
           
        }
        
        public static Tuple ColourAt(World world, Ray ray, int remaining){
             Intersection[] worldIntersections = IntersectWorld(world,ray);
             Intersection hit = Intersect.Hit(worldIntersections);
             if(hit != null){
                 Precomputation comps = Intersect.PrepareComputations(hit,ray);
                 return ShadeHit(world,comps, remaining);
             }else{
                 

                 return new Tuple(0,0,0,0);
             }
          
        }

         public static bool IsShadowed(World world,Tuple point){
            Tuple lightv = world.SceneLight.Position - point;
            float distance = lightv.Magnitude();
            Tuple direction = lightv.Normalise();
            Ray shadowRay = new Ray(point,direction);
            Intersection[] worldIntersections = IntersectWorld(world,shadowRay);
            Intersection hit = Intersect.Hit(worldIntersections);
             if(hit != null){
                 if(hit.T_Value < distance){
                     return true;
                 }  
        }
        return false;     
         }


        public Tuple ReflectedColor(Precomputation comp,int remaining){
            if(comp.Object.Material.Reflective == 0 || remaining <= 0){
                return new Tuple(0,0,0,0);
            }
            Ray reflectRay = new Ray(comp.OverPoint,comp.ReflectVector);
            Tuple colour = ColourAt(this,reflectRay, remaining - 1);
            return colour * comp.Object.Material.Reflective;

        }
        //Just a quick array copy method
        public void AddShapeToScene(params Shape[] shapes){
            if(SceneObjects == null){
                SceneObjects = shapes;
                return;
            }
            Shape[] newShapeArray = new Shape[(SceneObjects.Length) + shapes.Length];
            int i = 0;
            for(; i < SceneObjects.Length; i ++){
                newShapeArray[i] = SceneObjects[i];
            }
            for(; i < SceneObjects.Length + shapes.Length; i ++){
                newShapeArray[i] = shapes[i - (SceneObjects.Length)];
            }
            SceneObjects = newShapeArray;

        }

    }
}
