using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestClass
    {
        private int _t;
        public int testInt
        {
            get
            {
                return _t;
            }
            set
            {
                _t = value;
            }
        }
        public int a;

        [JobParameter]
        public int sst { get; set; }

        [JobParameter]
        public int te;
    }

    public class JobParameterAttribute : Attribute
    {

    }
}
