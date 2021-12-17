using System;
using System.IO;

namespace Anagrams
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private void Anagrama()
        {
            TextReader Leer = new StreamReader("wordlist.txt");
            Console.WriteLine(Leer.ReadLine());

            Leer.Close();
        }
    }
}
