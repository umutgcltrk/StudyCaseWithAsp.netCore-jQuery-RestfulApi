﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Study
    {
        public int StudyId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Midterm { get; set; }
        public int Final { get; set; }
    }
}
