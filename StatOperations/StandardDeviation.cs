using System;
using System.Collections.Generic;
using System.Text;
using Helpers;
using operations;

namespace StatOperations
{
    public class StandardDeviation
    {
        StatOperations statoperations = new StatOperations();
        public static dynamic StandardDev(dynamic values)
        {
            var mean = StatOperations.Mean(values);
            //var valueCount = Helpers.Array.ArrayLength(values);

            return mean; // to come and include the actual variable
        }

    }
}
