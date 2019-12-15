using System;
using System.Text;

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
       public int[] pixelsInt;

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
       public Canvas(int width, int height, int flag){

           Width = width;
           Height = height;
           pixelsInt = new int[width * height];
           for(int y = 0; y < height; y++){
                for(int x = 0; x < width; x++){

                     pixelsInt[ y * Width + x] = 0;
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
        public static void writePixelToCanvas(Canvas canvas, int x, int y , int colour){

           int index = y * canvas.Width + x;
           canvas.pixelsInt[index] = colour;

       }

        public void SetPixelColour(int x, int y , int colour){

           int index = y * Width + x;
           pixelsInt[index] = colour;

       }


       public int GetPixelColour(int x, int y){

           int index = y * Width + x;
           return pixelsInt[index];

       }
        public static int GetPixelColour(Canvas c,int x, int y){

           int index = y * c.Width + x;
           return c.pixelsInt[index];

       }
        ///<summary>
        ///saves the Canvas to a PPM image format, will be changed later however PPM is simple enough for now
        ////
        ///</summary>
       public void saveCanvasToPPM(string filename){
           string header = "P3\n"; 
           string resInfo = Width + " " + Height + "\n";
           string maxColourValue = 255 + "\n";
           string current = "";

           int charOnLine = 0;

          StringBuilder stringBuilder = new StringBuilder();

          stringBuilder.Append(header);
          stringBuilder.Append(resInfo);
          stringBuilder.Append(maxColourValue);

           for(int x = 0; x < Width; x++){
                for(int y = 0; y < Height; y++){
                    
                    Tuple colourInfo = pixels[ y * Width + x];
                    string red = ((int)clampColor(colourInfo.Red * 255) + "");
                    string green =  ((int)clampColor(colourInfo.Green * 255) + "");
                    string blue =  ((int)clampColor(colourInfo.Blue * 255) + "");

                    current = (red + " " + green + " " + blue+ " ");
                     charOnLine += current.Length;

                     if(charOnLine >= 70){
                          stringBuilder.Append("\n");
                          charOnLine = 0 + current.Length;
                     }
                    stringBuilder.Append(current);
                }
           }
             stringBuilder.Append("\n");


            Console.WriteLine("Finished 3");
            System.IO.File.WriteAllText(filename, stringBuilder.ToString() ); 
            

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



       public int saveCanvasToPPMInts(string filename){
          string header = "P3\n"; 
          string resInfo = Width + " " + Height + "\n";
          string maxColourValue = 255 + "\n";
          int charOnLine = 0;
          string current = "";
          StringBuilder stringBuilder = new StringBuilder();

          stringBuilder.Append(header);
          stringBuilder.Append(resInfo);
          stringBuilder.Append(maxColourValue);



           for(int x = 0; x < Width; x++){
                for(int y = 0; y < Height; y++){
                    
                    int colour = pixelsInt[y * Width + x];

                    int red = (colour >> 16) & 0xFF;
                    int green = (colour >> 8) & 0xFF;
                    int blue = colour & 0xFF;
                     current = (red + " " + green + " " + blue+ " ");
                     charOnLine += current.Length;
                     if(charOnLine >= 70){
                         stringBuilder.Append("\n");
                         charOnLine = 0 + current.Length;
                     }
                   stringBuilder.Append(current);
                }
           }
             stringBuilder.Append("\n");

            System.IO.File.WriteAllText(filename, stringBuilder.ToString()); 
            //return all;
            Console.WriteLine("Finished 2");
            return charOnLine;
             
       }
        

    }
}
