using System;
using System.IO;

namespace encrypt
{
    public class Encrypter
    {
        static void Main(string[] args)
        {
            string inputFilename = "input.txt";
            string outputFilename = "output.txt";

            string contents = File.ReadAllText(inputFilename);

            string cipher = string.Empty;
            byte key = 13;
            foreach (char letter in contents)
            {
                cipher += (char)(letter + key);
            }

            File.WriteAllText(outputFilename, cipher);
        }
    }
}
