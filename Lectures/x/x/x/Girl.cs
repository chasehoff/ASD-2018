using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Girl : Person
    {
        public string[] makeup;

        public Girl(string _name, int _age, string[] _makeup):base(_name, _age)
        {
            makeup = _makeup;
        }
    }
}
