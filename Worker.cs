using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject
{
    internal class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Car { get; set; }

        public Worker(string name, int age, bool car)
        {
            Name = name;
            Age = age;
            Car = car;
        }
    }
}
