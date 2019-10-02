using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    class Program
    {
        
        static void Main(string[] args)
        {
        }
        private static IList<IList<Int32>> FourSum(Int32 [] nums, Int32 target)
        {
            List<IList<Int32>> result = new List<IList<Int32>>();//I have to figure out / recall what is 
            //the use of declearing something as IList instead of Lits?
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-3; i++)
            {
                if (i != 0 && nums[i]==nums[i-1])//Handle duplicates 
                {
                    continue;
                }
                for (int j = 0; j < nums.Length - 2; j++)
                {
                    if (j != i + 1 && nums[j] == nums[j-1])
                    {
                        continue;
                    }
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while ( left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum < target)
                        {
                            left++;
                        }
                        else if (sum > target)
                        {
                            right--;
                        }
                        else
                        {
                            List<Int32> quadruplet = new List<int>();
                            quadruplet = new List<Int32> { nums[i], nums[j], nums[left], nums[right] };

                            result.Add(quadruplet);

                            left++;
                            right--;
                            
                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right + 1])
                            {
                                right--;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
