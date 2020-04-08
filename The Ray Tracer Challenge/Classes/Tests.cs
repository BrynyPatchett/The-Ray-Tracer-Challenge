using System;

namespace The_Ray_Tracer_Challenge
{
    static class Tests
    {
     
    
        public static void RunTests()
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



            /*float[,] m3 = new float [4,4];

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
            Matrix mm4 = new Matrix(m4);*/

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



            /*Canvas c2 = new Canvas(500,500,1);
            Tuple tweleve = new Tuple(0.0f, 0, 1.0f, 1.0f); 
            Tuple time;
            RotationMatrix_Y  rotation;
            int center = 250;
            int clockColour = (int)0xFF0000;
            int radius = 3 * (250/8);

            TranslationMatrix move = new TranslationMatrix(center,0,center);
            ScaleMatrix moveR = new ScaleMatrix(radius,0,radius);*/

/*
            for(int i = 0; i < 12; i++){

            rotation = new RotationMatrix_Y(i * (MathF.PI / 6));
            time = rotation * tweleve;
            time = moveR * time;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);

            }*/

           /* rotation = new RotationMatrix_Y(1 * (MathF.PI / 6));
            time = rotation * tweleve;
            time = moveR * time;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  two = new RotationMatrix_Y(2 * (MathF.PI / 6));
            time = two * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  three= new RotationMatrix_Y(3 * (MathF.PI / 6));
            time = three * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  four = new RotationMatrix_Y(4 * (MathF.PI / 6));
            time = four * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  five = new RotationMatrix_Y(5 * (MathF.PI / 6));
            time = five * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  six = new RotationMatrix_Y(6 * (MathF.PI / 6));
            time = six * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  seven = new RotationMatrix_Y(7 * (MathF.PI / 6));
            time = seven * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  eight = new RotationMatrix_Y(8 * (MathF.PI / 6));
            time = eight * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  nine = new RotationMatrix_Y(9 * (MathF.PI / 6));
            time = nine * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  ten = new RotationMatrix_Y(10 * (MathF.PI / 6));
            time = ten * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;
            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);


            RotationMatrix_Y  eleven = new RotationMatrix_Y(11 * (MathF.PI / 6));
            time = eleven * tweleve;
            time.x = time.x * radius;
            time.z = time.z * radius;
            time = move * time;

            c2.SetPixelColour((int)time.x,(int)time.z,clockColour);*/



            /*c2.saveCanvasToPPMInts("firstClockTest.ppm");


            Projectile [] proArray = new Projectile[100];
            for(int i = 0; i < 100; i++){
                    proArray[i] = new Projectile(new Tuple(1.0f, 1.8f, 0f),new Tuple(1.0f, 1.8f, 0f).Normalise());
            }   
            for(int i = 0; i < 100; i++){
                   Console.WriteLine("Id value: "+ proArray[i].Id);
            }   

           
           Console.WriteLine("Id value: "+ proArray[45].Id);*/

          // Ray r = new Ray(new Tuple(0,0,5.0f,1), new Tuple(0,0,1,0));
           //Sphere s = new Sphere();
           //float [] xs  = Intersect.SphereIntersection(s,r);
        //Console.WriteLine(xs.Length);
       // Console.WriteLine(xs[0]);
           // Console.WriteLine(xs[1]);

            /*Intersection i1 = new Intersection(1,s);
            Intersection i2 = new Intersection(2,s);
            Intersection [] xs = Intersect.Intersections(i1,i2);
            Console.WriteLine(xs.Length);
            Console.WriteLine(xs[0].T_Value);
            Console.WriteLine(xs[1].T_Value);*/

          /* Ray r = new Ray(new Tuple(0,0,5.0f,1), new Tuple(0,0,1,0));
           Sphere s = new Sphere();
           Intersection [] xs = Intersect.SphereIntersection(s,r);
           Console.WriteLine(xs.Length);
           Console.WriteLine(xs[0].Object);
           Console.WriteLine(xs[1].Object);*/

           /*Sphere s = new Sphere();
           Intersection i1 = new Intersection(5,s);
           Intersection i2 = new Intersection(7,s);
           Intersection i3 = new Intersection(-3,s);
           Intersection i4 = new Intersection(2,s);



           Intersection [] xs = Intersect.Intersections(i1,i2,i3,i4);
           Intersection hit = Intersect.Hit(xs);
           Console.WriteLine(hit.T_Value);
        */

          /* Ray r = new Ray(new Tuple(1,2,3.0f,1), new Tuple(0,1,0,0));
           TranslationMatrix m = new TranslationMatrix(3,4,5);
           Ray r2 = r.Transform(m);
           Console.WriteLine(r2.Origin);
           Console.WriteLine(r2.Direction);*/

            /*Ray r = new Ray(new Tuple(1,2,3.0f,1), new Tuple(0,1,0,0));
           ScaleMatrix m = new ScaleMatrix(2,3,4);
           Ray r2 = r.Transform(m);
           Console.WriteLine(r2.Origin);
           Console.WriteLine(r2.Direction);*/

