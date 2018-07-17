using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excelent";
                        break;

                    case "B":
                        result = "Good";
                        break;

                    case "C":
                        result = "Average";
                        break;

                    default:
                        result = "Improve yourself";
                        break;
                }

                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                float roundedAverageGrade = (float)Math.Round(AverageGrade);
                string result;
                if (roundedAverageGrade >= 90)
                {
                    result = "A";
                }
                else if (roundedAverageGrade >= 80)
                {
                    result = "B";
                }
                else if (roundedAverageGrade >= 70)
                {
                    result = "C";
                }
                else if (roundedAverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }
    }
}