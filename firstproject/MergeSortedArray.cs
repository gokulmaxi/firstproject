using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class MergeSortedArray
    {
        int[] arr1;
        int[] arr2;
        int arr1Length;
        int arr2Length;
        int totalLength;
        public MergeSortedArray(int[] arr1,int[] arr2 ,int arr1Length,int arr2Length) {
            this.arr1 = arr1;
            this.arr2 = arr2;
            this.arr1Length = arr1Length;
            this.arr2Length = arr2Length;
            this.totalLength = arr1Length+arr2Length;
        }
        public int[] MergeArray() {
            int[] mergedArray= new int[totalLength];
            int arr1Iterator=0;
            int arr2Iterator=0;
            int mergedArrayIterator=0;
            while(true)
            {
                Console.WriteLine(mergedArrayIterator);
                //break if both array is traversed
                if (arr1Iterator == this.arr1.Length && arr2Iterator == this.arr2Length)
                    break;
                //if array 1 is completed fill arr2 fully
                if(arr1Iterator == this.arr1.Length)
                {
                    mergedArray[mergedArrayIterator++] = this.arr2[arr2Iterator++];
                    continue;
                }
                if(arr2Iterator == this.arr2.Length)
                {
                    mergedArray[mergedArrayIterator++] = this.arr1[arr1Iterator++];
                    continue;
                }
                if (this.arr1[arr1Iterator] < this.arr2[arr2Iterator])
                    mergedArray[mergedArrayIterator++] = this.arr1[arr1Iterator++];
                else
                {
                    mergedArray[mergedArrayIterator++] = this.arr2[arr2Iterator++];
                }
            }

            return mergedArray; }
    }
}
