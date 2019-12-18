using System;

namespace The_Ray_Tracer_Challenge
{
    public class Matrix
    {

        public float[,] floatMatrix { get; set; }
        public int RowNumber { get; protected set; }
        public int ColNumber { get; protected set; }
        public Matrix() { }

        public Matrix(int rowNumber, int colNumber)
        {
            floatMatrix = new float[rowNumber, colNumber];
            RowNumber = rowNumber;
            ColNumber = colNumber;

        }
        public Matrix(float[,] matrixFromArray)
        {

            RowNumber = matrixFromArray.GetLength(0);
            ColNumber = matrixFromArray.GetLength(1);
            floatMatrix = new float[RowNumber, ColNumber];
            for (int r = 0; r < RowNumber; r++)
            {
                for (int c = 0; c < ColNumber; c++)
                {
                    floatMatrix[r, c] = matrixFromArray[r, c];
                }
            }



        }

        public override string ToString()
        {
            String toDisplay = "";
            //Go Across Rows
            for (int r = 0; r < RowNumber; r++)
            {
                toDisplay += " | ";
                //Go Across Coloumns
                for (int c = 0; c < ColNumber; c++)
                {

                    toDisplay += floatMatrix[r, c] + " | ";

                }
                toDisplay += "\n";

            }

            return toDisplay;
        }

