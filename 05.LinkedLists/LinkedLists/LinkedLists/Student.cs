using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Student
    {
        public string Name { get; set; }
        public string Email{get;set;}

        public string TelNum { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        public Student(string name, string email, string telNum, string program, string dateRegistered)
        {
            Name = name;
            Email = email;
            TelNum = telNum;
            Program = program;
            DateRegistered = dateRegistered;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Name, Email, TelNum, Program,DateRegistered);
        }
    }
}
