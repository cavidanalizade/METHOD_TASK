using static System.Net.Mime.MediaTypeNames;

namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinArr(16756, 4, -78, 0, 79, 1, 1, 788);            //task1
                
            IsPower(81, 4);                                     //task2


            bool isSorted = IsArraySorted(5, 4, 5, 7, 8, 9);    //task3
            Console.WriteLine(isSorted);                        //task3


            int index = FindCharIndex("cbdhcn", 'h');            //task4
            Console.WriteLine(index);                           //task4
        }
        #region task1
        public static void MinArr(params int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);

        }
        #endregion

        #region task2
        public static void IsPower(int n1, int n2)
        {

            while (n1 > 1)
            {
                if ((n1 % n2) == 0)
                {
                    n1 /= n2;

                }
                else
                {
                    break;
                }
            }
            if (n1 == 1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        #endregion

        #region task3
        static bool IsArraySorted(params int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }





        #endregion
        #region task4
        static int FindCharIndex(string input, char targetChar)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == targetChar)
                {
                    return i;
                }
            }
            return -1;
        }
    
    #endregion
    }
}

