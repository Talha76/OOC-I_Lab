using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    abstract internal class Staff
    {
        public string name { get; }
        public int code { get; }
        abstract public void showInfo();
        abstract public string whoAmI();
        protected Staff(string name, int code)
        {
            this.name = name;
            this.code = code;
        }
    }
}
