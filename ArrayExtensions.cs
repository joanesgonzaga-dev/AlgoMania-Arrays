using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoMania_Arrays
{
    public static class ArrayExtensions
    {
        public static void RemoveAllEquals<T>(this T[] _array, T item, ref T[] myArray) //
        {
            // O(n)
            List<T> newArray = new List<T>();
            
            for (int i = 0; i < myArray.Length; i++)
            {
                if (!myArray[i].Equals(item))
                {
                    newArray.Add(myArray[i]);
                }  
            }
            myArray = newArray.ToArray();
        }

        public static void RemoveFirstEquals<T>(this T[] _array, T item, ref T[] myArray)
        {
            // O(n)
            List<T> newArray = new List<T>();
            bool firstEquals = true;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (!myArray[i].Equals(item))
                {
                    newArray.Add(myArray[i]);
                }
                else if(myArray[i].Equals(item) & firstEquals){
                    
                    firstEquals = false;
                }
                else
                {
                    newArray.Add(myArray[i]);
                }   
            }
            myArray = newArray.ToArray();
        }

        public static T ReturnsRepeater<T>(this T[] _array)
        {
            //O(n^2)
            int maximumRepeater = 0;
            T repeaterItem = _array[0];

            for (int i = 0; i < _array.Length; i++)
            {
                int currentRepeater = 0;

                for (int j = 0; j < _array.Length; j++)
                {
                    if (_array[i].Equals(_array[j]))
                    {
                        currentRepeater++;
                    }
                    if (currentRepeater > maximumRepeater)
                    {
                        repeaterItem = _array[i];
                        maximumRepeater = currentRepeater;
                    }
                }      
            }
            return repeaterItem;
        }
    }
}