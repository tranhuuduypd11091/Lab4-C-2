using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("1", "Huu Duy",18));
            list.Add(new Student("2", "Huu Khanh",20));
            list.Add(new Student("3", "Thanh Dung",10));
            list.Add(new Student("4", "Tuan Dat",30));
            list.Add(new Student("5", "Manh Quy",50));

            var selectData = list.Select(u => new { u.id,u.Name, u.age });
            foreach (var item in selectData)
            {
                Console.WriteLine(" id "+ item.id + " name "+item.Name +" age "+item.age);
            }
        }
    }
}
