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

        public int ClassCount { get => list.Length; }


        public ConfusionMatrix(int classCount = 2)
        {
            if (classCount < 2)
                throw new Exception("Class count must be at least two!");

            list = new double[classCount, classCount];

        }
    }
}
