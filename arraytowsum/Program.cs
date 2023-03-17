using System;

namespace arraytowsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int target = Convert.ToInt32(Console.ReadLine());
            int[] result = Solution.TwoSum(nums, target);
            if (result != null)
            {
                Console.WriteLine($"[{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }
        }
        public class Solution
        {
            public static int[] TwoSum(int[] nums, int target)
            {
                int[] arr = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            arr[0] = i;
                            arr[1] = j;
                            return arr;
                        }
                    }
                }
                return null;
            }
        }
    
}
}
