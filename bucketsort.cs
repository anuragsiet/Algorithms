using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sorting_Algorithms_In_C_Sharp
{
    public static class BucketSort
    {
        
        public static List<int> BucketSort(params int[] x)
        {
            List<int> result = new List<int>();
            
            int numOfBuckets = 10;
 
            //Create buckets
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
                buckets[i] = new List<int>();
                
                 for (int i = 0; i < x.Length; i++)
            {
                int buckitChoice = (x[i] / numOfBuckets);
                buckets[buckitChoice].Add(x[i]);
            }
 
                 for (int i = 0; i < numOfBuckets; i++)
            {
                int [] temp = BubbleSortList(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }
 