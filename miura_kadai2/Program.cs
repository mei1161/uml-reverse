using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace miura_kadai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "../../Student.java";
            StreamReader sr = new StreamReader(filepath);
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            var writer = new StreamWriter("../../class.txt", false,enc);
            string text = sr.ReadToEnd();
            sr.Close();
            string[] texts = text.Split();
            for (var i = 0; i < texts.Length; ++i)
            {
                if(texts[i].Contains( "("))
                {
                    Console.WriteLine(texts[i]);
                    writer.WriteLine(texts[i]);
                }
            }
            writer.Close();
        }
    }
}
