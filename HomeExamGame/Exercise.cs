using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExamGame
{
    public class Exercise 
    {
        //Data Fields:
        float? points;
        string question;
        string answer;
        private string exercise_str;
        //Construcotrs
        public Exercise(float points, string question, string answer)
        {
            this.points = points;
            this.question = question;
            this.answer = answer;
        }
        public Exercise(string question, string answer)
        {
            Points = 0;
            this.question = question + '=';
            this.answer = answer;
        }
        public Exercise()
        {
            this.points = 0;
            this.question = "";
            this.answer = "";
        }
        public Exercise(string exercise_str)
        {
            string[] exr_strings = exercise_str.Split(';');
            this.question = exr_strings[1];
            this.answer = exr_strings[2];
            this.points = float.Parse(exr_strings[3]);

        }
        //Properties:
        public float? Points { get => points; set => points = value; }
        public string Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
        //Methods:
        public string ExeToString()
        {
            string pointsStr = Points.HasValue ? $"{points}" : "";

            return $"{Question};{Answer};{pointsStr}";          //3;3+2=;5;12
        }

    }
}
