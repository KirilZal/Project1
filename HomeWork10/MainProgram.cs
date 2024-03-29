using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
     class MainProgram
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"element in index {i}: {myList[i]}");
            }
            MyList<string> myList2 = new MyList<string>();
            
            myList2.Add("Hi");
            myList2.Add("My Name is");
            myList2.Add("Marshalll");
            
            string[] array = myList2.GetArray();
            
            for (int j = 0;j < myList2.Count;j++)
            {
                array[j] = myList2[j];
                Console.WriteLine(array[j]);
            }
            array[2] = "ROKIII";
            Console.WriteLine();
            foreach (string element in array)
            {
                
                Console.WriteLine(element);
            }


        }

    }

}
