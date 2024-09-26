using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Video
    {
        public string title;
        public string author;
        //影片類型只有4種 : 教育、娛樂、音樂、其他
        private string type;

        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author; 
            Type = type;
        }

        public string Type
        {
            get { return type; }
            set
            {
                if(value == "教育" ||  value == "娛樂" || value == "音樂")
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }
            }
        }
    }
}