            /*Sphere s = new Sphere();
            Console.WriteLine(s.Transform.ToString());*/

            /*Sphere s = new Sphere();*/
            
            /*TranslationMatrix m = new TranslationMatrix(2,3,4);
            Console.WriteLine(m.ToString());
            s.Transform = m; 
             Console.WriteLine(s.Transform.ToString());*/


            /*Ray r = new Ray(new Tuple(0,0,-5.0f,1), new Tuple(0,0,1,0));
            Sphere s = new Sphere();
            s.Transform = (new ScaleMatrix(2,2,2));
            Intersection [] xs = Intersect.SphereIntersection(s,r);
            Console.WriteLine(xs.Length);
            Console.WriteLine(xs[0].T_Value);
            Console.WriteLine(xs[1].T_Value);*/

            /*Ray r = new Ray(new Tuple(0,0,-5.0f,1), new Tuple(0,0,1,0));
            Sphere s = new Sphere();
            s.Transform = (new TranslationMatrix(5,0,0));
            Intersection [] xs = Intersect.SphereIntersection(s,r);
            Console.WriteLine(xs.Length);*/


            

            /*Tuple ray_origin = new Tuple(0,0,-5.0f,1);
            float wall_z = 10.0f;
            float wall_size = 7.0f;


            Canvas c2 = new Canvas(100,100,1);

            float pixel_size = wall_size/100;

            float half = wall_size/2;

            int sphereColour = (int)0xFF0000;

            Sphere s = new Sphere();
            s.Transform = new ShearingMatrix(1,0,0,0,0,0) * new ScaleMatrix(0.5f,1,1);

            for(int y = 0; y < 100; y++){
                float world_y = half - pixel_size * y;

                for(int x = 0; x < 100; x ++){
                    float world_x = -half + pixel_size * x;

                    Tuple position = new Tuple(world_x,world_y,wall_z,1);

                    Ray r = new Ray(ray_origin, (position - ray_origin).Normalise());
                    Intersection [] xs = Intersect.SphereIntersection(s,r);

                    if(Intersect.Hit(xs) != null){
                           c2.SetPixelColour(x,y,sphereColour);
                    }
                }


            } 



            c2.saveCanvasToPPMInts("FirstRayTrace.ppm");*/

          


            

           
            /* Sphere s = new Sphere();
             s.Transform = new TranslationMatrix(0,1,0);
             Console.WriteLine(s.NormalAt(new Tuple(0,1.70711f,-0.70711f,1)));

             Sphere s1 = new Sphere();
             s1.Transform = new ScaleMatrix(1,0.5f,1) * new RotationMatrix_Z(MathF.PI / 5);
             Console.WriteLine(s1.NormalAt(new Tuple(0,MathF.Sqrt(2)/2,MathF.Sqrt(2)/2,1)));*/

             /*Tuple v = new Tuple(1,-1,0,0);
             Tuple n = new Tuple(0,1,0,0);
             Tuple r = Tuple.Reflect(v,n);
             Console.WriteLine(r);*/

             /*Tuple v = new Tuple(0,-1,0,0);
             Tuple n = new Tuple(MathF.Sqrt(2)/2,MathF.Sqrt(2)/2,0,0);
             Tuple r = Tuple.Reflect(v,n);
             Console.WriteLine(r);*/

             /*Tuple pos = new Tuple(0,0,0,1);
             Tuple col = new Tuple(1,1,1,0);
             PointLight light = new PointLight(pos,col);
             Console.WriteLine(light.Position);
             Console.WriteLine(light.ColorIntensity);*/

           //  Material m = new Material();
            // Tuple pos = new Tuple(0,0,0,1);


            // Tuple eyev = new Tuple(0,0,-1,0);
            // Tuple normalv = new Tuple(0,0,-1,0);
            // PointLight light = new PointLight(new Tuple(0,0,-10,1), new Tuple(1,1,1,0));
           //  Tuple result = Material.Lighting(m,light,pos,eyev,normalv);
            // Console.WriteLine(result);

              
            // Tuple eyev = new Tuple(0,MathF.Sqrt(2)/2,MathF.Sqrt(2)/2,0);
             //Tuple normalv = new Tuple(0,0,-1,0);
            // PointLight light = new PointLight(new Tuple(0,0,-10,1), new Tuple(1,1,1,0));
            // Tuple result = Material.Lighting(m,light,pos,eyev,normalv);
            //  Console.WriteLine(result);

             
            // Tuple eyev = new Tuple(0,0,-1,0);
            // Tuple normalv = new Tuple(0,0,-1,0);
            // PointLight light = new PointLight(new Tuple(0,10,-10,1), new Tuple(1,1,1,0));
            // Tuple result = Material.Lighting(m,light,pos,eyev,normalv);
             // Console.WriteLine(result);

                
            // Tuple eyev = new Tuple(0,-MathF.Sqrt(2)/2,-MathF.Sqrt(2)/2,0);
            // Tuple normalv = new Tuple(0,0,-1,0);
            // PointLight light = new PointLight(new Tuple(0,10,-10,1), new Tuple(1,1,1,0));
            // Tuple result = Material.Lighting(m,light,pos,eyev,normalv);
             // Console.WriteLine(result);

