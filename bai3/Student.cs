using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    [Serializable]
    public class Student
    {
        public string id;
        public string Name;
        public int age;
        public Student(string _id,string _name,int _age)  
        {
            id = _id;
            Name = _name;
            age = _age; 

        }

    }
}
