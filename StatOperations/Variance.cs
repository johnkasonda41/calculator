﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace StatOperations
{
    public class Variance
    {

        
       
        public static dynamic Variances(dynamic arrayA, int mean)
        {
            int arraylen = Helpers.Array.ArrayLength(arrayA);
            //Array subarray = new Array(arraylen);
            int[] vArray = new int[arraylen];

            dynamic diffvalue;
            double addedSquares = 0.0;
            int i = 0;
            double vValue = 0.0;
            foreach (int b in arrayA)
            {
                diffvalue = operations.Subtraction.Difference(b, mean);
                vArray[i] = diffvalue;
                //squaredValue = vValue[i];
                vArray[i] = operations.Squaring.Square(vArray[i]);
                addedSquares = addedSquares + vArray[i];

                i++;                                          
            }

            vValue = Helpers.Rounding.RoundTwoDecimalPlaces(operations.Division.Divide(addedSquares, arraylen));
            return vValue;
        }
    }
}
