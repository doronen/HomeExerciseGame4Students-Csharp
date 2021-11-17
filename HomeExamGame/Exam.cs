using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExamGame
{
    public class Exam
    {
        //Data Fields:
        public List<Exercise> exercises;
        int num_of_questions;
        bool all_same_points;
        private string exam_name;
        //Properties:
        public int Numofexer { get => exercises.Count; }
        public int NumOfQuestions { get => num_of_questions; set => num_of_questions = value; }
        public bool AllSamePoints { get => all_same_points; set => all_same_points = value; }
        public string Exam_name { get => exam_name; set => exam_name = value; }

        //Constructors:
        public Exam(int numofquestions, bool samepoints)
        {
            NumOfQuestions = numofquestions;
            AllSamePoints = samepoints;
            exercises = new List<Exercise>();
        }
        public Exam(string examString, string exam_name)
        {
            string[] exercises_strings = examString.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            this.exercises = new List<Exercise>();
            all_same_points = false;
            num_of_questions = exercises_strings.Length;
            foreach(string exercise_str in exercises_strings)
            {
                exercises.Add(new Exercise(exercise_str));
            }
            this.Exam_name = exam_name;
        }

        //Methods:
        public void AddExe(Exercise exe)
        {
            exercises.Add(exe);
        }
        public int QuestionsLeft()
        {
            return NumOfQuestions - exercises.Count;
        }
        public string ExamToString()
        {
            string tmp = "";
            foreach (Exercise exe in exercises)
            {
                tmp += exe.ExeToString() + " ";
            }
            return tmp;
        }
        public float GetExamPoints()
        {         
            float tot_points = 0;
            foreach(Exercise exe in exercises)
            {
                tot_points += (float)exe.Points;
            }
            return tot_points;
        }

    }
}
