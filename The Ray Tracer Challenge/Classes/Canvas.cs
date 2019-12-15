using System;

namespace The_Ray_Tracer_Challenge
{
    public class Canvas
    {
        ///<summary>
        ///Compares two floating point values for equality
        ///</summary>
       public int Width {get;set;}
       public int Height {get;set;}

       public Tuple[] pixels;

       public Canvas(int width, int height){

           Width = width;
           Height = height;
           pixels = new Tuple[width * height];
           for(int y = 0; y < height; y++){
                for(int x = 0; x < width; x++){
                    this.SetPixelColour(x,y,new Tuple(0,0,0));
                }
           }
       }
       public static void writePixelToCanvas(Canvas canvas, int x, int y , Tuple colour){

           int index = y * canvas.Width + x;
           canvas.pixels[index] = colour;

       }

       public void SetPixelColour(int x, int y , Tuple colour){

           int index = y * Width + x;
           pixels[index] = colour;

       }
       public Tuple GetPixelColour(int x, int y){

           int index = y * Width + x;
           return pixels[index];

       }
        public static Tuple GetPixelColour(Canvas c,int x, int y){

           int index = y * c.Width + x;
           return c.pixels[index];

       }
        

    }
}
