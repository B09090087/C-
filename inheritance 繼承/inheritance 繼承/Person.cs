﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string name;
        public int age;
        

        public void PrintAge()
        {
            Console.WriteLine(this.age);
        }

        public void PrintName()
        {
            Console.WriteLine(this.name);
        }
        
    }
}