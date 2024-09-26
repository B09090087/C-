// if 判斷句

/* 1.
    如果 機車油量快沒了
        我就去加油
*/


bool oil = true;
if (oil)
{
    System.Console.WriteLine("我就去加油");
}

/* 2.
    如果 今天大晴天
        我就騎重機上班
    否則
        我就騎白牌機車上班
*/

bool sunny = true;
if (sunny)
{
    System.Console.WriteLine("我就騎重機上班");
}
else
{
    System.Console.WriteLine("我就騎白牌機車上班");
}

/* 3.
    如果 機車排氣量為550C.C以上
        是紅牌重機
    或是如果 機車排氣量為255C.C以上
        是黃牌重機
    否則
        是白牌機車
*/

int engine_displacemen = 300;
if(engine_displacemen >= 550)
{
    System.Console.WriteLine("是紅牌重機");
}
else if(engine_displacemen >= 255 && engine_displacemen < 550)
{
    System.Console.WriteLine("是黃牌重機");
}
else
{
    System.Console.WriteLine("是白牌機車");
}

/* 4.
    如果 排氣量550C.C以上 且 是晴天
        可以騎上去國三甲
    否則
        不可以騎上去國三甲
*/

int engine_displacemen_1 = 550;
bool sunny_1 = true;
if(engine_displacemen_1 >= 550 && sunny_1) // &&且的意思
{
    System.Console.WriteLine("可以騎上去國三甲");
}
else
{
    System.Console.WriteLine("不可以騎上去國三甲");
}

/* 5.
    如果 排氣量550C.C以上 或 是晴天
        可以騎上去國三甲
    否則
        不可以騎上去國三甲
*/

int engine_displacemen_2= 550;
bool sunny_2 = true;
if (engine_displacemen_2 >= 550 || sunny_2) // ||或的意思
{
    System.Console.WriteLine("可以騎上去國三甲");
}
else
{
    System.Console.WriteLine("不可以騎上去國三甲");
}

/* 6.
    如果 排氣量沒有550C.C以上 或 不是晴天
        可以騎上去國三甲
    否則
        不可以騎上去國三甲
*/

int engine_displacemen_3 = 550;
bool sunny_3 = true;
if (engine_displacemen_3 != 550 || !sunny_3) // ||或的意思
{
    System.Console.WriteLine("可以騎上去國三甲");
}
else
{
    System.Console.WriteLine("不可以騎上去國三甲");
}
