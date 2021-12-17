using System;
using System.IO;

namespace Anagram
{
    class Program
    {

        public static string Anagram(int n)
        {
            string [] Word = new string [48162];
            TextReader Leer = new StreamReader("C:/wordlist.txt");
            for (int i = 0; i < 48162; i++)
            {
                Word[i] = Leer.ReadLine();

                for (int c = 0; c < 48162; c++)
                {
                    string temp = Leer.ReadLine();
                    if (Word[i].Length == temp.Length)
                    {
                        
                    }
                }
            }
           
            Leer.Close();

            return Word[n];
        }

        public static string Order(string x)
        {
            char[] charx = x.ToCharArray();

            Array.Sort(charx);
            


            return new string (charx);
        }

    }
}
