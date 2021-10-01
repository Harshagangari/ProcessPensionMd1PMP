﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPensionMd1
{
    public class PensionerDetails
    {
        public string Name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int AadharNumber { get; set; }
        public string PAN { get; set; }
        public double salaryEarned { get; set; }
        public double allowances { get; set; }
        public string pensionType { get; set; }
        public string bankName { get; set; }
        public string accountNumber { get; set; }
        public string bankType { get; set; }
    }
}
