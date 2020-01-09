using System;

namespace The_Ray_Tracer_Challenge
{
    public class Camera
    {


        public int Hsize{get;}
        public int Vsize{get;}

        public float HalfWidth{get;}
        public float HalfHeight{get;}

        public float FOV{get;}

        public Matrix Transform{get;set;}

        public float PixelSize{get;}
       


        public Camera(int hsize, int vsize, float fov)
        {
            Hsize = hsize;
            Vsize = vsize;
            FOV = fov;
            Transform = new IdentityMatrix();

            float halfview = MathF.Tan(FOV/2);
            
            float aspect = (float)Hsize/(float)Vsize;
            if(aspect >= 1){
               HalfWidth = halfview;
               HalfHeight = halfview/aspect;
            }else{
                HalfWidth = halfview * aspect;
               HalfHeight = halfview;
            }

            PixelSize = (HalfWidth * 2)/ Hsize;


        }
        public Ray RayForPixel(int x, int y){
                float xoffest = (x + 0.5f) * PixelSize;
                float yoffest = (y + 0.5f) * PixelSize;

                float worldX = HalfWidth - xoffest; 
                float worldY = HalfHeight - yoffest; 

                Tuple pixel = (Transform.Inverse()) * new Tuple(worldX,worldY,-1,1);
                Tuple origin = (Transform.Inverse()) * new Tuple(0,0,0,1);
                Tuple direction = (pixel - origin).Normalise();

                return new Ray(origin,direction);



        }
        public static Ray RayForPixel(Camera  c, int x, int y){
                float xoffest = (x + 0.5f) * c.PixelSize;
                float yoffest = (y + 0.5f) * c.PixelSize;

                float worldX =c. HalfWidth - xoffest; 
                float worldY = c.HalfHeight - yoffest; 

                Tuple pixel = (c.Transform.Inverse()) * new Tuple(worldX,worldY,-1,1);
                Tuple origin = (c.Transform.Inverse()) * new Tuple(0,0,0,1);
                Tuple direction = (pixel - origin).Normalise();

                return new Ray(origin,direction);
            
        }
        public Canvas Render(World w){
            Canvas image = new Canvas(Hsize,Vsize);

            for(int y = 0; y < Vsize; y++){
                for(int x = 0; x < Hsize; x ++){
                    Ray r = RayForPixel(x,y);
                    Tuple Colour = World.ColourAt(w,r);
                    image.SetPixelColour(x,y,Colour);
                }
            }
            return image;
            

        }

        
            

    }
}
