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
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            var writer = new StreamWriter("../../class.txt", true);
            string text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            string[] texts = text.Split();
            for (var i = 0; i < texts.Length; ++i)
            {
                Console.Write(texts[i] + " ");
                writer.WriteLine(texts[i]);
            }

        }
    }
}
