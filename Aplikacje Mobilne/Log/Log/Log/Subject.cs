using System;
using System.Collections.Generic;
using System.Text;

namespace Log
{
    internal class Subject
    {
        private string _gradesStr;
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public string GradesSting
        {
            get { return ConvertList(Grades); }
            set
            {
                _gradesStr = value;
            } 
        }

        public Subject()
        {
        }

        string ConvertList(List<int> tab)
        {
            string tmp="";

            foreach (var item in tab)
            {
                tmp += $"{item}, ";
            }
            return tmp;
        }
        
    }
}
