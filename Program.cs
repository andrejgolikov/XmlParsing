using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using XmlParsing.Models;

namespace XmlParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = Path.GetFullPath(@".\..\..\data\example.xml");
            Console.WriteLine($"inputFilePath: {inputFilePath}{Environment.NewLine}");

            XElement document = XElement.Load(inputFilePath);
            Console.WriteLine($"document:{Environment.NewLine}{document}");

            Datagram datagram = XmlToDatagram(document);

            Console.ReadKey();
        }

        private static Datagram XmlToDatagram(XElement xml)
        {
            StringReader reader = new StringReader(xml.ToString());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Datagram));
            return (Datagram)xmlSerializer.Deserialize(reader);
        }
    }
}
