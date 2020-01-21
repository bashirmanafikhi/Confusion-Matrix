using System;
using System.Collections.Generic;
using System.Text;

namespace Confusion_Matrix_Library
{

    public class ConfusionMatrix
    {
        double[,] list;

        public double this[int x, int y]
        {
            get
            {
                return list[x, y];
            }
            set
            {
                list[x, y] = value;
            }
        }

        public int ClassCount { get => list.GetLength(0); }

        public double SumOfCorrectlyClassified
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < ClassCount; i++)
                    sum += this[i, i];
                return sum;
            }
        }

        public double SumOfTotal
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < ClassCount; i++)
                    for (int j = 0; j < ClassCount; j++)
                        sum += this[i, j];
                return sum;
            }
        }

        public double OverallAccuracy
        {
            get
            {
                double result = (SumOfCorrectlyClassified / SumOfTotal) * 100;
                if (double.IsNaN(result) || double.IsInfinity(result))
                    result = 0;
                return result;
            }
        }

        public ConfusionMatrix(int classCount = 2)
        {
            if (classCount < 2)
                throw new ArgumentException("Class count must be at least two!");

            list = new double[classCount, classCount];

        }





        double FN(int classNumber)
        {
            if (classNumber < 0 || classNumber >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double sum = 0;
            for (int i = 0; i < ClassCount; i++)
            {
                if (i == classNumber)
                    continue;
                sum += list[classNumber, i];
            }
            return sum;
        }

        double FP(int classNumber)
        {
            if (classNumber < 0 || classNumber >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double sum = 0;
            for (int i = 0; i < ClassCount; i++)
            {
                if (i == classNumber)
                    continue;
                sum += list[i, classNumber];
            }
            return sum;
        }

        double TP(int classNumber)
        {
            if (classNumber < 0 || classNumber >= ClassCount)
                throw new ArgumentException("class number is not exist !");
            
            return list[classNumber, classNumber];
        }

        double TN(int classNumber)
        {
            if (classNumber < 0 || classNumber >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double sum = 0;
            for (int i = 0; i < ClassCount; i++)
            {
                if (i == ClassCount)
                    continue;

                for (int j = 0; j < ClassCount; j++)
                {
                    if (j == ClassCount)
                        continue;

                    sum += list[i, j];
                }
            }
            return sum;
        }



        // Accuracy
        public double Accuracy(int n)
        {
            if (n < 0 || n >= ClassCount)
                throw new ArgumentException("class number is not exist !");


            double result = (TP(n) + TN(n)) / (TP(n) + TN(n) + FP(n) + FN(n));
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

        public double Accuracy()
        {
            double sum = 0;
            
            for (int i = 0; i < ClassCount; i++)
                sum += Accuracy(i);

            double result = sum / ClassCount;
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }


        // Error Rate
        public double ErrorRate(int n)
        {
            if (n < 0 || n >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double result = (FP(n) + FN(n)) / (TP(n) + TN(n) + FP(n) + FN(n));
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

        public double ErrorRate()
        {
            double sum = 0;
            
            for (int i = 0; i < ClassCount; i++)
                sum += ErrorRate(i);

            double result = sum / ClassCount;
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }


        // Specificity  SPC = TN / (FP + TN)
        public double Specificity(int n)
        {
            if (n < 0 || n >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double result = (TN(n)) / (FP(n) + TN(n));
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

        public double Specificity()
        {
            double sum = 0;

            for (int i = 0; i < ClassCount; i++)
                sum += Specificity(i);

            double result = sum / ClassCount;
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }


        // Precision
        public double Precision(int n)
        {
            if (n < 0 || n >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double result = (TP(n)) / (TP(n) + FP(n));
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

        public double Precision()
        {
            double sum = 0;

            for (int i = 0; i < ClassCount; i++)
                sum += Precision(i);

            double result = sum / ClassCount;
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }


        // Recall
        public double Recall(int n)
        {
            if (n < 0 || n >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double result = (TP(n)) / (TP(n) + FN(n));
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

        public double Recall()
        {
            double sum = 0;

            for (int i = 0; i < ClassCount; i++)
                sum += Recall(i);

            double result = sum / ClassCount;
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }


        // F1-Score
        public double F1Score(int n)
        {
            if (n < 0 || n >= ClassCount)
                throw new ArgumentException("class number is not exist !");

            double result = (2 * Precision(n) * Recall(n)) / (Precision(n) + Recall(n));
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

        public double F1Score()
        {
            double sum = 0;

            for (int i = 0; i < ClassCount; i++)
                sum += F1Score(i);

            double result = sum / ClassCount;
            if (double.IsNaN(result) || double.IsInfinity(result))
                result = 0;
            return result;
        }

    }
}
