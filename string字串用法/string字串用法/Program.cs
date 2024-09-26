//字串常見用法

//換行
System.Console.WriteLine("Hello \nMr.Shih");
//加符號
System.Console.WriteLine("Hello\" Mr.Shih");

string phrase = "Hello Mr.Shih";
//字串長度
System.Console.WriteLine(phrase.Length);
System.Console.WriteLine("Hello Mr.Shih".Length);
//大寫
System.Console.WriteLine(phrase.ToUpper());
//小寫
System.Console.WriteLine(phrase.ToLower());
//是否含有特定的子字串
System.Console.WriteLine(phrase.Contains("Hello"));
System.Console.WriteLine(phrase.Contains("QQ"));
//字串特定位置的值
System.Console.WriteLine(phrase[0]); //從0開始算
System.Console.WriteLine(phrase[6]);
//用值去找位置
System.Console.WriteLine(phrase.IndexOf('H'));
System.Console.WriteLine(phrase.IndexOf("Shih"));
System.Console.WriteLine(phrase.IndexOf("QQ"));
//字串切割
System.Console.WriteLine(phrase.Substring(2));
System.Console.WriteLine(phrase.Substring(5,5));
