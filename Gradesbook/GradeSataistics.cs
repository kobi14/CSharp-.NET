using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradesbook
{
    public  class GradeSataistics
    {
        public GradeSataistics()
        {
            highestGrade = 0;
            lowestGrade = float.MaxValue;
        }
        public float AvarageGrade;
        public float highestGrade;
        public float lowestGrade;
    }
}
