using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradesbook
{
    class Grade
    {
        public Grade()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public List<float> Printx()
        {
            return grades;
            //Console.WriteLine(grades[1]);  
           // Console.WriteLine(grades);
        }

        public GradeSataistics ComputeStatistics()
        {
            GradeSataistics stats = new GradeSataistics();
          
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.highestGrade = Math.Max(grade,stats.highestGrade);
                stats.lowestGrade = Math.Min(grade,stats.lowestGrade);
                sum += grade;
            }

            stats.AvarageGrade = sum / grades.Count;

            return stats;
           
        }


        public List<float> grades; 
    }
}
