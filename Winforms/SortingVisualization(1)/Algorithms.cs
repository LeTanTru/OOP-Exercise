using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingVisualization_1_ {
    public class Algorithms {
        public static Stopwatch sortTime = new Stopwatch();

        public static void SelectionSort(int[] arr) {
            frmMain.Instance.SetStatus();

            int arrLength = arr.Length;

            sortTime = Stopwatch.StartNew();

            for(int i = 0; i < arrLength - 1; i++) {
                int minIndex = i;
                for(int j = 1; j < arrLength; j++) {
                    if(arr[minIndex] > arr[j]) {
                        minIndex = j;
                    }
                    Count(0, 1);
                }
                if(minIndex != i) {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    Count(4, 1);
                    SleepAndMeasure();
                }
            }
            sortTime.Stop();

            frmMain.isSorted = true;
        }

        public static void InsertionSort(int[] arr) {
            sortTime = Stopwatch.StartNew();
            int arrLength = arr.Length;
            for(int i = 1; i < arrLength; i++) {
                frmMain.Instance.SetStatus();

                int temp = arr[i];
                Count(1, 0);
                int pos = i - 1;
                while(pos >= 0 && (arr[pos] > temp)) {
                    arr[pos + 1] = arr[pos];
                    pos--;
                    Count(3, 2);

                    SleepAndMeasure();
                }
                arr[pos + 1] = temp;
            }

            sortTime.Stop();

            frmMain.isSorted = true;
        }

        public static void BubbleSort(int[] arr) {
            frmMain.Instance.SetStatus();

            sortTime = Stopwatch.StartNew();
            int arrLength = arr.Length;
            for(int i = 0; i < arrLength - 1; i++) {
                for(int j = 0; j < arrLength - i - 1; j++) {
                    if(arr[j] > arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        Count(4, 1);

                        SleepAndMeasure();
                    } else {
                        Count(0, 1);
                    }
                }
            }
            sortTime.Stop();
            frmMain.isSorted = true;
        }

        public static void ShellSort(int[] arr) {
            frmMain.Instance.SetStatus();
            sortTime = Stopwatch.StartNew();
            int arrLength = arr.Length;
            for(int gap = arrLength / 2; gap > 0; gap /= 2) {
                for(int i = gap; i < arrLength; i++) {
                    int temp = arr[i];

                    Count(0, 1);

                    int j;

                    for( j = i; j >= gap && arr[j - gap] > temp; j -= gap) {
                        arr[j] = arr[j - gap];
                        Count(2, 1);
                    }

                    arr[j] = temp;

                    Count(0, 1);

                    SleepAndMeasure();
                }
            }
            sortTime.Stop();

            frmMain.isSorted = true;   
        }

        public static void MergeSort(int[] arr, int startIndex, int endIndex, int arraySize) {
            int middleOfArray;

            frmMain.Instance.SetStatus();

            sortTime = Stopwatch.StartNew();

            if(startIndex < endIndex) {
                middleOfArray = (startIndex + endIndex) / 2;

                MergeSort(arr, startIndex, middleOfArray, arraySize);

                MergeSort(arr, middleOfArray + 1, endIndex, arraySize);

                Merge(arr, startIndex, middleOfArray, middleOfArray + 1, endIndex, arraySize);

                SleepAndMeasure();
            }
            sortTime.Stop();

            frmMain.isSorted = true;
        }

        private static void Merge(int[] arr, int start, int middle, int oneMoreOfMiddle, int end, int size) {
            int tempStart, tempMiddle, tempEnd;
            int[] tempArr = new int[size];
            tempStart = start;
            tempMiddle = oneMoreOfMiddle;
            tempEnd = 0;

            while(tempStart <= middle && tempMiddle <= end) {
                if(arr[tempStart] < arr[tempMiddle]) {
                    tempArr[tempEnd++] = arr[tempStart++];
                    Count(1, 1);
                } else {
                    tempArr[tempEnd++] = arr[tempMiddle++];
                    Count(1, 1);
                }
            } 
            
            while(tempStart <= middle) {
                tempArr[tempEnd++] = arr[tempStart++];
            }

            while(tempMiddle <= end) {
                tempArr[tempEnd++] = arr[tempMiddle++];
            }

            for(tempStart = start, tempMiddle = 0; tempStart <= end; tempStart++, tempMiddle++) {
                arr[tempStart] = tempArr[tempMiddle];
                Count(1, 0);
                Thread.Sleep(Defaults.DELAY);
            }
        }

        public static void QuickSort(int[] arr, int low, int high) {
            frmMain.Instance.SetStatus();

            sortTime = Stopwatch.StartNew();

            if(low < high) {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }

            sortTime.Stop();

            frmMain.isSorted = true;
        }


        private static int Partition(int[] arr, int low, int high) {
            int pivot = arr[high];

            Count(0, 1);

            int i = low - 1;
            int temp;
            for(int j = low; j < high; j++) {
                if(arr[j] < pivot) {
                    i++;

                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    Count(4, 1);
                }
                SleepAndMeasure();
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            Count(4, 1);

            SleepAndMeasure();

            return i + 1;
        }

        private static void Count(int accessCount, int comparisonCount) {
            frmMain.comparison += comparisonCount;
            frmMain.arrayAccess += accessCount;
        }

        private static void SleepAndMeasure() {
            sortTime.Stop();
            Thread.Sleep(Defaults.DELAY);
            sortTime.Start();
        }
    }
}
