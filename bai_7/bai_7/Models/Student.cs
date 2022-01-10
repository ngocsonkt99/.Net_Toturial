using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai_7.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public DateTime BirthOfDate { get; set; }
        public String Address { get; set; }
        public String Picture { get; set; }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                if(obj is Student)
                {
                    Student s = (Student)obj;
                    if (s.StudentID == this.StudentID)
                        return true;
                }
            }
            return false;
        }
    }
}