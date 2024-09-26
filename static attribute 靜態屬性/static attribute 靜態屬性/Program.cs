//  static attribute 靜態屬性
using System;
using ConsoleApp1;

Console.WriteLine(Video.video_count);
Video video1 = new Video("哇哈哈哈哈", "小白", "娛樂");
Console.WriteLine(Video.video_count);
Video video2 = new Video("真的讚", "小黑", "教育");
Console.WriteLine(video1.getVideoCount());

