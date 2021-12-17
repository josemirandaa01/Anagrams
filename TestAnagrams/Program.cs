using System;
using System.IO;

namespace Anagram
{
    class Program
    {

        public static string Anagram()
        {
            TextReader Leer = new StreamReader("C:/wordlist.txt");
            string respuesta = Leer.ReadLine();

            Leer.Close();

            return respuesta;
        }
    }
}
