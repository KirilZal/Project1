using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    static class Extensions
    {
        public static T[]GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for(int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];

            }
            return array;  
        }
    }
}
