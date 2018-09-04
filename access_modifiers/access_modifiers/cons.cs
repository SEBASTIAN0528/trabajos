using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifiers
{
    class access_modifiers
    {
        int id;
        string name;
        public access_modifiers()
        {
            id = 0;
            name = "Sebastian :V";
        }
        private void set(int pid, string pname)
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
