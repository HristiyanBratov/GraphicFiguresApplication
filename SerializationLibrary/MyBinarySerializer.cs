﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseProject_OOP_Stage2
{
    public class MyBinarySerializer : IDataSerializable
    {      
        public void Serialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
                File.Delete(filePath);

            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();           
        }

        public object Deserialize(string filePath)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }

            return obj;
        }

        public string GetFileExtension()
        {
            return ".bin";
        }
        
    }
}