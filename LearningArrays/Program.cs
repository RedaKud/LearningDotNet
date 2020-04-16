using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s_array = new string[5];

            s_array[0] = "one";
            s_array[1] = "two";
            s_array[2] = "three";
            s_array[3] = "four";
            s_array[4] = "five";

            for(int i = 0; i < 5; i++)
            {
                Console.Write(s_array[i] + " ");
            }

            Console.WriteLine();

            int[] i_array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                i_array[i] = i;

            }

            for(int i = 19; i != -1; i--)
            {
                Console.Write(i_array[i] + " ");
            }

    

        }
    }
}
