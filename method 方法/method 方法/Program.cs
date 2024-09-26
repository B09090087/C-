// method方法
using System;
using ConsoleApp1;

Person person1 = new Person();
person1.height = 159.2;
person1.age = 22;
person1.name = "小白";
Console.WriteLine( person1.Add(8, 5, "dwqdsa"));

Person person2 = new Person();
person2.height = 169.7;
person2.age = 15;
person2.name = "小黑";
Console.WriteLine( person2.IsAdult());
