 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_object
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
        public string get()
        {
            return name;
        }

    }
}
