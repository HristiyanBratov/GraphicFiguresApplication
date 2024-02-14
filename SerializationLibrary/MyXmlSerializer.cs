using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseProject_OOP_Stage2
{
    public class MyXmlSerializer : IDataSerializable
    {
        public void Serialize(object data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(data.GetType());

            if (File.Exists(filePath))
                File.Delete(filePath);
           
            TextWriter textWriter = new StreamWriter(filePath);

            xmlSerializer.Serialize(textWriter, data);
          
            textWriter.Close();
        }

        public object Deserialize(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            object obj = null;

            if (File.Exists(filePath))
            {
                TextReader tr = new StringReader(filePath);               

                obj = xmlSerializer.Deserialize(tr);
                tr.Close();
            }

            return obj;
        }

        public string GetFileExtension()
        {
            return ".xml";
        }      
        
    }
}