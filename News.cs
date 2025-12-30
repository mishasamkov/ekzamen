using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class News
    {

        public string Name { get; set; }
        public string Tag { get; set; }
        public DateTime DateTime { get; set; }
        public string Src { get; set; }
        public News(string name, string tag,DateTime dateTime,string src) {

            this.Name = name;
            this.Tag = tag;
            this.DateTime = dateTime;
            this.Src = src;
        }
    }
}
