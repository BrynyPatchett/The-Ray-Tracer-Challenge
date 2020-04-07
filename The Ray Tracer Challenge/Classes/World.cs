using System;
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
            Tuple refractedColor = RefractedColor(world,comps,remaining);
            Material m = comps.Object.Material;

            if(m.Reflective > 0f && m.Transparency >0f){
                float reflectance = Schlick(comps);
                return Colour + reflectedColor * reflectance + refractedColor * (1 - reflectance);
            }else{
                return Colour + reflectedColor + refractedColor ;
            }  
           
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

        public static Tuple  RefractedColor(World world, Precomputation comp, int remaining){
           
            if(comp.Object.Material.Transparency == 0 || remaining == 0){
                return new Tuple(0,0,0);
            }

            float n_ratio = comp.n1/ comp.n2;
            float cos_i = comp.EyeVector.Dot(comp.NormalVector);
            float sin2_t = (n_ratio * n_ratio) * (1 - (cos_i * cos_i));

             if(sin2_t > 1){
                 return new Tuple(0,0,0);
             }

            float cos_t = MathF.Sqrt(1.0f - sin2_t);
            Tuple direction = comp.NormalVector * (n_ratio * cos_i - cos_t) - comp.EyeVector * n_ratio;
            Ray refract_ray = new Ray(comp.UnderPoint, direction);

            return ColourAt(world,refract_ray,remaining-1) * comp.Object.Material.Transparency;
          
        }

        public static float Schlick(Precomputation comp){
            float cos = comp.EyeVector.Dot(comp.NormalVector);

            if(comp.n1 > comp.n2){
                float ratio = comp.n1/ comp.n2;
                float sin2_t = ratio * ratio * (1.0f - (cos * cos));
                if(sin2_t > 1.0){
                    return 1.0f;
                }
                float cos_t  = MathF.Sqrt(1.0f - sin2_t);
                cos = cos_t;
            }
            float r0 = ((comp.n1 - comp.n2) / (comp.n1 + comp.n2)) * ((comp.n1 - comp.n2) / (comp.n1 + comp.n2));
            return r0 + (1-r0) * MathF.Pow((1 - cos), 5);


        }


    }
}
