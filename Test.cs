using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest
{
    [RankColumn]
    [MemoryDiagnoser]
    public  class Test
    {
        [Benchmark]
        public void TestingBubbleSort()
        {
            var ob = new TestingSortAlgorithms();

            int[] array = { 1, 23, 45, 6, 7, 0, 89, 12, -96, 12, 45, 67, 89, 00, 1, 22, 44, 56, 7, 6, 2 };
            ob.BubbleSort(array); 
        }
        [Benchmark]
        public void TestingHeapSort()
        {
            var ob = new TestingSortAlgorithms();

            int[] array = { 1, 23, 45, 6, 7, 0, 89, 12, -96, 12, 45, 67, 89, 00, 1, 22, 44, 56, 7, 6, 2 };
            ob.heapsort(array);
        }
        [Benchmark]
        public void TestingInsertionSort()
        {
            var ob = new TestingSortAlgorithms();

            int[] array = { 1, 23, 45, 6, 7, 0, 89, 12, -96, 12, 45, 67, 89, 00, 1, 22, 44, 56, 7, 6, 2 };
            ob.insertionSort(array);
        }

        [Benchmark]
        public void TestingSelectionSort()
        {
            var ob = new TestingSortAlgorithms();

            int[] array = { 1, 23, 45, 6, 7, 0, 89, 12, -96, 12, 45, 67, 89, 00, 1, 22, 44, 56, 7, 6, 2 };
            ob.SelectionSort(array);
        }
        
        [Benchmark]
        public void TestingQuickSort()
        {
            var ob = new TestingSortAlgorithms();

            int[] array = { 1, 23, 45, 6, 7, 0, 89, 12, -96, 12, 45, 67, 89, 00, 1, 22, 44, 56, 7, 6, 2 };
            ob.quicksort(array,0,array.Length-1);
        }

        [Benchmark]
        public void TestingRadixSort()
        {
            var ob = new TestingSortAlgorithms();

            int[] array = { 1, 23, 45, 6, 7, 0, 89, 12, -96, 12, 45, 67, 89, 00, 1, 22, 44, 56, 7, 6, 2 };
            ob.RadixSort(array);
        }
    }
}
