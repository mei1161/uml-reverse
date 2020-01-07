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
            var writer = new StreamWriter("../../class.pu", false,enc);
            string text = sr.ReadToEnd();
            sr.Close();
            string[] texts = text.Split();
            var text_list = new List<String>();
            for(var i=0; i< texts.Length; ++i)
            {
                if(texts[i] != "")
                {
                    text_list.Add(texts[i]);
                }
                
            }
            writer.WriteLine("@startuml mei");
            for (var i = 0; i < text_list.Count(); ++i)
            {
                if (text_list[i].Contains("class"))
                {
                    writer.Write(text_list[i]);
                    writer.Write(" ");
                    writer.Write(text_list[i + 1]);
                    writer.WriteLine("{");
                }

                if (text_list[i].Contains("public"))
                {
                    writer.Write(text_list[i + 1]);
                    writer.Write(" ");
                    writer.WriteLine(text_list[i + 2]);
                }



            }
            writer.WriteLine("}");
            writer.WriteLine("@enduml");
            writer.Close();
        }
    }
}
