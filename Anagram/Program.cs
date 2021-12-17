using System;
using System.IO;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private string Anagram()
        {
            TextReader Leer = new StreamReader("wordlist.txt");
            string respuesta = Leer.ReadLine();

            Leer.Close();

            return respuesta;
        }
    }
}
