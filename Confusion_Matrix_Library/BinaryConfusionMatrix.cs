using System;
using System.Collections.Generic;
using System.Text;

namespace Confusion_Matrix_Library
{
    public class BinaryConfusionMatrix
    {
        double tp, tn, fp, fn;


        public double Accuracy
        {
            get
            {
                return (tp + tn) / (tp + fp + tn + fn);
            }
        }

        public double ErrorRate
        {
            get
            {
                return (fp + fn) / (tp + fp + tn + fn);
            }
        }

        public double Recall
        {
            get
            {
                return (tp) / (tp + fn);
            }
        }

        public double Specificity
        {
            get
            {
                return (tn) / (tn + fp);
            }
        }

    }
}