              // Tuple eyev = new Tuple(0,0,-1,0);
           //  Tuple normalv = new Tuple(0,0,-1,0);
          //   PointLight light = new PointLight(new Tuple(0,0,10,1), new Tuple(1,1,1,0));
          //   Tuple result = Material.Lighting(m,light,pos,eyev,normalv);
          //    Console.WriteLine(result);

             


           /* Material m = new Material();
            m.Colour = new Tuple(1,0.2f,1,0);
            Sphere s = new Sphere();
           // s.Transform = s.Transform * new ScaleMatrix(1f,0.25f,1f);
            s.Material = m;

            PointLight light = new PointLight(new Tuple (-10,10,-10,1), new Tuple(1,1,1,0));


            Tuple ray_origin = new Tuple(0,0,-5.0f,1);
            float wall_z = 10.0f;
            float wall_size = 7.0f;


            Canvas c2 = new Canvas(500,500);

            float pixel_size = wall_size/500;

            float half = wall_size/2;

            

            for(int y = 0; y < 500; y++){
                float world_y = half - pixel_size * y;

                for(int x = 0; x < 500; x ++){
                    float world_x = -half + pixel_size * x;

                    Tuple position = new Tuple(world_x,world_y,wall_z,1);

                    Ray r = new Ray(ray_origin, (position - ray_origin).Normalise());
                   


                    Intersection [] xs = Intersect.SphereIntersection(s,r);
                    Intersection hit = Intersect.Hit(xs);

                    if(hit != null){

                            Tuple point = r.Position(hit.T_Value_Tuple);
                            Tuple normal = s.NormalAt(point);
                            Tuple eye = -r.Direction;

                            Tuple Colour = Material.Lighting(hit.Object.Material, light, point,eye,normal);


                           c2.SetPixelColour(x,y,Colour);
                    }
                }


            } 



            c2.saveCanvasToPPM("SecondRayTrace.ppm");*/
           /* World w = new World();
            Ray r = new Ray(new Tuple(0,0,-5,1), new Tuple(0,0,1,0));
            Intersection [] xs = World.Intersect_World(w,r);
            Console.WriteLine(xs.Length);
            Console.WriteLine(xs[0].T_Value);
            Console.WriteLine(xs[1].T_Value);
            Console.WriteLine(xs[2].T_Value);
            Console.WriteLine(xs[3].T_Value);

            Sphere s = new Sphere();
            Intersection i = new Intersection(4,s);
            Precomputation comps = Intersect.PrepareComputations(i,r);
            Console.WriteLine(comps.T_Value);
            Console.WriteLine(comps.Object);
            Console.WriteLine(comps.Point);
            Console.WriteLine(comps.EyeVector);
            Console.WriteLine(comps.NormalVector);*/

            /*Ray r = new Ray(new Tuple(0,0,-5,1), new Tuple(0,0,1,0));
            Sphere s = new Sphere();
            Intersection i = new Intersection(1,s);
            Precomputation comps = Intersect.PrepareComputations(i,r);
            Console.WriteLine(comps.Point);
            Console.WriteLine(comps.EyeVector);
            Console.WriteLine(comps.NormalVector);
            Console.WriteLine(comps.Inside);*/

            /*Ray r = new Ray(new Tuple(0,0,0,1), new Tuple(0,0,1,0));
            Sphere s = new Sphere();
            Intersection i = new Intersection(1,s);
            Precomputation comps = Intersect.PrepareComputations(i,r);
            Console.WriteLine(comps.Point);
            Console.WriteLine(comps.EyeVector);
            Console.WriteLine(comps.NormalVector);
            Console.WriteLine(comps.Inside);*/

            /*World w = new World();
            Ray r = new Ray(new Tuple(0,0,-5,1), new Tuple(0,0,1,0));
            Sphere s1 = w.SceneObjects[0]; 
            Intersection i = new Intersection(4,s1);
            Precomputation comps = Intersect.PrepareComputations(i,r);
            Console.WriteLine(World.ShadeHit(w,comps));*/

            /*World w = new World();
            w.SceneLight = new PointLight(new Tuple(0,0.25f,0,1), new Tuple(1,1,1,0));
            Ray r = new Ray(new Tuple(0,0,0,1), new Tuple(0,0,1,0));
            Sphere s2 = w.SceneObjects[1]; 
            Intersection i = new Intersection(0.5f,s2);
            Precomputation comps = Intersect.PrepareComputations(i,r);
            Console.WriteLine(World.ShadeHit(w,comps));*/

          /* World w = new World();
            Ray r = new Ray(new Tuple(0,0,-5f,1), new Tuple(0,1,0,0));
            Tuple colour = World.ColourAt(w,r);
             Console.WriteLine(colour);*/

            /*World w = new World();
            Ray r = new Ray(new Tuple(0,0,-5f,1), new Tuple(0,0,1,0));
            Tuple colour = World.ColourAt(w,r);
            Console.WriteLine(colour);*/

