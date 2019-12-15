﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace The_Ray_Tracer_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           // int width = int.Parse(args[0]);
            //int height = int.Parse(args[1]);
           
        
            Tuple tuple1 = new Tuple(1.0f,2.0f,3.0f,0.0f);
            
            ThreeVector v = new ThreeVector(1.0f,2.0f,3.0f);
        
            
        
            Console.WriteLine("------------------");
            Console.WriteLine(v.Magnitude() + "");
            v.Normalise();
            Console.WriteLine(v.Magnitude() + "");

             Console.WriteLine(tuple1.Magnitude() + "");
             tuple1.Normalise();
             Console.WriteLine(tuple1.Magnitude() + "");


             Console.WriteLine(Tuple.Magnitude(Tuple.Normalise(tuple1)) + "" );


            Console.WriteLine("------------------");
            //tuple1 = tuple1 + tuple2;
             Console.WriteLine(tuple1.ToString());
             Console.WriteLine((-tuple1).ToString());
             Console.WriteLine(tuple1 * 3.5f + "" );
             Console.WriteLine(tuple1 * 0.5f + "" );
             Console.WriteLine(tuple1 / 2 + "");



             Console.WriteLine(tuple1.Magnitude() + "");
             tuple1.Normalise();
             Console.WriteLine(tuple1.Magnitude() + "");

            Console.WriteLine(Tuple.Magnitude(Tuple.Normalise(tuple1)) + "" );

             tuple1 = -tuple1;
          //  unitializedTuple = fillTupleWithPoint();
            

            float x = 0.000001f;
            float y = 0.0002f;
            bool answer = Arithmetic.compareTwoFloats(x,y);


   
            Tuple tuple2 = new Tuple(1.0f,2.0f,3.0f,0.0f);
            Tuple tuple3 = new Tuple(2.0f,3.0f,4.0f,0.0f);
            
            tuple2.Cross(tuple3);
            Console.WriteLine(tuple2);


            Tuple initialBulletPos = new Tuple(0.0f,1.0f,0.0f,1.0f);
            Tuple initalVelocity = new Tuple(0.1f,1.0f,0f).Normalise();

            Tuple enviroGrav = new Tuple(0.0f,-0.1f,0.0f);
            Tuple windSpeed = new Tuple(-0.01f,0.0f,0f);

            Projectile bullet = new Projectile(initialBulletPos, initalVelocity);
            Environment e = new Environment(enviroGrav,windSpeed);

            int numberOfTicks = 0; 
            while(bullet.Position.y >= 0){
                numberOfTicks ++;
                bullet = tick(e,bullet);
                Console.WriteLine("Reported Position : " + bullet.Position);

            }
                
            
                Tuple tuple4 = new Tuple(0.9f,0.6f,0.75f,0.0f);
                Tuple tuple5 = new Tuple(0.7f,0.1f,0.25f,0.0f);
                tuple5 = tuple4 - tuple5; 
                Console.WriteLine(tuple5);

                Tuple tuple6 = new Tuple(0.2f,0.3f,0.4f,0.0f);

                tuple6 = Tuple.scaleTuple(tuple6,2);
                Console.WriteLine(tuple6);

               // Tuple tuple7 = new Tuple(1.0f,0.2f,0.4f,0.0f);
               /// Tuple tuple8 = new Tuple(0.9f,1.0f,0.1f,0.0f);
                Console.WriteLine(tuple7 * tuple8); */
                //Console.WriteLine(tuple4.Red+  "is red");
               // Console.WriteLine(tuple4.Green +  "is green");
               // Console.WriteLine(tuple4.Blue+  "is blue");
               


            

               // Canvas c = new Canvas(10,20);
               // Tuple red = new Tuple(1.0f,0.0f,0.0f,0.0f);
                //c.SetPixelColour(2,3,red);
                //Console.WriteLine(c.GetPixelColour(2,3));




                Canvas c2 = new Canvas(200,200);
               // Tuple colour1 = new Tuple(1.5f,0.0f,0.0f,0.0f);
               // Tuple colour2 = new Tuple(0.0f,0.5f,0.0f,0.0f);
               // Tuple colour3 = new Tuple(-0.5f,0.0f,1.0f,0.0f);
               // c2.SetPixelColour(0,0,colour1);
                //c2.SetPixelColour(2,1,colour2);
               // c2.SetPixelColour(4,2,colour3);
                 Tuple colour4 = new Tuple(1.0f,0.8f,0.6f,0.0f);
                for( int canY = 0; canY < c2.Height; canY++){
                     for( int canX = 0; canX < c2.Width; canX++){
                           c2.SetPixelColour(canX,canY,colour4);
                    }
                }
                

                Console.WriteLine(c2.saveCanvasToPPM("textImage.ppm"));

                //Console.WriteLine("Hello\n World");












            //Console.WriteLine(answer);
            
           
           /* TestClass test = new TestClass();
            Console.WriteLine("Hello World!");
            Console.WriteLine(test.Testvariable);
            test.Testvariable = 55;
            Console.WriteLine(test.Testvariable);
            var testTuple = (a:4.3f,4.3f,34.4);
            Console.WriteLine(testTuple.GetType());   */
        }

        public static Projectile tick(Environment e, Projectile p){

        Tuple position = p.Position + p.Velocity;
        Tuple Velocity = p.Velocity + e.Gravity + e.WindSpeed;
        return new Projectile(position,Velocity);

        }

    }
}