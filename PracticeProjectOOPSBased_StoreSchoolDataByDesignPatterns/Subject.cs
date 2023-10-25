using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProjectOOPSBased_StoreSchoolDataByDesignPatterns
{
    internal class Subject
    {
        public string Name { get; set; }

        public string SubjectCode { get; set; }

        public string Teacher { get; set; }

        public Subject(string name, string code, string teacher)
        {
            Name = name;
            SubjectCode = code;
            Teacher = teacher;

        }
    }
}
