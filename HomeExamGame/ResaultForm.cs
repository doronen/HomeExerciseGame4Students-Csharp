using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeExamGame
{
    public partial class ResaultForm : Form
    {
        //Data Fields:
        //StreamWriter's to save files:
        StreamWriter exe_sw = new StreamWriter(@"EXER/tirgul.txt", true);
        StreamWriter exam_sw = new StreamWriter(@"EXER/exam.txt", true);
        StreamWriter exam_error_sw = new StreamWriter(@"EXER/exam-errors.txt", true);
        //Constructor for exam resaults:
        public ResaultForm(List<Exercise> exercises, List<bool> resault)
        {
            InitializeComponent();
            float totalPoints = 0;
            for (int i = 0; i < exercises.Count(); i++)
            {
                bool coorect = resault.ElementAt(i);
                Exercise current = exercises.ElementAt(i);
                ResaultGrid.Rows.Add(i + 1, current.Question, coorect, current.Points);
                if (coorect)
                {
                    totalPoints = totalPoints + current.Points.Value;
                }
            }
            saveExamResult(exercises, resault, "exam");
        }
        //Constructor for exercises resaults:
        public ResaultForm(List<Exercise> exercises, List<bool> resault, int total_score)
        {
            InitializeComponent();
            float totalPoints = 0;
            for (int i = 0; i < exercises.Count(); i++)
            {
                bool coorect = resault.ElementAt(i);
                Exercise current = exercises.ElementAt(i);
                ResaultGrid.Rows.Add(i + 1, current.Question, coorect, current.Points);
                if (coorect)
                {
                    totalPoints = totalPoints + current.Points.Value;
                }
            }
            ResaultGrid.Rows.Add("Total Points:", "", "", total_score.ToString());
            saveTirgulResult(exercises, resault, "Exercise");
        }
        //Methods:
        public void saveTirgulResult(List<Exercise> exercises, List<bool> res, string filename)
        {
           string fileData = "";
            float totalPCorrect = 0;

            using (exe_sw)
            {

                for (int i = 0; i < exercises.Count; i++)
                {
                    bool correct = res.ElementAt(i);
                    Exercise current = exercises.ElementAt(i);
                    string line = fileData + "Index: " + (i + 1) + "Question: " + current.Question + "IsCorrect: " + correct + "Points: " + current.Points + '\n';
                    exe_sw.WriteLine(line);
                    if (correct)
                    {
                        totalPCorrect++;
                    }
                }
                fileData = fileData + "Total Correct answers is: " + totalPCorrect + " And incorrect is: " + (exercises.Count - totalPCorrect) + "\n";
                exe_sw.WriteLine(fileData);
            }

        }
        public void saveExamResult(List<Exercise> exercises, List<bool> res, string filename)
        {
            String fileErrorData = "";
            float totalIncorrect = 0;
            float totalScore = 0;

                for (int i = 0; i < exercises.Count; i++)
                {
                    bool correct = res.ElementAt(i);
                    Exercise current = exercises.ElementAt(i);
                    if (!correct)
                    {
                        fileErrorData = fileErrorData + "Index: " + (i + 1) + " Question: " + current.Question + " IsCorrect: " + correct + " Points: " + current.Points + '\n';
                        totalIncorrect++;
                }
                    else
                    {
                        totalScore += current.Points.Value;
                    }
                }
            using (exam_sw)
            {
                exam_sw.WriteLine(fileErrorData);
            }
            using (exam_error_sw)
            {
                exam_error_sw.WriteLine("Total score is: " + totalScore);
            }



            //fileErrorData + "Total Erros is: " + totalIncorrect
        }
    }
}
