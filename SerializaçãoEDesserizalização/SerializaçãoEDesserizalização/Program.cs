using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace SerializaçãoEDesserizalização
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Bob", "Black");
            Dog otherDog;

            DataContractSerializer serializer = new DataContractSerializer(typeof(Dog));

            //Serialização
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder constructorOfString = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(constructorOfString, xmlConfig);
            serializer.WriteObject(xmlWriter, myDog);
            xmlWriter.Flush();
            string serializedObject = constructorOfString.ToString();

            //Saving in folder using xml format
            string path = "dog.xml";
            FileStream myFileXml = File.Create(path);
            myFileXml.Close();
            File.WriteAllText(path, serializedObject);

            //Desserialização
            string contentOfXml = File.ReadAllText(path);
            StringReader readerOfStrings = new StringReader(contentOfXml);
            XmlReader readerOfXml = XmlReader.Create(readerOfStrings);
            otherDog = (Dog)serializer.ReadObject(readerOfXml);

            readerOfXml.Close();
            xmlWriter.Close();
        }
    }
}
