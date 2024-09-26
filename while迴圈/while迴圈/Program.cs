// while迴圈

//先判斷再做執行
int num1 = 1;
while(num1 <= 5)
{
    System.Console.WriteLine(num1);
    num1++; // num1 = num + 1 或 num += 1
}

//先執行再做判斷
int num2 = 6;
do
{
    System.Console.WriteLine(num2);
    num2++;
}
while (num2 <= 5);