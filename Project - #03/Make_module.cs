using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.IO;

namespace StreamReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);             
            StreamReader O = new StreamReader("c:\\users\\ den\\file.txt", System.Text.Encoding.Default);
            string K;
            while (O.EndOfStream != true)
            {                 
                K = O.ReadLine();
                Console.WriteLine(K);
            }
            O.Close();
            Console.ReadLine();
        }
    } 
}
