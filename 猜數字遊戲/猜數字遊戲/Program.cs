// 猜數字遊戲

using System.ComponentModel;

Random rnd = new Random();
int secret_num = rnd.Next(1 , 100);
int guess;
int secret_count = 0;
int secret_limit = 5;
int secret_min = 0;
int secret_max = 100;
bool win = false;
do
{
    System.Console.Write("請輸入猜測 : ");
    guess = System.Convert.ToInt32(System.Console.ReadLine());

    if (guess > secret_num)
    {
        secret_max = guess;
        System.Console.WriteLine(secret_min + "~" + secret_max);
    }
    else if (guess < secret_num)
    {
        secret_min = guess;
        System.Console.WriteLine(secret_min + "~" + secret_max);
    }
    else
    {
        System.Console.WriteLine("恭喜你答對了!");
        win = true;
    }
    secret_count++;
}
while (guess != secret_num && secret_count < secret_limit);

if (!win)
{
    System.Console.WriteLine("答案是 " + secret_num + " ，請再接再厲");
}
