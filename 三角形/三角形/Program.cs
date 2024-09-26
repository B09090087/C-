using System;



Console.Write("請輸入數字 : ");
int money =Convert.ToInt32(Console.ReadLine());

int ten = 0, five = 0, one = 0;

for (ten = 0; ten < money/10; ten++)
{
    for (five = 0; five < (money%10)/5 ; five++)
    {
        one = money%10%5;
    }
}

Console.WriteLine(money + "一共使用" +  ten + "個10元、" + five + "個5元、" + one + "個1元");


