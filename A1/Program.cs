using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veranstaltung lv = DataHelper.GetData();

            serializeBinaryFormatter("veranstaltungen.bin", lv);
            serializeXml("veranstaltungen.xml", lv);
            
            Console.ReadLine();
        }

        public static void serializeBinary(string path, Veranstaltung lv)
        {
        }

        public static Veranstaltung deserializeBinary(string path)
        {
        }

        public static void serializeXml(string path, Veranstaltung lv)
        {
           XmlSerializer xmlSer = new XmlSerializer(typeof(Veranstaltung));
           FileStream fileStream = new FileStream(path, FileMode.Create);
           xmlSer.Serialize(fileStream, lv);
           fileStream.Close();
        }

        public static Veranstaltung deserializeXml(string path)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(Veranstaltung));
            FileStream fs = new FileStream(path, 117, FileMode.Open);
            return (Veranstaltung)xmlSer.Deserialize(fs);
        }

        public static void serializeBinaryFormatter(string path, Veranstaltung lv)
        {
            BinaryFormatter binFor = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            binFor.Serialize(fileStream, lv);
            fileStream.Close();
        }

        public static Veranstaltung deserializeBinaryFormatter(string path)
        {
            BinaryFormatter binFor = new BinaryFormatter();
            FileStream fs = new FileStream(path, 117, FileMode.Open);
            return (Veranstaltung)binFor.Deserialize(fs);
        }
    }
}