             /*World w = new World();
             Sphere outer = w.SceneObjects[0]; 
             outer.Material.Ambient = 1;
             Sphere inner = w.SceneObjects[1]; 
             inner.Material.Ambient = 1;
             Ray r = new Ray(new Tuple(0,0,0.75f,1), new Tuple(0,0,-1,0));
             Tuple colour = World.ColourAt(w,r);
             Console.WriteLine(colour);
             Console.WriteLine(inner.Material.Colour);*/


             /*Tuple from = new Tuple(0,0,0,1);
             Tuple to = new Tuple(0,0,-1,1);
             Tuple up = new Tuple(0,1,0,0);
             ViewMatrix view = new ViewMatrix(from,to,up);
             Console.WriteLine(view.floatMatrix.ToString());
             Console.WriteLine(view.ToString());*/

            /*Tuple from = new Tuple(0,0,0,1);
             Tuple to = new Tuple(0,0,1,1);
             Tuple up = new Tuple(0,1,0,0);

             ViewMatrix view = new ViewMatrix(from,to,up);
             Console.WriteLine(view);
             Console.WriteLine(new ScaleMatrix(-1,1,-1));*/

             /*Tuple from = new Tuple(0,0,8,1);
             Tuple to = new Tuple(0,0,0,1);
             Tuple up = new Tuple(0,1,0,0);
             ViewMatrix view = new ViewMatrix(from,to,up);
             Console.WriteLine(view);
             Console.WriteLine(new TranslationMatrix(0,0,-8));*/

             /*Tuple from = new Tuple(1,3,2,1);
             Tuple to = new Tuple(4,-2,8,1);
             Tuple up = new Tuple(1,1,0,0);
             ViewMatrix view = new ViewMatrix(from,to,up);
             Console.WriteLine(view); */

            /* Camera c = new Camera(200,125,MathF.PI/2);
             Console.WriteLine(c.PixelSize);
              Console.WriteLine(c.Transform);*/

             /* Camera c = new Camera(201,101,MathF.PI/2);
              c.Transform = new RotationMatrix_Y(MathF.PI/4) * new TranslationMatrix(0,-2,5);
              Ray r = c.RayForPixel(100,50);
              Console.WriteLine(r.Origin);
              Console.WriteLine(r.Direction); */

/*              Sphere floor = new Sphere();
              floor.Transform = new ScaleMatrix(10,0.01f,10);
              floor.Material.Colour = new Tuple(1,0.9f,0.9f);
              floor.Material.Specular = 0;

              Sphere leftWall = new Sphere();
              leftWall.Transform = new TranslationMatrix(0,0,5)
                * new RotationMatrix_Y (-(MathF.PI)/4)
                * new RotationMatrix_X(MathF.PI/2)
                * new ScaleMatrix(10,0.01f,10);
              leftWall.Material.Colour = new Tuple(1,0.9f,0.9f);
              leftWall.Material.Specular = 0;

              Sphere rightWall = new Sphere();
              rightWall.Transform = new TranslationMatrix(0,0,5)
                * new RotationMatrix_Y ((MathF.PI)/4)
                * new RotationMatrix_X(MathF.PI/2)
                * new ScaleMatrix(10,0.01f,10);
              rightWall.Material.Colour = new Tuple(1,0.9f,0.9f);
              rightWall.Material.Specular = 0;

              Sphere middle = new Sphere();
              middle.Transform = new TranslationMatrix(-0.5f,1,0.5f);
              middle.Material.Colour = new Tuple(0.1f,1f,0.5f);
              middle.Material.Diffuse = 0.7f;
              middle.Material.Specular = 0.3f;

              Sphere right = new Sphere();
              right.Transform = new TranslationMatrix(1.5f,0.5f,-0.5f) * new ScaleMatrix(0.5f,0.5f,0.5f);
              right.Material.Colour = new Tuple(0.5f,1f,0.1f);
              right.Material.Diffuse = 0.7f;
              right.Material.Specular = 0.3f;

              Sphere left = new Sphere();
              left.Transform = new TranslationMatrix(-1.5f,0.33f,-0.75f) * new ScaleMatrix(0.33f,0.33f,0.33f);
              left.Material.Colour = new Tuple(1f,0.8f,0.1f);
              left.Material.Diffuse = 0.7f;
              left.Material.Specular = 0.3f;


              Sphere[] WorldObjects = {floor, leftWall,rightWall,left,middle,right};
              PointLight light = new PointLight(new Tuple(-10,10,-10,1), new Tuple(1,1,1,0));
              World world = new World(light,WorldObjects);
              Camera camera = new Camera(800,600,MathF.PI/3);
              camera.Transform = new ViewMatrix(new Tuple(0,1.5f,-5,1),new Tuple(0,1,0,1), new Tuple(0,1,0,0));

              Canvas image = camera.Render(world);

              image.saveCanvasToPPM("FirstScene.ppm");
              Console.WriteLine("done");*/
              /*Material m = new Material();
              Tuple position = new Tuple(0,0,0,1);
              Tuple eyev = new Tuple(0,0,-1,0);
              Tuple normalv = new Tuple(0,0,-1,0);
              PointLight light = new PointLight(new Tuple(0,0,-10,1),new Tuple (1,1,1,0));
              bool inShadow = true;

              Console.WriteLine(Material.Lighting(m,light,position,eyev,normalv,inShadow));*/

