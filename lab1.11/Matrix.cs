namespace lab1._11
{
    class Matrix
    {
        public static int size = 5;
        int[,] matrix = new int[size, size];

        public int this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }

        public int findMaxLeft()
        {
            int maxLeft = matrix[0, 0];
            for (int i = 0; i < size - 1; ++i)
            {
                for (int j = 1; j < size - i - 1; ++j)
                {
                    if (matrix[i, j] >= maxLeft) maxLeft = matrix[i, j];
                }
            }
            return maxLeft;
        }

        public int findMaxRight()
        {
            int maxRight = matrix[1, size - 1];
            for (int i = 1; i < size; ++i)
            {
                for (int j = size - i; j < size; ++j)
                {
                    if (matrix[i, j] >= maxRight) maxRight = matrix[i, j];
                }
            }
            return maxRight;
        }

        public override string ToString()
        {
            string result = "\n";
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (this[i, j] == 0)
                    {
                        result += "0      ";
                    }
                    else
                    {
                        result += String.Format("{0,-8}", this[i, j]);
                    }
                }
                result += "\n";
            }
            result += "\n";
            return result;
        }
    }
}
