using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace StatOperations
{
    public class Variance
    {

        
        public static dynamic Variances(dynamic onevalue, int mean)
        {
            
            return operations.Subtraction.Difference(onevalue, mean);
           
        }
        public static ArrayList Variances(int[] arrayA, int mean)
        {
            ArrayList subarray = new ArrayList();
            dynamic diffvalue;
            /*           

            subarray.Add(577);
            subarray.Add(286);*/

            foreach (int b in arrayA)
            {
                diffvalue = Variances(b, mean);
                subarray.Add(diffvalue);

            }

            return subarray;
        }
    }
}
