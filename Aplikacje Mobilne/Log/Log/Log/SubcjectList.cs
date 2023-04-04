using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Log
{
    internal class SubcjectList
    {
        public static ObservableCollection<Subject> Subjects = new ObservableCollection<Subject>()
        {
            new Subject(){Name="Matematyka", Grades= new List<int>(){ 1,2,6,3,4,2}},
            new Subject(){Name="Język Polski", Grades = new List<int>(){ 4,3,2,5,1}},
            new Subject(){Name="Fizyka", Grades = new List<int>(){ 3,5,2}},

        };
    }
}
