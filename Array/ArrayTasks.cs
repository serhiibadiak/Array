using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        public static void ChangeElementsInArray(int[] nums)
        {
            int bufer;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] % 2 == 0 && nums[nums.Length - i - 1] % 2 == 0)
                {
                    bufer = nums[i];
                    nums[i] = nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = bufer;
                }
            }
        }
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int max = 0, min = nums.Length, max_number;
            try
            {
                max_number = nums[0];
            }
            catch (Exception)
            {
                max_number = 0;
            }
            foreach (int item in nums)
            {
                if (item > max_number)
                {
                    max_number = item;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max_number)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                    if (i < min)
                    {
                        min = i;
                    }
                }
            }
            return max - min;
        }
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
                {
                    if (i < j)
                    { matrix[i, j] = 1; }
                    else if (i > j)
                    { matrix[i, j] = 0; }
                }
            }
        }
    }
}
