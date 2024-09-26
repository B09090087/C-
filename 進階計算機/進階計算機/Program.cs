// 進階計算機

using System.Reflection.PortableExecutable;

System.Console.Write("請輸入第一個數 : ");
double num1 = System.Convert.ToDouble(Console.ReadLine());

System.Console.Write("請輸入要做的運算 : ");
string oper = System.Console.ReadLine();

System.Console.Write("請輸入第二個數 : ");
double num2 = System.Convert.ToDouble(Console.ReadLine());

if (oper == "+")
{
    System.Console.WriteLine(num1 + num2);
}
else if (oper == "-")
{
    System.Console.WriteLine(num1 - num2);
}
else if (oper == "*")
{
    System.Console.WriteLine(num1 * num2);
}
else if(oper == "/")
{
    System.Console.WriteLine(num1 / num2);
}
else
{
    System.Console.WriteLine("error");
}