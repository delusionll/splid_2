using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace splid_2.code
{
    class SplidList
    {
        private int sum;
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        
    }
}
