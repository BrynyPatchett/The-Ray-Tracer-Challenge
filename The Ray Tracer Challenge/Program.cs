using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace The_Ray_Tracer_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            

               /*Shape p = new Plane();
               p.Material.Colour = new Tuple(1.0f,0f,0.0f);
               p.Material.Diffuse = 0.7f;
               p.Material.Specular = 0.3f;
               p.Material.Pattern = new RingPattern(new Tuple(0.1f,0.9f,0.2f,0),new Tuple(0.1f,0,0.8f,0));
               p.Material.Reflective = 0.5f;
             //  p.Material.Pattern.Transform = new ScaleMatrix(10,10,10);


               Shape p2 = new Plane();
               p2.Transform =new RotationMatrix_X(MathF.PI/2) * new TranslationMatrix(0f,0,1000f);
               p2.Material.Colour = new Tuple(0.0f,.2f,.8f);
               p2.Material.Diffuse = 0.7f;
               p2.Material.Specular = 0.3f;
               


              Sphere middle = new Sphere();
              middle.Transform = new TranslationMatrix(-0.5f,1,0.5f);
              middle.Material.Colour = new Tuple(0.1f,1f,0.5f);
              middle.Material.Diffuse = 0.7f;
              middle.Material.Specular = 0.3f;
              middle.Material.Reflective = 1.0f;
              middle.Material.Pattern = new RingPattern(new Tuple(1,1,1,0),new Tuple(0,0,0,0));
              middle.Material.Pattern.Transform = new ScaleMatrix(0.25f,0.25f,0.25f) * new RotationMatrix_X(90);
             

              Sphere right = new Sphere();
              right.Transform = new TranslationMatrix(1.5f,0.5f,-0.5f) * new ScaleMatrix(0.5f,0.5f,0.5f);
              right.Material.Colour = new Tuple(0.0f,0f,0f);
              right.Material.Diffuse = 0.7f;
              right.Material.Specular = 0.1f;
              right.Material.Transparency = 0.85f;
              right.Material.Reflective = 0.2f;
              right.Material.Refractive_index = 1.333f;
              

              Sphere left = new Sphere();
              left.Transform = new TranslationMatrix(-1.5f,0.33f,-0.75f) * new ScaleMatrix(0.33f,0.33f,0.33f);
              left.Material.Colour = new Tuple(1f,0.8f,0.1f);
              left.Material.Diffuse = 0.7f;
              left.Material.Specular = 0.3f;
              left.Material.Pattern = new StripedPattern(new Tuple(1,1,0.9f,0),new Tuple(0.5f,0.3f,0.4f,0));
              left.Material.Pattern.Transform = new ScaleMatrix(0.5f,0.5f,0.5f) * new RotationMatrix_Z(45);


              Shape[] WorldObjects = {p,left,middle,right};
              PointLight light = new PointLight(new Tuple(-10,10,-10,1), new Tuple(1,1,1,0));
              World world = new World(light,WorldObjects);
              Camera camera = new Camera(800,600,MathF.PI/3);
              camera.Transform = new ViewMatrix(new Tuple(0,1.5f,-5,1),new Tuple(0,1,0,1), new Tuple(0,1,0,0));

              Canvas image = camera.Render(world);

              image.saveCanvasToPPM("FifthSceneFHD.ppm");
              Console.WriteLine("done"); */
              Tests.RunTests();

              

        }

        public static Projectile tick(Environment e, Projectile p)
        {

            Tuple position = p.Position + p.Velocity;
            Tuple Velocity = p.Velocity + e.Gravity + e.WindSpeed;
            return new Projectile(position, Velocity);

        }

    }
}
