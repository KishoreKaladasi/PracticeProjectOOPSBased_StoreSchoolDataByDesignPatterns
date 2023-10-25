using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProjectOOPSBased_StoreSchoolDataByDesignPatterns
{
    class Student
    {
        public string Name { get; set; }

        public string ClassandSection { get; set; }

        public Student(string name, string className)
        {
            Name = name;
            ClassandSection = className;
        }

    }

    
}
