using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CryptoNotes.ML.Exceptions;

namespace CryptoNotes.ML
{
    class Linear_Regression
    {
        public Linear_Regression(double[] xVals, double[] yVals,
                                 int inclusiveStart, int exclusiveEnd,
                                 out double rsquared, out double yintercept,
                                 out double slope)
        {
            if(xVals.Length != yVals.Length)
            {
                // Well that a bit mad.
                throw new invalidMatrixException("xVals and yVals are different in size.");
            }

            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSquared = 0;
            double sumOfYSquared = 0;
            double ssX = 0;
            double ssY = 0;
            double sumOfCodeviates = 0;
            double sCo = 0;
            double count = exclusiveEnd - inclusiveStart;

            for (int ptr = inclusiveStart; ptr < exclusiveEnd; ptr++)
            {
                double currentX = xVals[ptr];
                double currentY = yVals[ptr];
                sumOfCodeviates += currentX * currentY;
                sumOfX += currentX;
                sumOfY += currentY;
                sumOfXSquared += currentX * currentX;
                sumOfYSquared += currentY * currentY;
            }

            ssX = sumOfXSquared - ((sumOfX * sumOfX) / count);
            ssY = sumOfYSquared - ((sumOfY * sumOfY) / count);
            double RNumerator = (count * sumOfCodeviates) - (sumOfX * sumOfY);
            double RDenom = (count * sumOfXSquared - (sumOfX * sumOfX)) * (count * sumOfYSquared - (sumOfY * sumOfY));
            sCo = sumOfCodeviates - ((sumOfX * sumOfY) / count);
            double meanX = sumOfX / count;
            double meanY = sumOfY / count;
            double dblR = RNumerator / Math.Sqrt(RDenom);
            rsquared = dblR * dblR;
            yintercept = meanY - ((sCo / ssX) * meanX);
            slope = sCo / ssX;

        }

    }
}
