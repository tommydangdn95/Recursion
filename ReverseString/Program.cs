using System;

namespace ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public void reverseString(char[] arrays, int start, int end)
        {
            if(start >= end)
            {
                return;
            }

            char temp = arrays[start];
            arrays[start] = arrays[end];
            arrays[end] = temp;

            reverseString(arrays, start + 1, end - 1);
        }
    }
}
