﻿namespace Arrays
{
    internal class ArraysAndStrings
    {
        public int CountCharInString(string inputString, char inputChar)
        {
            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputChar == inputString[i])
                {
                    result++;
                }
            }

            return result;
        }

        public int NextPowerOfTwo(int currentNumber)
        {
            int result = 0;
            int sumatoria1 = 1;
            
            for (int i = 0; i < currentNumber; i++)
            {
                sumatoria1 = sumatoria1 * 2;
            }
            
            result = sumatoria1;
                return result;
        }

        public int FibonacciAtN(int fibonacciPositioon)
        {
            int result = 1;
            int control = 0;
            int prim = 1;
            int seg = 1;
            while (control < fibonacciPositioon)
            {
                if (control == 0) 
                {

                    result = 1;
                }
                else if (control == 1)
                {
                    result = 1;
                }
                else
                {
                    seg = prim;
                    prim = result;
                    result = seg + prim;
                }
            }


            return result;
        }

        public int MultiplesOfThreeInArray(int[] inputArr)
        {
            int result = 0;

            return result;
        }

        public bool NumberIsMultipleOf(int inputNum, int inputFactor)
        {
            bool result = false;

            return result;
        }

        public bool MatrixIsIdentity(int[,] inputMatrix)
        {
            bool result = false;

            return result;
        }

        public bool ElementsInDiagonalAreEqual(int[,] inputMatrix)
        {
            bool result = false;

            return result;
        }

        public int OperateElementsInArray(int[] inputArr)
        {
            int result = 0;

            return result;
        }

      

        public int CountVowelsInString(string inputString)
        {
            int result = 0;

          


            return result;
        }

        public int CountConsonantInString(string inputString)
        {
            int result = 0;

            return result;
        }

        public string StringHasOddOrEvenCharCount(string inputString)
        {
            string result = string.Empty;

            //TODO: Para indicar que el conteo es par, retornar "PAR"
            //Para indicar que el conteo es inpar, retornar "IMPAR"

            return result;
        }

        public string ProductOfElementsIsOddOrEven(int[] inputArr)
        {
            string result = string.Empty;
            
            //TODO: Para indicar que el conteo es par, retornar "PAR"
            //Para indicar que el conteo es inpar, retornar "IMPAR"

            return result;
        }

        public string RacerGotFirst(float d1, float t1, float d2, float t2)
        {
            string result = string.Empty;

            //TODO: Para indicar que el corredor más rápido es el primero, retornar "PRIMERO"
            //Para indicar que el corredor más rápido es el segundo, retornar "SEGUNDO"

            return result;
        }
    }
}