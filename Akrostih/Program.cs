using System;
using System.IO;
using System.Text;
namespace Катерина_18_решение_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "SampleText(1).txt";
            int lineNo = 0;

            try
            {
                StreamReader rd = new StreamReader(fileName);

                using (rd)
                {
                    StringBuilder akrostih = new StringBuilder();
                    string line = rd.ReadLine();
                    while (line != null)
                    {
                        akrostih.Append(line[0]).Append("");
                        lineNo++;
                        line = rd.ReadLine();
                    }
                    Console.WriteLine("Akrostih{1}: {0}", akrostih.ToString(), lineNo);
                    Console.ReadKey(false);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}", fileName);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not read file {0}", fileName);
            }
        }
    }
}