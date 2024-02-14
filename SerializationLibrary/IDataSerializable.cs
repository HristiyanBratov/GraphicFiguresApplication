using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_OOP_Stage2
{
    public interface IDataSerializable
    {
        void Serialize(object data, string filePath);

        object Deserialize(string filePath);

        string GetFileExtension();
    }
}