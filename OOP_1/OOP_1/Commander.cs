using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Commander
    {
        private static Commander commander;
        public string name { get; set; }
       
         private Commander(string _name)
        {
            this.name = _name;
        }

        public static Commander getCommander(string _name)
        {
            if (commander == null)
                commander = new Commander(_name);
            return commander;
        }
    }

}
