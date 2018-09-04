using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Class1
    {
        protected int id;
        protected string name;

        public void set(int pid, string pname)
        {
            id = pid;
            name = pname;

        }
        public string get()
        {
            return name;
        }
        public class Sebasclass1 : Class1
        {
            public void rename(string pnewname)
            {
                name = pnewname;
            }
        }
    }
}
