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
        ///<summary>
        ///saves the Canvas to a PPM image format, will be changed later however PPM is simple enough for now
        ////
        ///</summary>
       public string saveCanvasToPPM(string filename){
           string header = "P3\n"; 
           string resInfo = Width + " " + Height + "\n";
           string maxColourValue = 255 + "\n";
           string data = ""; 
           int charOnLine = 0;

           for(int x = 0; x < Width; x++){
                for(int y = 0; y < Height; y++){
                    Console.WriteLine(x + ", "+ y + " ");
                    Tuple colourInfo = this.GetPixelColour(x,y);
                    string r = ((int)clampColor(colourInfo.Red * 255) + "");
                    string g =  ((int)clampColor(colourInfo.Green * 255) + "");
                    string b =  ((int)clampColor(colourInfo.Blue * 255) + "");
                    string current = (r + " " + g + " " + b + " ");
                     charOnLine += current.Length;
                     if(charOnLine >= 70){
                          data += "\n";
                          charOnLine = 0 + current.Length;
                     }
                    data += current;
                }
           }
           data += "\n";


            string all = header + resInfo + maxColourValue + data;
            System.IO.File.WriteAllText(filename, all ); 
            return all;

       }
    ///<summary>
        ///Clamps a colour between 0  and 255
        ///</summary>
       public static float clampColor(float n){

           if(n > 255){
               return 255;
           }
           if(n < 0 ){
               return 0;
           }
           return n;

       }
        

    }
}
