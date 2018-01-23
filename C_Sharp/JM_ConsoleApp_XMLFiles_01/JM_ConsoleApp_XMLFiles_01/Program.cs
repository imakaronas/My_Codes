using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JM_ConsoleApp_XMLFiles_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Createfile();

            Console.ReadLine();

        }

        public static void Createfile()
        {
            XmlTextWriter writer = new XmlTextWriter("machines.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            writer.WriteStartElement("Table");
            createNode("1", "ATM", "100", writer);
            createNode("2", "APS", "80", writer);
            createNode("3", "OLIS", "120", writer);
            createNode("4", "MASSCOIN", "50", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Console.WriteLine("XML File created ! ");
        }

        public static void createNode(string pID, string pName, string pPrice, XmlTextWriter writer)
        {
            writer.WriteStartElement("Machines");
            writer.WriteStartElement("Machine_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Machine_Type");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Machine_Installed");
            writer.WriteString(pPrice);
            writer.WriteEndElement();
            writer.WriteEndElement();

        }
    }
}