              /*World w = new World();
              Tuple p1 = new Tuple(0,10,0,1);
              Tuple p2 = new Tuple(10,-10,10,1);
              Tuple p3 = new Tuple(-20,20,-20,1);
              Tuple p4 = new Tuple(-2,20,-2,1);
              Console.WriteLine(World.IsShadowed(w,p1));
              Console.WriteLine(World.IsShadowed(w,p2));
              Console.WriteLine(World.IsShadowed(w,p3));
              Console.WriteLine(World.IsShadowed(w,p4));*/

              /*World w = new World();
              PointLight light = new PointLight(new Tuple(0,0,-10,1),new Tuple (1,1,1,0));
              TranslationMatrix m = new TranslationMatrix(0,0,10);
              w.SceneObjects[1].Transform =    m;
              Ray r = new Ray(new Tuple(0,0,5,1), new Tuple(0,0,1,0));
              Intersection i = new Intersection(4,w.SceneObjects[1]);
              Precomputation comps = Intersect.PrepareComputations(i,r);
              Tuple c = World.ShadeHit(w,comps);
              Console.WriteLine(w.SceneObjects[1].Material.Ambient);
              Console.WriteLine(c);*/
           /* Ray r = new Ray(new Tuple(0,0,-5,1), new Tuple(0,0,1,0));
            Sphere s = new Sphere();
            s.Transform = new TranslationMatrix(0,0,1);
            Intersection i = new Intersection(5,s);
            Precomputation comps = Intersect.PrepareComputations(i,r);
            Console.WriteLine(comps.OverPoint.z + " < " +  -Arithmetic.EPSILON/2);
            Console.WriteLine(comps.Point.z + " > " + comps.OverPoint.z);*/









             

              /*Sphere floor = new Sphere();
              floor.Transform = new ScaleMatrix(10,0.01f,10);
              floor.Material.Colour = new Tuple(1,0.9f,0.9f);
              floor.Material.Specular = 0;

              Sphere leftWall = new Sphere();
              leftWall.Transform = new TranslationMatrix(0,0,5)
                * new RotationMatrix_Y (-(MathF.PI)/4)
                * new RotationMatrix_X(MathF.PI/2)
                * new ScaleMatrix(10,0.01f,10);
              leftWall.Material.Colour = new Tuple(1,0.9f,0.9f);
              leftWall.Material.Specular = 0;

              Sphere rightWall = new Sphere();
              rightWall.Transform = new TranslationMatrix(0,0,5)
                * new RotationMatrix_Y ((MathF.PI)/4)
                * new RotationMatrix_X(MathF.PI/2)
                * new ScaleMatrix(10,0.01f,10);
              rightWall.Material.Colour = new Tuple(1,0.9f,0.9f);
              rightWall.Material.Specular = 0;*/

              /* Shape p = new Plane();
               p.Material.Colour = new Tuple(1.0f,0f,0.0f);
               p.Material.Diffuse = 0.7f;
               p.Material.Specular = 0.3f;
               p.Material.Pattern = new CheckersPattern(new Tuple(0.1f,0.9f,0.2f,0),new Tuple(0.1f,0,0.8f,0));
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
             // middle.Material.Pattern = new testPattern(new Tuple(1,1,1,0),new Tuple(0,0,0,0));

              Sphere right = new Sphere();
              right.Transform = new TranslationMatrix(1.5f,0.5f,-0.5f) * new ScaleMatrix(0.5f,0.5f,0.5f);
              right.Material.Colour = new Tuple(0.5f,1f,0.1f);
              right.Material.Diffuse = 0.7f;
              right.Material.Specular = 0.3f;
              right.Material.Pattern = new CheckersPattern(new Tuple(0.1f,0.9f,0.2f,0),new Tuple(0.1f,0,0.8f,0));
              right.Material.Pattern.Transform = new ScaleMatrix(0.2f,0.2f,0.2f);

              Sphere left = new Sphere();
              left.Transform = new TranslationMatrix(-1.5f,0.33f,-0.75f) * new ScaleMatrix(0.33f,0.33f,0.33f);
              left.Material.Colour = new Tuple(1f,0.8f,0.1f);
              left.Material.Diffuse = 0.7f;
              left.Material.Specular = 0.3f;
             // left.Material.Pattern = new testPattern(new Tuple(1,0,0.9f,0),new Tuple(0.5f,0,1,0));


              Shape[] WorldObjects = {p,left,middle,right};
              PointLight light = new PointLight(new Tuple(-10,10,-10,1), new Tuple(1,1,1,0));
              World world = new World(light,WorldObjects);
              Camera camera = new Camera(720,480,MathF.PI/3);
              camera.Transform = new ViewMatrix(new Tuple(0,1.5f,-5,1),new Tuple(0,1,0,1), new Tuple(0,1,0,0));

              Canvas image = camera.Render(world);

              image.saveCanvasToPPM("FourthScene.ppm");
              Console.WriteLine("done"); */

