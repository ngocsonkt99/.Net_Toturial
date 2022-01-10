using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai_4.Models
{
    public class Staff
    {
        public int StaffID { get;set; }
        public string StaffName { get; set; }
        public DateTime BirthOfDate { get; set; }
        public decimal Salary { get; set; }
        public string StaffImage { get; set; }
    }
}