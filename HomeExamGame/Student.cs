using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExamGame
{
    class Student
    {
        //Data Fields:
        string first_name;
        string last_name;
        //Propeties:
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        //Constructors:
        public Student(string f_name, string l_name)
        {
            First_name = f_name;
            Last_name = l_name;
        }
        public Student()
        {
            First_name = "Anonymous";
            Last_name = "Anonymous";
        }
    }
}