              /*Shape s = new TestShape();
              Ray r = new Ray(new Tuple(0,0,-5,1), new Tuple(0,0,1,0));
              s.Transform = new TranslationMatrix(5,0,0);
              Intersection[] xs = Intersect.IntersectShape(s,r);
              Console.WriteLine(s.LocalRay.Origin);
              Console.WriteLine(s.LocalRay.Direction);
              Console.WriteLine("done");*/

              /*Shape s = new TestShape();
              s.Transform = new TranslationMatrix(0,1,0);
              Console.WriteLine(Shape.NormalAt(s,new Tuple(0,1.70711f,-0.70711f,1)));*/

              /*Shape s = new TestShape();
              s.Transform = new ScaleMatrix(1,0.5f,1) * new RotationMatrix_Z(MathF.PI/5);
              Console.WriteLine(Shape.NormalAt(s,new Tuple(0,MathF.Sqrt(2)/2,-MathF.Sqrt(2)/2,1)));
              
              
              Console.WriteLine("done");*/

               /* Shape p = new Plane();
               /* Console.WriteLine(p.LocalNormalAt(new Tuple(0,0,0,1)));
                Console.WriteLine(p.LocalNormalAt(new Tuple(10,0,-10,1)));
                Console.WriteLine(p.LocalNormalAt(new Tuple(-5,0,150,1)));

                Ray r = new Ray(new Tuple(0,1,0,1),new Tuple(0,-1,0,0));
                Intersection [] i = p.LocalIntersect(r);
                Console.WriteLine(i.Length);
                Console.WriteLine(i[0].T_Value);
                Console.WriteLine(i[0].Object.Id);*/

                /*StripedPattern p = new StripedPattern(new Tuple(1,1,1,0),new Tuple(0,0,0,0));
                Console.WriteLine(p.StripeAt(new Tuple(0,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(0,1,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(0,2,0,1)));

                Console.WriteLine(p.StripeAt(new Tuple(0,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(0,0,1,1)));
                Console.WriteLine(p.StripeAt(new Tuple(0,0,2,1)));

                Console.WriteLine(p.StripeAt(new Tuple(0,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(0.9f,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(1,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(-0.1f,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(-1,0,0,1)));
                Console.WriteLine(p.StripeAt(new Tuple(-1.1f,0,0,1)));*/

                /*Material m = new Material();
                m.Pattern = new StripedPattern(new Tuple(1,1,1,0),new Tuple(0,0,0,0));
                m.Ambient = 1;
                m.Diffuse = 0;
                m.Specular =0;
                Tuple eyev = new Tuple(0,0,-1,0);
                Tuple normalv= new Tuple(0,0,-1,0);
                PointLight light = new PointLight(new Tuple(0,0,-10,1), new Tuple(1,1,1,0));
                Console.WriteLine(Material.Lighting(m,light,new Tuple(0.9f,0,0,1),eyev,normalv,false));
                Console.WriteLine(Material.Lighting(m,light,new Tuple(1.1f,0,0,1),eyev,normalv,false));*/

                /*Pattern p = new GradientPattern(new Tuple(1,1,1,0),new Tuple(0,0,0,0));
                Console.WriteLine(p.PatternAt(new Tuple(0,0,0,1)));
                Console.WriteLine(p.PatternAt(new Tuple(0.25f,0,0,1)));
                Console.WriteLine(p.PatternAt(new Tuple(0.5f,0,0,1)));
                Console.WriteLine(p.PatternAt(new Tuple(0.75f,0,0,1)));*/

                /* Shape shape = new Plane();
                Ray r = new Ray(new Tuple(0,1,-1,1), new Tuple(0,-(MathF.Sqrt(2)/2),(MathF.Sqrt(2)/2),0));
                Intersection i = new Intersection(MathF.Sqrt(2),shape);
                Precomputation comps = Intersect.PrepareComputations(i,r);
                Console.WriteLine(comps.ReflectVector);*/

                /*World w = new World();
                Ray r = new Ray(new Tuple(0,0,0,1), new Tuple(0,0,1,0));
                Shape shape = w.SceneObjects[1];
                shape.Material.Ambient = 1;
                Intersection i = new Intersection(1,shape);
                Precomputation comps = Intersect.PrepareComputations(i,r);
                Tuple colour = w.ReflectedColor(comps);
                Console.WriteLine(colour);*/

                /*World w = new World();
                Shape shape = new Plane();
                shape.Material.Reflective = 0.5f;
                shape.Transform = new TranslationMatrix(0,-1,0);
                w.AddShapeToScene(shape);
                Ray r = new Ray(new Tuple(0,0,-3,1), new Tuple(0,-(MathF.Sqrt(2)/2),(MathF.Sqrt(2)/2),0));
                Intersection i = new Intersection(MathF.Sqrt(2),shape);
                Precomputation comps = Intersect.PrepareComputations(i,r);
                Tuple colour = w.ReflectedColor(comps);
                Console.WriteLine(colour);*/

