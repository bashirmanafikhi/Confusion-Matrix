using System;
using System.Collections.Generic;
using System.Text;

namespace Confusion_Matrix_Library
{
    public class BinaryConfusionMatrix
    {
        double tp, tn, fp, fn;

        public BinaryConfusionMatrix(double tp, double tn, double fp, double fn)
        {
            this.tp = tp;
            this.tn = tn;
            this.fp = fp;
            this.fn = fn;
        }





        // Sensitivity		TPR = TP / (TP + FN)
        public double Recall
        {
            get
            {
                double result = (tp) / (tp + fn);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // Specificity		SPC = TN / (FP + TN)
        public double Specificity
        {
            get
            {
                double result = (tn) / (tn + fp);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // Precision		PPV = TP / (TP + FP)
        public double Precision
        {
            get
            {
                double result = (tp) / (tp + fp);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // Negative Predictive Value		NPV = TN / (TN + FN)
        public double NegativePredictiveValue
        {
            get
            {
                double result = (tn) / (tn + fn);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // False Positive Rate		FPR = FP / (FP + TN)
        public double FalsePositiveRate
        {
            get
            {
                double result = (fp) / (fp + tn);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // False Discovery Rate		FDR = FP / (FP + TP)
        public double FalseDiscoveryRate
        {
            get
            {
                double result = (fp) / (fp + tp);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // False Negative Rate		FNR = FN / (FN + TP)
        public double FalseNegativeRate
        {
            get
            {
                double result = (fn) / (fn + tp);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // Accuracy		ACC = (TP + TN) / (P + N)
        public double Accuracy
        {
            get
            {
                double result = (tp + tn) / (tp + fp + tn + fn);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // F1 Score		F1 = 2TP / (2TP + FP + FN)
        public double F1Score
        {
            get
            {
                double result = 2 * Precision * Recall / (Precision + Recall);
                //result = (2*tp) / (2*tp + fp + fn);  this is another formula from the internet



                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }

        // Error Rate
        public double ErrorRate
        {
            get
            {
                double result = (fp + fn) / (tp + fp + tn + fn);

                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;

                return result;
            }
        }
    }
}
