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
                return (tp) / (tp + fn);
            }
        }

        // Specificity		SPC = TN / (FP + TN)
        public double Specificity
        {
            get
            {
                return (tn) / (tn + fp);
            }
        }

        // Precision		PPV = TP / (TP + FP)
        public double Precision
        {
            get
            {
                return (tp) / (tp + fp);
            }
        }

        // Negative Predictive Value		NPV = TN / (TN + FN)
        public double NegativePredictiveValue
        {
            get
            {
                return (tn) / (tn + fn);
            }
        }

        // False Positive Rate		FPR = FP / (FP + TN)
        public double FalsePositiveRate
        {
            get
            {
                return (fp) / (fp + tn);
            }
        }

        // False Discovery Rate		FDR = FP / (FP + TP)
        public double FalseDiscoveryRate
        {
            get
            {
                return (fp) / (fp + tp);
            }
        }

        // False Negative Rate		FNR = FN / (FN + TP)
        public double FalseNegativeRate
        {
            get
            {
                return (fn) / (fn + tp);
            }
        }

        // Accuracy		ACC = (TP + TN) / (P + N)
        public double Accuracy
        {
            get
            {
                return (tp + tn) / (tp + fp + tn + fn);
            }
        }

        // F1 Score		F1 = 2TP / (2TP + FP + FN)
        public double F1Score
        {
            get
            {
                return 2 * Precision * Recall / (Precision + Recall);
                //return (2*tp) / (2*tp + fp + fn);  this is another formula from the internet
            }
        }

        // Error Rate
        public double ErrorRate
        {
            get
            {
                return (fp + fn) / (tp + fp + tn + fn);
            }
        }
    }
}
