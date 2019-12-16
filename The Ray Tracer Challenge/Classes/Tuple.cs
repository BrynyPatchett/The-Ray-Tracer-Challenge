using System;

namespace The_Ray_Tracer_Challenge
{
    ///Tuple is used to represent Vectors,Points and Colours
    public class Tuple
    {

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public float w { get; set; }

        public Tuple() { }
        ///<summary>
        //This Tuple Class can be used to represent a Vector(w: 0), a Point (w:1) or colours (ignoring w:0 component)
        ///</summary>
        public Tuple(float X, float Y, float Z, float W)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
        public Tuple(float X, float Y, float Z)
        {
            x = X;
            y = Y;
            z = Z;
            w = 0;
        }
        public Tuple(ThreeVector v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
            w = 0;
        }
        public Tuple(Point p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
            w = 1;
        }

        public float Red
        {
            get => x;
            set => x = value;
        }

        public float Green
        {
            get => y;
            set => y = value;
        }

        public float Blue
        {
            get => z;
            set => z = value;
        }



        ///<summary>
        ///Overload of + which adds two tuples together
        ///</summary>

        public static Tuple operator +(Tuple a, Tuple b)
        {
            if (a.w == 1.0f && b.w == 1.0f)
            {
                throw new System.ArgumentException("Attempting to add point a to b", "a");
            }
            //Just in case
            /*if(a.w == 1.0f || b.w == 1.0f){
                return new Tuple(a.x+b.x,a.y+b.y,a.z+b.z,1.0f);
            }*/
            return new Tuple(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }

        ///<summary>
        ///Adds two tuples together
        ///</summary>

        public static Tuple addTuples(Tuple a, Tuple b)
        {

            if (a.w == 1.0f && b.w == 1.0f)
            {
                throw new System.ArgumentException("Attempting to add point a to b", "a");
            }
            //Just in case
            /*if(a.w == 1.0f || b.w == 1.0f){
                return new Tuple(a.x+b.x,a.y+b.y,a.z+b.z,1.0f);
            }*/


            return new Tuple(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }

        ///<summary>
        ///Overload of - which subtracts two tuples 
        ///</summary>
        public static Tuple operator -(Tuple a, Tuple b)
        {


            if (a.w == 0.0f && b.w == 1.0f)
            {
                throw new System.ArgumentException("Attempting to subtract point from a vector", "a");
            }

            return new Tuple(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }

        ///<summary>
        ///subtracts two tuples 
        ///</summary>

        public static Tuple subtractTuples(Tuple a, Tuple b)
        {


            if (a.w == 0.0f && b.w == 1.0f)
            {
                throw new System.ArgumentException("Attempting to subtract point from a vector", "a");
            }

            return new Tuple(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }
        ///<summary>
        ///Negation Operator 
        ///</summary>
        public static Tuple operator -(Tuple a)
        {
            return new Tuple(-a.x, -a.y, -a.z, -a.w);
        }
        ///<summary>
        ///Multiplication Operator 
        ///</summary>
        public static Tuple operator *(Tuple a, float scalar)
        {
            return new Tuple(a.x * scalar, a.y * scalar, a.z * scalar, a.w * scalar);
        }
        ///<summary>
        ///Multiplay a Tuple by a scalar value 
        ///</summary>
        public static Tuple scaleTuple(Tuple a, float scalar)
        {
            return new Tuple(a.x * scalar, a.y * scalar, a.z * scalar, a.w * scalar);
        }
        ///<summary>
        ///Division Operator 
        ///</summary>
        public static Tuple operator /(Tuple a, float scalar)
        {
            return new Tuple(a.x / scalar, a.y / scalar, a.z / scalar, a.w / scalar);
        }
        ///<summary>
        ///Divide a Tuple by a scalar value 
        ///</summary>
        public static Tuple divideTuple(Tuple a, float scalar)
        {
            return new Tuple(a.x / scalar, a.y / scalar, a.z / scalar, a.w / scalar);
        }

        ///<summary>
        ///Return the magnitude of a supplied tuple
        ///</summary>
        public static float Magnitude(Tuple a)
        {
            float mag = MathF.Sqrt((a.x + a.x) + (a.y * a.y) + (a.z * a.z));
            return mag;
        }
        ///<summary>
        ///Return the magnitude of a tuple instance
        ///</summary>
        public float Magnitude()
        {
            float mag = MathF.Sqrt((x * x) + (y * y) + (z * z));
            return mag;
        }

        public static Tuple Normalise(Tuple a)
        {

            float mag = Magnitude(a);
            return new Tuple(a.x / mag, a.y / mag, a.z / mag, a.w / mag);

        }
        ///<summary>
        ///Return the normalise magniture of a tuple instance
        ///</summary>
        public Tuple Normalise()
        {
            float mag = Magnitude();
            x = x / mag;
            y = y / mag;
            z = z / mag;
            w = w / mag;
            return this;
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ", " + w + ")";
        }


        public static float Dot(Tuple a, Tuple b)
        {

            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);

        }
        public float Dot(Tuple a)
        {

            return (a.x * x) + (a.y * y) + (a.z * z) + (a.w * w);

        }
        public static Tuple Cross(Tuple a, Tuple b)
        {

            return new Tuple(
            (a.y * b.z) - (a.z * b.y),
            (a.z * b.x) - (a.x * b.z),
            (a.x * b.y) - (a.y * b.x));

        }
        public Tuple Cross(Tuple a)
        {
            float tempX = x;
            float tempY = y;
            float tempZ = z;
            x = tempY * a.z - tempZ * a.y;
            y = tempZ * a.x - tempX * a.z;
            z = tempX * a.y - tempY * a.x;
            return this;
        }
        ///<summary>
        ///Multiply Two Tuples together, is used for colour operations
        ///</summary>
        public static Tuple operator *(Tuple a, Tuple b)
        {
            return new Tuple(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        ///<summary>
        ///Multiply Two Tuples together, is used for colour operations
        ///</summary>
        public void MultiplyTuple(Tuple a)
        {
            x = a.x * x;
            y = a.y * y;
            z = a.z * z;
        }




    }
}
