using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLetterWordsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Please enter a 5-letter word to retrieve all possible 3-letter combinations");
            word = Console.ReadLine();

            for (int r = 0; r < 5; r++)
            {
                for (int c = r; c < 5; c++)
                {
                    for (int x = c; x < 5; x++)
                    {
                        if (r != c && r != x && c != x)
                        {

                            Console.Write(word.Substring(r, 1) + word.Substring(c, 1) + word.Substring(x, 1) + " ");
                            Console.Write(word.Substring(r, 1) + word.Substring(x, 1) + word.Substring(c, 1) + " ");
                            Console.Write(word.Substring(c, 1) + word.Substring(r, 1) + word.Substring(x, 1) + " ");
                            Console.Write(word.Substring(x, 1) + word.Substring(r, 1) + word.Substring(c, 1) + " ");
                            Console.Write(word.Substring(c, 1) + word.Substring(x, 1) + word.Substring(r, 1) + " ");
                            Console.Write(word.Substring(x, 1) + word.Substring(c, 1) + word.Substring(r, 1) + " ");
                            Console.WriteLine();
                        }
                    }
                }
            }
                Console.ReadLine();
            }
        }
    }


