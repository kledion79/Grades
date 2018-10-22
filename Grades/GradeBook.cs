using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        /// <summary>
        /// get/set
        /// </summary>
        private string _name;

        public string Name
        {
            get
            {
                return _name; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                if (_name != value)
                {
                    NameChangedEventsArgs args = new NameChangedEventsArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    NameChanged(this, args);
                }

                _name = value;

            }
        }

        //the only thing that is done to convert instance of the delegate is to add 'event'
        public event NameChangedDelegate NameChanged;
        private List<float> grades;
    }
}