using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudProject
{
    public class Student
    {
        int rno, s1, s2, s3;
        string sname;
        float mark=150, perc;

        public Student()
        {
            rno = 1;
            sname = "Mahesh";
        }
        public void Student(int rno, string sname)
        {
            this.rno = rno;
            this.sname = sname;
        }
        public int TotalMark()
        {
            mark = s1 + s2 + s3;
        }
        public float TotalPer()
        {
            per = mark / 3;
        }
        public string display()
        {
            return $"Student Detail:{rno}-{sname}-{mark}-{perc}";
        }
    }
}    
 
