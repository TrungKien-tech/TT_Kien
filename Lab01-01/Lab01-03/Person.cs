using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Person(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Mã số: {ID}, Họ tên: {Name}";
        }
    }
}