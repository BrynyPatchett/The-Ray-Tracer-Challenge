**The-Ray-Tracer-Challenge:**
As a means to practice programming and to learn C# along with .NET Core I will be attempting to implement a Ray Tracer described in the following book: https://pragprog.com/book/jbtracer/the-ray-tracer-challenge


**Chapter 2: Chapter Focused on creating a Canvas Object to enabling drawing.**

Result:
![Screenshot](Screenshots/CanvasArch.png)



The Program is currently not optimized, for even basic rendering.
Optimizations that can be made:

  Replace the Tuple Objects that is being used to represent colours with int primitivse and pack it with 8bits per colour channel. (Done)
  Use different file format so we do not have to convert all colours to a string.

  Update(15/12/2019): Replace basic string concatenation "string += string" with a string builder. Result: Exponential increase in writing the PPM file
  Combined with the new int to represent the pixels(which is optional as Tuple objects can still be used) it now takes significantly less time to create a file:
  Went from 10min to render and (900x500) image to 5 seconds for a (3840x2160), in both int and tuple mode.
