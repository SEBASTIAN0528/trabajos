using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismin
{
    class Class1
    {
        int id;
        string name;

        public void set(int pid, string pname)
        {
            id = pid;
            name = pname;

        }
        public void set(string pname)
        {
            name = pname;

        }
        public string get()
        {
            return name;
        }

    }
}
