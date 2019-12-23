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




            /*Canvas c2 = new Canvas(3840,2160,1);

            int pixelColour = (int) 0xFF0000;




            for( int canY = 0; canY < c2.Height; canY++){
                 for( int canX = 0; canX < c2.Width; canX++){
                       c2.SetPixelColour(canX,canY,pixelColour);
                }
            }

            Console.WriteLine("Finished");
            c2.saveCanvasToPPMInts("textImage.ppm");


            Canvas c3 = new Canvas(3840,2160);
            Tuple colour1 = new Tuple(1.0f,0.8f,0.6f,0.0f);

             for( int canY = 0; canY < c3.Height; canY++){
               for( int canX = 0; canX < c3.Width; canX++){
                       c3.SetPixelColour(canX,canY,colour1);
                }
            }
            c3.saveCanvasToPPM("textImage2.ppm");*/





          /*  Canvas c2 = new Canvas(900, 550, 1);
            int backColour = (int)0x000000;
            int bulletColour = (int)0xFF0000;

            for (int canY = 0; canY < c2.Height; canY++)
            {
                for (int canX = 0; canX < c2.Width; canX++)
                {
                    c2.SetPixelColour(canX, canY, backColour);
                }
            }




            Tuple initialBulletPos = new Tuple(0.0f, 1.0f, 0.0f, 1.0f);
            Tuple initalVelocity = (new Tuple(1.0f, 1.8f, 0f).Normalise()) * 11.25f;

            Tuple enviroGrav = new Tuple(0.0f, -0.1f, 0.0f);
            Tuple windSpeed = new Tuple(-0.01f, 0.0f, 0.0f);

            Projectile bullet = new Projectile(initialBulletPos, initalVelocity);
            Environment e = new Environment(enviroGrav, windSpeed);*/

           // int numberOfTicks = 0;
           // while (!(bullet.Position.x >= c2.Width || bullet.Position.x < 0 || bullet.Position.y >= c2.Height || bullet.Position.y < 0)  )
           // {
               // numberOfTicks++;
               // bullet = tick(e, bullet);
               // c2.SetPixelColour((int)bullet.Position.x, (c2.Height - (int)bullet.Position.y), bulletColour);

                // Console.WriteLine("Reported Position : " + bullet.Position);
                //Console.WriteLine("drawing at x : " + (int)bullet.Position.x + " y: " +  (c2.Height - (int)bullet.Position.y));

           // }

            //c2.saveCanvasToPPMInts("firstBulletTest.ppm");


            /*float[,] test = new float [4,4];

            test[0,0] = 1.0f;
            test[0,1] = 2.0f;
            test[0,2] = 3.0f;
            test[0,3] = 4.0f;
            test[1,0] = 5.5f;
            test[1,1] = 6.5f;
            test[1,2] = 7.5f;
            test[1,3] = 8.5f;
            test[2,0] = 9.0f;
            test[2,1] = 10.0f;
            test[2,2] = 11.0f;
            test[2,3] = 12.0f;
            test[3,0] = 13.5f;
            test[3,1] = 14.5f;
            test[3,2] = 15.5f;
            test[3,3] = 16.5f;*/

           // Matrix floatMatrix = new Matrix(test);
           /* Console.WriteLine(floatMatrix.floatMatrix[0,0].ToString());
            Console.WriteLine(floatMatrix.floatMatrix[0,3].ToString());
            Console.WriteLine(floatMatrix.floatMatrix[1,0].ToString());
            Console.WriteLine(floatMatrix.floatMatrix[1,2].ToString());
            Console.WriteLine(floatMatrix.floatMatrix[2,2].ToString());
            Console.WriteLine(floatMatrix.floatMatrix[3,0].ToString());
            Console.WriteLine(floatMatrix.floatMatrix[3,2].ToString());
            */





           /* Matrix floatMatrix = new Matrix(4,4);
            floatMatrix.floatMatrix[0,0] = 1f;
            floatMatrix.floatMatrix[0,3] = 4f;
            floatMatrix.floatMatrix[1,0] = 5.5f;
            floatMatrix.floatMatrix[1,2] = 7.5f;
            floatMatrix.floatMatrix[2,2] = 11f;
            floatMatrix.floatMatrix[3,0] = 13.5f;
            floatMatrix.floatMatrix[3,2] = 15.5f;*/

            //Console.WriteLine(floatMatrix.ToString());

           /* Matrix floatMatrix2 = new Matrix(3,3);
            floatMatrix2.floatMatrix[0,0] = -3f;
            floatMatrix2.floatMatrix[0,1] = 5f;
            floatMatrix2.floatMatrix[0,2] = 0f;
            floatMatrix2.floatMatrix[1,0] = 1f;
            floatMatrix2.floatMatrix[1,1] = -2f;
            floatMatrix2.floatMatrix[1,2] = -7f;
            floatMatrix2.floatMatrix[2,0] = 0f;
            floatMatrix2.floatMatrix[2,1] = 1f;
            floatMatrix2.floatMatrix[2,2] = 1;

            Console.WriteLine(floatMatrix2.ToString());


            Matrix floatMatrix3 = new Matrix(2,2);

            floatMatrix3.floatMatrix[0,0] = -3f;
            floatMatrix3.floatMatrix[0,1] = 5f;
            floatMatrix3.floatMatrix[1,0] = 1f;
            floatMatrix3.floatMatrix[1,1] = -2f;*/




             //Console.WriteLine(floatMatrix3.ToString());


            /*float[,] m1 = new float [4,4];

            m1[0,0] = 1.0f;
            m1[0,1] = 2.0f;
            m1[0,2] = 3.0f;
            m1[0,3] = 4.0f;
            m1[1,0] = 5.0f;
            m1[1,1] = 6.0f;
            m1[1,2] = 7.0f;
            m1[1,3] = 8.0f;
            m1[2,0] = 9.0f;
            m1[2,1] = 8.0f;
            m1[2,2] = 7.0f;
            m1[2,3] = 6.0f;
            m1[3,0] = 5.0f;
            m1[3,1] = 4.0f;
            m1[3,2] = 3.0f;
            m1[3,3] = 2.0f;

            Matrix fm1 = new Matrix(m1);

            float[,] m2 = new float [4,4];

            m2[0,0] = -2.0f;
            m2[0,1] = 1.0f;
            m2[0,2] = 2.0f;
            m2[0,3] = 3.0f;
            m2[1,0] = 3.0f;
            m2[1,1] = 2.0f;
            m2[1,2] = 1.0f;
            m2[1,3] = -1.0f;
            m2[2,0] = 4.0f;
            m2[2,1] = 3.0f;
            m2[2,2] = 6.0f;
            m2[2,3] = 5.0f;
            m2[3,0] = 1.0f;
            m2[3,1] = 2.0f;
            m2[3,2] = 7.0f;
            m2[3,3] = 8.0f;
            
            Matrix fm2 = new Matrix(m2);
          
           

            Matrix fmm = fm1 * fm2;

            Console.WriteLine(fmm.ToString());
            */


            /*float[,] m3 = new float [4,4];

            m3[0,0] = 0.0f;
            m3[0,1] = 1.0f;
            m3[0,2] = 2.0f;
            m3[0,3] = 4.0f;
            m3[1,0] = 1.0f;
            m3[1,1] = 2.0f;
            m3[1,2] = 4.0f;
            m3[1,3] = 8.0f;
            m3[2,0] = 2.0f;
            m3[2,1] = 4.0f;
            m3[2,2] = 8.0f;
            m3[2,3] = 16.0f;
            m3[3,0] = 4.0f;
            m3[3,1] = 8.0f;
            m3[3,2] = 16.0f;
            m3[3,3] = 32.0f;

            Matrix mt = new Matrix(m3);

            Tuple b = new Tuple(1,2,3,4);

            IdentityMatrix im =  new IdentityMatrix();

            Console.WriteLine((im * b).ToString());*/
            /*
            float[,] m3 = new float [4,4];

            m3[0,0] = 0.0f;
            m3[0,1] = 9.0f;
            m3[0,2] = 3.0f;
            m3[0,3] = 0.0f;
            m3[1,0] = 9.0f;
            m3[1,1] = 8.0f;
            m3[1,2] = 0.0f;
            m3[1,3] = 8.0f;
            m3[2,0] = 1.0f;
            m3[2,1] = 8.0f;
            m3[2,2] = 5.0f;
            m3[2,3] = 3.0f;
            m3[3,0] = 0.0f;
            m3[3,1] = 0.0f;
            m3[3,2] = 5.0f;
            m3[3,3] = 8.0f;
            
             Matrix mt = new Matrix(m3);

             mt = mt.Transpose();
            Console.WriteLine((mt).ToString());

            
            IdentityMatrix im =  new IdentityMatrix();

            Console.WriteLine(im.Transpose().ToString());*/


        /*   float[,] m22 = new float [2,2];

            m22[0,0] = 1.0f;
            m22[0,1] = 5.0f;
            m22[1,0] = -3.0f;
            m22[1,1] = 2.0f;

            Matrix m2by2 = new Matrix(m22);
            Console.WriteLine(m2by2.Determinant());*/

           /* float[,] m1 = new float [3,3];
            m1[0,0] = 1.0f;
            m1[0,1] = 5.0f;
            m1[0,2] = 0.0f;
            
            m1[1,0] = -3.0f;
            m1[1,1] = 2.0f;
            m1[1,2] = 7.0f;
            
            m1[2,0] = 0.0f;
            m1[2,1] = 6f;
            m1[2,2] = -3.0f;*/

           /* Matrix mm = new Matrix(m1);

            Matrix m2 = mm.Submatrix(0,2);
            Console.WriteLine(m2.ToString());

            float[,] m3 = new float [4,4];

            m3[0,0] = -6.0f;
            m3[0,1] = 1.0f;
            m3[0,2] = 1.0f;
            m3[0,3] = 6.0f;
            m3[1,0] = -8.0f;
            m3[1,1] = 5.0f;
            m3[1,2] = 8.0f;
            m3[1,3] = 6.0f;
            m3[2,0] = -1.0f;
            m3[2,1] = 0.0f;
            m3[2,2] = 8.0f;
            m3[2,3] = 2.0f;
            m3[3,0] = -7.0f;
            m3[3,1] = 1.0f;
            m3[3,2] = -1.0f;
            m3[3,3] = 1.0f;
            

            Matrix mm2 = new Matrix(m3);

            Matrix subm2 = mm2.Submatrix(2,1);
            Console.WriteLine(subm2.ToString());*/


            /*float[,] m4 = new float [3,3];
            m4[0,0] = 3.0f;
            m4[0,1] = 5.0f;
            m4[0,2] = 0.0f;
            
            m4[1,0] = 2.0f;
            m4[1,1] = -1.0f;
            m4[1,2] = -7.0f;
            
            m4[2,0] = 6.0f;
            m4[2,1] = -1f;
            m4[2,2] = 5.0f;

            Matrix mm2 = new Matrix(m4);

             Console.WriteLine(mm2.Minor(0,0));
             Console.WriteLine(mm2.Cofactor(0,0));
             Console.WriteLine(mm2.Minor(1,0));
             Console.WriteLine(mm2.Cofactor(1,0));*/



           /* float[,] m4 = new float [3,3];
            m4[0,0] = 1.0f;
            m4[0,1] = 2.0f;
            m4[0,2] = 6.0f;
            
            m4[1,0] = -5.0f;
            m4[1,1] = 8.0f;
            m4[1,2] = -4.0f;
            
            m4[2,0] = 2.0f;
            m4[2,1] = 6f;
            m4[2,2] = 4.0f;

            Matrix mm2 = new Matrix(m4);
            Console.WriteLine(mm2.Cofactor(0,0));
            Console.WriteLine(mm2.Cofactor(0,1));
            Console.WriteLine(mm2.Cofactor(0,2));
           Console.WriteLine(mm2.Determinant());
            Console.WriteLine("------");*/

           /* float[,] m3 = new float [4,4];

            m3[0,0] = -5.0f;
            m3[0,1] = 2.0f;
            m3[0,2] = 6.0f;
            m3[0,3] = -8.0f;
            m3[1,0] = 1.0f;
            m3[1,1] = -5.0f;
            m3[1,2] = 1.0f;
            m3[1,3] = 8.0f;
            m3[2,0] = 7.0f;
            m3[2,1] = 7.0f;
            m3[2,2] = -6.0f;
            m3[2,3] = -7.0f;
            m3[3,0] = 1.0f;
            m3[3,1] = -3.0f;
            m3[3,2] = 7.0f;
            m3[3,3] = 4.0f;
             Matrix mm3 = new Matrix(m3);
            Console.WriteLine(mm3.Inverse());*/

             /*Console.WriteLine("------");

            float[,] m3 = new float [4,4];

            m3[0,0] = 8.0f;
            m3[0,1] = -5.0f;
            m3[0,2] = 9.0f;
            m3[0,3] = 2.0f;
            m3[1,0] = 7.0f;
            m3[1,1] = 5.0f;
            m3[1,2] = 6.0f;
            m3[1,3] = 1.0f;
            m3[2,0] = -6.0f;
            m3[2,1] = 0.0f;
            m3[2,2] = 9.0f;
            m3[2,3] = 6.0f;
            m3[3,0] = -3.0f;
            m3[3,1] = 0.0f;
            m3[3,2] = -9.0f;
            m3[3,3] = -4.0f;
             Matrix mm3 = new Matrix(m3);
            Console.WriteLine(mm3.Inverse());*/



            float[,] m3 = new float [4,4];

            m3[0,0] = 3.0f;
            m3[0,1] = -9.0f;
            m3[0,2] = 7.0f;
            m3[0,3] = 3.0f;
            m3[1,0] = 3.0f;
            m3[1,1] = -8.0f;
            m3[1,2] = 2.0f;
            m3[1,3] = -9.0f;
            m3[2,0] = -4.0f;
            m3[2,1] = 4.0f;
            m3[2,2] = 4.0f;
            m3[2,3] = 1.0f;
            m3[3,0] = -6.0f;
            m3[3,1] = 5.0f;
            m3[3,2] = -1.0f;
            m3[3,3] = 1.0f;
             Matrix mm3 = new Matrix(m3);
           

            float[,] m4 = new float [4,4];

            m4[0,0] = 8.0f;
            m4[0,1] = 2.0f;
            m4[0,2] = 2.0f;
            m4[0,3] = 2.0f;
            m4[1,0] = 3.0f;
            m4[1,1] = -1.0f;
            m4[1,2] = 7.0f;
            m4[1,3] = 0.0f;
            m4[2,0] = 7.0f;
            m4[2,1] = 0.0f;
            m4[2,2] = 5.0f;
            m4[2,3] = 4.0f;
            m4[3,0] = 6.0f;
            m4[3,1] = -2.0f;
            m4[3,2] = 0.0f;
            m4[3,3] = 5.0f;
            Matrix mm4 = new Matrix(m4);

            //Console.WriteLine((mm3).ToString());
           // Console.WriteLine((mm3 * mm4).ToString());
           // Console.WriteLine(((mm3 * mm4) * mm4.Inverse()).ToString());

             //IdentityMatrix mm5 = new IdentityMatrix();
            


           //  Tuple Pos = new Tuple(1.0f, 1.0f, 1.0f, 1.0f);

             /*mm5.floatMatrix[0,0] = 5;
             Pos = mm5 * Pos;
            Console.WriteLine((Pos).ToString());*/

            /*Tuple Pos = new Tuple(-3.0f, 4.0f, 5.0f, 1.0f); 
            Tuple vec = new Tuple(-3.0f, 4.0f, 5.0f, 0.0f); 
            TranslationMatrix tm = new TranslationMatrix(5,-3,2)
            Pos = tm.Inverse() * Pos;
            Console.WriteLine((Pos).ToString());
            Console.WriteLine((vec).ToString());
            Console.WriteLine((tm * vec).ToString());*/

           /*Tuple Pos = new Tuple(-4.0f, 6.0f, 8.0f, 1.0f); 
            Tuple vec = new Tuple(-4.0f, 6.0f, 8.0f, 1.0f); 
            ScaleMatrix sm = new ScaleMatrix(2,3,4);
            Pos = sm * Pos;
            Console.WriteLine((Pos).ToString());
            Console.WriteLine((vec).ToString());
            Console.WriteLine((sm * vec).ToString());
            Console.WriteLine((sm.Inverse() * vec).ToString());

            Tuple Pos1 = new Tuple(2.0f, 3.0f, 4.0f, 1.0f); 
            ScaleMatrix sm1 = new ScaleMatrix(-1,1,1);
            Console.WriteLine((sm1 * Pos1).ToString());*/




            Tuple Pos = new Tuple(2.0f, 3, 4.0f, 1.0f); 
            ShearingMatrix shear = new ShearingMatrix(0,0,0,0,0,1);

            Console.WriteLine((shear * Pos).ToString());
           
          











        }

        public static Projectile tick(Environment e, Projectile p)
        {

            Tuple position = p.Position + p.Velocity;
            Tuple Velocity = p.Velocity + e.Gravity + e.WindSpeed;
            return new Projectile(position, Velocity);

        }

    }
}
