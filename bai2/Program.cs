using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<userData> list = new List<userData>();
            list.Add(new userData("TFT",10));
            list.Add(new userData("LienMinhHuyenThoai",15));
            list.Add(new userData("Pokemon",100));
            list.Add(new userData("Gunny",5));

            var selectData = list.Select(u => new { u.Name, u.level });
            foreach (var item in selectData)
            {
                Console.WriteLine("Name " + item.Name + " | level " + item.level);
            }



            var sortlist = list.OrderByDescending(u => u.level);
            Console.WriteLine(" danh sach thu tu tang dan level");
            foreach (var item in sortlist)
            {
                Console.WriteLine(" Name "+ item.Name +" | Level "+ item.level);
            }
        }
        
    }
}