        public static bool compareMatrix(Matrix a, Matrix b)
        {
            if (a.ColNumber != b.ColNumber || a.RowNumber != b.RowNumber)
            {
                return false;
            }

            for (int r = 0; r < a.RowNumber; r++)
            {
                for (int c = 0; c < a.ColNumber; c++)
                {
                    if (!(Arithmetic.compareTwoFloats(a.floatMatrix[r, c], b.floatMatrix[r, c])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool compareMatrix(Matrix a)
        {
            if (a.ColNumber != ColNumber || a.RowNumber != RowNumber)
            {
                return false;
            }

            for (int r = 0; r < RowNumber; r++)
            {
                for (int c = 0; c < ColNumber; c++)
                {
                    if (!(Arithmetic.compareTwoFloats(a.floatMatrix[r, c], floatMatrix[r, c])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }



        ///<summary>
        ///Used to multiple a 4x4 matrix, behavour is currently undefined for multipling by less than that
        ///</summary>
        public static Matrix Multiply(Matrix a, Matrix b)
        {

            Matrix m = a * b;
            return m;
        }
        ///<summary>
        ///Used to multiple a 4x4 matrix, behavour is currently undefined for multipling by less than that
        ///</summary>
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix m = new Matrix(4, 4);
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    m.floatMatrix[r, c] = (a.floatMatrix[r, 0] * b.floatMatrix[0, c]) +
                                         (a.floatMatrix[r, 1] * b.floatMatrix[1, c]) +
                                         (a.floatMatrix[r, 2] * b.floatMatrix[2, c]) +
                                         (a.floatMatrix[r, 3] * b.floatMatrix[3, c]);
                }
            }

            return m;
        }

        public static Tuple operator *(Matrix a, Tuple b)
        {
            Tuple t = new Tuple();


            t.x = (a.floatMatrix[0, 0] * b.x) + (a.floatMatrix[0, 1] * b.y) + (a.floatMatrix[0, 2] * b.z) + (a.floatMatrix[0, 3] * b.w);
            t.y = (a.floatMatrix[1, 0] * b.x) + (a.floatMatrix[1, 1] * b.y) + (a.floatMatrix[1, 2] * b.z) + (a.floatMatrix[1, 3] * b.w);
            t.z = (a.floatMatrix[2, 0] * b.x) + (a.floatMatrix[2, 1] * b.y) + (a.floatMatrix[2, 2] * b.z) + (a.floatMatrix[2, 3] * b.w);
            t.w = (a.floatMatrix[3, 0] * b.x) + (a.floatMatrix[3, 1] * b.y) + (a.floatMatrix[3, 2] * b.z) + (a.floatMatrix[3, 3] * b.w);

            return t;



        }

        public static Tuple multiply(Matrix a, Tuple b)
        {
            Tuple t = new Tuple();

            t = a * b;


            return t;



        }


        public static Matrix Transpose(Matrix a)
        {

            return a.Transpose();
        }

        public Matrix Transpose()
        {
            Matrix m = new Matrix(RowNumber, ColNumber);


            for (int r = 0; r < RowNumber; r++)
            {
                for (int c = 0; c < ColNumber; c++)
                {
                    m.floatMatrix[c, r] = floatMatrix[r, c];
                }
            }



            return m;
        }
        ///<summary>
        ///Used to find the determinant of a 2x2 matrix, 
        ///</summary>
        public float Determinant()
        {
            if (RowNumber * ColNumber == 4)
            {
                return (floatMatrix[0, 0] * floatMatrix[1, 1]) - (floatMatrix[0, 1] * floatMatrix[1, 0]);
            }
            float det = 0;

            for (int c = 0; c < ColNumber; c++)
            {
                float temp = floatMatrix[0, c] * Cofactor(0, c);
                det = det + temp;

            }
            return det;



        }
        public static float Determinant(Matrix a)
        {

            return (a.Determinant());


        }
        ///<summary>
        ///Finds the submatrix of the matrix, by removing given row and coloumn
        ///</summary>
        public Matrix Submatrix(int row, int col)
        {
            //row and coloumn indexs for the new smaller matrix
            int rIgn = 0;
            int cIgn = 0;
            //new matrix
            Matrix m = new Matrix(RowNumber - 1, ColNumber - 1);
            //loop each row of the current array
            for (int r = 0; r < RowNumber; r++)
            {
                //if the row is equal to the row we wish to ignore, skip this iteration
                if (r == row)
                {
                    continue;
                }
                //if we want to keep this row loop over every coloum in this row
                for (int c = 0; c < ColNumber; c++)
                {
                    //if we want to ignore this coloum skip this iteration
                    if (c == col)
                    {
                        continue;
                    }
                    //if we havent skipped, then use the index of our current matrix to place in to our new submatrix
                    //use rIgn and cIgn to index into our new array that is smaller, it will either match or be smaller by one
                    m.floatMatrix[rIgn, cIgn] = floatMatrix[r, c];
                    //increment coloum index
                    cIgn++;
                }
                //reset coloumn index
                cIgn = 0;
                //increment row index
                rIgn++;
            }
            return m;

        }

        public static Matrix Submatrix(Matrix a, int row, int col)
        {


            return a.Submatrix(row, col);

        }

        public float Minor(int row, int col)
        {

            return Submatrix(row, col).Determinant();


        }
        public static float Minor(Matrix a, int row, int col)
        {

            return a.Submatrix(row, col).Determinant();

        }

        public float Cofactor(int row, int col)
        {
            if ((row + col) % 2 == 0)
            {
                return (Minor(row, col));
            }
            return -Minor(row, col);

        }

        public static float Cofactor(Matrix a, int row, int col)
        {
            if ((row + col) % 2 == 0)
            {
                return (a.Minor(row, col));
            }
            return -a.Minor(row, col);

        }

        public Matrix Inverse()
        {
            float determinant = Determinant();
            if (determinant == 0)
            {
                Console.WriteLine("FAIL: DETERMINANT IS ZERO, CANNOT FIND INVERSE MATRIX");
                return null;
                /*SHOULD RETURN NULL/ Original Matrix/ Crash ? */
            }
            Matrix m = new Matrix(RowNumber, ColNumber);
            for (int r = 0; r < RowNumber; r++)
            {
                for (int c = 0; c < ColNumber; c++)
                {
                    float cofac = Cofactor(r,c);
                    m.floatMatrix[c,r] = cofac/determinant;
                }
            }
            return m;

        }




    }
}