                /*World w = new World();
                Shape shape = new Plane();
                shape.Material.Reflective = 0.5f;
                shape.Transform = new TranslationMatrix(0,-1,0);
                w.AddShapeToScene(shape);
                Ray r = new Ray(new Tuple(0,0,-3,1), new Tuple(0,-(MathF.Sqrt(2)/2),(MathF.Sqrt(2)/2),0));
                Intersection i = new Intersection(MathF.Sqrt(2),shape);
                Precomputation comps = Intersect.PrepareComputations(i,r);
                Tuple colour = World.ShadeHit(w,comps);
                Console.WriteLine(colour);*/


                /*World w = new World(new PointLight(new Tuple(0,0,0,1), new Tuple(1,1,1,0)));
                Plane lower = new Plane();
                lower.Material.Reflective = 1;
                lower.Transform = new TranslationMatrix(0,-1,0);
                Plane upper = new Plane();
                upper.Material.Reflective = 1;
                upper.Transform = new TranslationMatrix(0,1,0);
                w.AddShapeToScene(upper,lower);
                Ray r = new Ray(new Tuple(0,0,0,1), new Tuple(0,1,0,0));
                Console.WriteLine(World.ColourAt(w,r,w.ReflectionDepth));*/

                /*World w = new World();
                Shape shape = new Plane();
                shape.Material.Reflective = 0.5f;
                shape.Transform = new TranslationMatrix(0,-1,0);
                w.AddShapeToScene(shape);
                Ray r = new Ray(new Tuple(0,0,-3,1), new Tuple(0,-(MathF.Sqrt(2)/2),(MathF.Sqrt(2)/2),0));
                Intersection i = new Intersection(MathF.Sqrt(2),shape);
                Precomputation comps = Intersect.PrepareComputations(i,r);
                Tuple colour = World.ShadeHit(w,comps,0);
                Console.WriteLine(colour);*/


                /*Sphere A = Sphere.GlassSphere();
                A.Transform = new ScaleMatrix(2,2,2);
                A.Material.Refractive_index = 1.5f;

                Sphere B = Sphere.GlassSphere();
                B.Transform = new TranslationMatrix(0,0,-0.25f);
                B.Material.Refractive_index = 2f;

                Sphere C = Sphere.GlassSphere();
                C.Transform = new TranslationMatrix(0,0,0.25f);
                C.Material.Refractive_index = 2.5f;

                Ray r = new Ray(new Tuple(0,0,-4f,1),new Tuple(0,0,1,0));

                
                Intersection[] xs = Intersect.Intersections(new Intersection(2,A),new Intersection(2.75f,B),new Intersection(3.25f,C),new Intersection(4.75f,B),new Intersection(5.25f,C),new Intersection(6,A));

                for(int i = 0; i < 7; i ++){
                Precomputation comps = Intersect.PrepareComputations(xs[i],r,xs);
                Console.Write(comps.n1 + " ");
                Console.Write(comps.n2);
                Console.WriteLine("");
                }*/

               /*Ray r = new Ray(new Tuple(0,0,-5f,1),new Tuple(0,0,1,0));
               Sphere C = Sphere.GlassSphere();
               C.Transform = new TranslationMatrix(0,0,1f);
               Intersection i = new Intersection(5,C);
               Intersection[] xs = Intersect.Intersections(i);
               Precomputation comps = Intersect.PrepareComputations(i,r,xs);
                 Console.WriteLine(comps.UnderPoint.z + " > " + Arithmetic.EPSILON/2);
                 Console.WriteLine(comps.Point.z + " < " + comps.UnderPoint.z);*/

                /* World w = new World();
                 w.SceneObjects[0].Material.Transparency = 1.0f;
                 w.SceneObjects[0].Material.Refractive_index = 1.5f;
                 Ray r = new Ray(new Tuple(0,0,-5f,1),new Tuple(0,0,1,0));
                 Intersection[] xs = Intersect.Intersections(new Intersection(4f,w.SceneObjects[0]),new Intersection(6f,w.SceneObjects[0]));
                Precomputation comps = Intersect.PrepareComputations(xs[0],r,xs);
                Tuple colour = World.RefractedColor(w,comps,0);
                Console.WriteLine(colour);*/


                 /*World w = new World();
                 w.SceneObjects[0].Material.Transparency = 1.0f;
                 w.SceneObjects[0].Material.Refractive_index = 1.5f;
                 Ray r = new Ray(new Tuple(0,0,MathF.Sqrt(2)/2,1),new Tuple(0,1,0,0));
                Intersection[] xs = Intersect.Intersections(new Intersection((-MathF.Sqrt(2)/2),w.SceneObjects[0]),new Intersection(MathF.Sqrt(2)/2,w.SceneObjects[0]));
                 Precomputation comps = Intersect.PrepareComputations(xs[1],r,xs);
                 Tuple colour = World.RefractedColor(w,comps,5);
                Console.WriteLine(colour);*/

