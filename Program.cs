using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Array_1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]; //declaring the size of the array
            arr =new int[] { 31, 99, 22, 33, 88 }; // values given to array
            Console.WriteLine("======display array by using for loop=====");
            //display array by using for loop
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("======display array by using forEach======");
            //display array by using forEach
            foreach(int r in arr)
            {
                Console.WriteLine(r);
            }

            //sorting of array
            Array.Sort(arr);
            Console.WriteLine("===========array after sorting===========");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //copy array into another array
            Console.WriteLine("===copying of our array into new array====");
            int[] newarr = new int[3];
            Array.Copy(arr, 1, newarr, 0, 3);
            for (int i = 0; i < newarr.Length; i++)
            {
                Console.WriteLine(newarr[i]);
            }
            Console.WriteLine("==========reverse of an array============");

            //reverse of our array
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //clear of array
            Console.WriteLine("=======clear array by using clear========");
            Array.Clear(arr,2,3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("=======String contents henseforth=======");

            string[] nameList = new string[] { "nilesh", "aamir", "ganesh", "vikrant", "aaradhya" };

            Console.WriteLine("======display String array by using for loop=====");
            //display array by using for loop
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            Console.WriteLine("======display String array by using forEach======");
            //display array by using forEach
            foreach (string r in nameList)
            {
                Console.WriteLine(r);
            }

            //sorting of array
            Array.Sort(nameList);
            Console.WriteLine("===========String array after sorting============");
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            //copy array into another array
            Console.WriteLine("===copying of our array into new array====");
            string[] newNameList = new string[3];
            Array.Copy(nameList, 1, newNameList, 0, 3);
            for (int i = 0; i < newNameList.Length; i++)
            {
                Console.WriteLine(newNameList[i]);
            }

            Console.WriteLine("==========reverse of an array============");
            //reverse of our array
            Array.Reverse(nameList);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            //clear of array
            Console.WriteLine("=======clear array by using clear========");
            Array.Clear(nameList, 2, 3);
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }









        }
    }
}
