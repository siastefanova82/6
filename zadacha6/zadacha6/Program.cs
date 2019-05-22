using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
    class Program
    {
        public static void colors(string[] input, int i, int j)
        {
            string x = input[i];
            input[i] = input[j];
            input[j] = x;
        }

        public static void color(string[] input)
        {
            int a = 0;
            int b = 0;
            int c = input.Length - 1;

            while (a <= c)
            {

                if (String.Equals(input[a], "red"))
                {
                    colors(input, a, b);
                    a++;
                    b++;
                }
                else if (String.Equals(input[a], "blue"))
                {

                    a++;
                }
                else if (String.Equals(input[a], "white"))
                {

                    colors(input, a, c);
                    c--;
                }
                else
                {

                    break;
                }
            }
        }
        public static void Main(string[] args)
        {
            string[] input = { "white", "white", "white", "white", "blue", "blue", "white", "red", "white", "blue", "white", "white", "white" };

            color(input);

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

        }

    }
}