             /*   World w = new World();
                w.SceneObjects[0].Material.Transparency = 1.0f;
                w.SceneObjects[0].Material.Pattern = new testPattern();
                w.SceneObjects[1].Material.Transparency = 1.0f;
                w.SceneObjects[1].Material.Refractive_index = 1.5f;
                Ray r = new Ray(new Tuple(0,0,0.1f,1),new Tuple(0,1,0,0));
                Intersection[] xs = Intersect.Intersections(new Intersection(-0.9899f,w.SceneObjects[0]),new Intersection(-0.4899f,w.SceneObjects[1]),new Intersection(0.4899f,w.SceneObjects[1]),new Intersection(0.9899f,w.SceneObjects[0]));
                Precomputation comps = Intersect.PrepareComputations(xs[2],r,xs);
                 Tuple colour = World.RefractedColor(w,comps,5);
                 Console.WriteLine(colour);*/

                /*World w = new World();
                Plane floor = new Plane();
                floor.Transform = new TranslationMatrix(0,-1,0);
                floor.Material.Transparency = 0.5f;
                floor.Material.Refractive_index = 1.5f;
                w.AddShapeToScene(floor);

                Sphere ball = new Sphere();
                ball.Material.Colour = new Tuple(1,0,0);
                ball.Material.Ambient = 0.5f;
                ball.Transform = new TranslationMatrix(0,-3.5f,-0.5f);
                w.AddShapeToScene(ball);
                Ray r = new Ray(new Tuple(0,0,-3f,1),new Tuple(0,-MathF.Sqrt(2)/2 ,MathF.Sqrt(2)/2,0));
                Intersection[] xs = Intersect.Intersections(new Intersection(MathF.Sqrt(2),floor));
                Precomputation comps = Intersect.PrepareComputations(xs[0],r,xs);
                Tuple colour = World.ShadeHit(w,comps,5);
                Console.WriteLine(colour);*/

                /*Shape A = Sphere.GlassSphere();
                Ray r = new Ray(new Tuple(0,0,MathF.Sqrt(2)/2,1),new Tuple(0,1,0));
                Intersection[] xs = Intersect.Intersections(new Intersection(-MathF.Sqrt(2)/2,A),new Intersection(MathF.Sqrt(2)/2,A));
                Precomputation comps = Intersect.PrepareComputations(xs[1],r,xs);
                float reflectance = World.Schlick(comps);
                Console.WriteLine(reflectance);*/

                /*Shape A = Sphere.GlassSphere();
                Ray r = new Ray(new Tuple(0,0,0,1),new Tuple(0,1,0));
                Intersection[] xs = Intersect.Intersections(new Intersection(-1,A),new Intersection(1,A));
                Precomputation comps = Intersect.PrepareComputations(xs[1],r,xs);
                float reflectance = World.Schlick(comps);
                Console.WriteLine(reflectance);

                Shape b = Sphere.GlassSphere();
                Ray r2 = new Ray(new Tuple(0,0.99f,-2,1),new Tuple(0,0,1));
                Intersection[] xs1 = Intersect.Intersections(new Intersection(1.8589f,b));
                Precomputation comps1 = Intersect.PrepareComputations(xs1[0],r2,xs1);
                float reflectance1 = World.Schlick(comps1);
                Console.WriteLine(reflectance1);*/


                /*World w = new World();
                Ray r = new Ray(new Tuple(0,0,-3f,1),new Tuple(0,-MathF.Sqrt(2)/2 ,MathF.Sqrt(2)/2,0));

                Plane floor = new Plane();
                floor.Transform = new TranslationMatrix(0,-1,0);
                floor.Material.Reflective = 0.5f;
                floor.Material.Transparency = 0.5f;
                floor.Material.Refractive_index = 1.5f;
                w.AddShapeToScene(floor);

                Sphere ball = new Sphere();
                ball.Material.Colour = new Tuple(1,0,0);
                ball.Material.Ambient = 0.5f;
                ball.Transform = new TranslationMatrix(0,-3.5f,-0.5f);
                w.AddShapeToScene(ball);
    
                Intersection[] xs = Intersect.Intersections(new Intersection(MathF.Sqrt(2),floor));
                Precomputation comps = Intersect.PrepareComputations(xs[0],r,xs);
                Tuple colour = World.ShadeHit(w,comps,5);
                Console.WriteLine(colour);*/


                /* Cube c = new Cube();
                Ray r = new Ray(new Tuple(0,0.5f,0,1),new Tuple(0,0,1,0));
                Intersection[] xs = c.LocalIntersect(r);
                Console.WriteLine(xs.Length);
                Console.WriteLine(xs[0].T_Value);
                Console.WriteLine(xs[1].T_Value);*/
                /*Cube c = new Cube();
                Tuple point = new Tuple(-1f,-1f,-1f,1);
                Tuple normal = c.LocalNormalAt(point);
                Console.WriteLine(normal);*/










                Console.WriteLine("End Tests");
 
        
        }

    }
}
