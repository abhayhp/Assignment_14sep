using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14sep
{
    public class Student
    {
        int rollno;
        string name;
        double sub1_mark;
        double sub2_mark;
        double sub3_mark;

        public Student()
        {
            rollno = 3;
            name = "abhay";
            sub1_mark = 70.0;
            sub2_mark = 80.0;
            sub3_mark = 74.0;
        }

        public Student(int rollno, string name, double sub1_mark, double sub2_mark, double sub3_mark)
        {
            this.rollno = rollno;
            this.name = name;
            this.sub1_mark = sub1_mark;
            this.sub2_mark = sub2_mark;
            this.sub3_mark = sub3_mark;
        }

        public void CalculateMarks()
        {
            Console.WriteLine("Total marks  = " + (sub1_mark + sub2_mark + sub3_mark));
            Console.WriteLine("Percentage -> " + (((sub1_mark + sub2_mark + sub3_mark) / 300.0) * 100.0));
        }



    }
}
