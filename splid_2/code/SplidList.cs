﻿using System;
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
        private string text;

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public string Description
        {
            get { return text; }
            set { text = value; }
        }
        
    }
}
