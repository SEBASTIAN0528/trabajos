using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    class sebasclass : class1
    {

        protected int id;
        protected string name;

        public void set(int pid, string pname)
        {
            id = pid;
            name = pname;

        }
        public void set(string pname)
        {
            name = pname;

        }
    }
}
