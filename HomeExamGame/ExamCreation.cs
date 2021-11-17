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
    public partial class ExamCreation : Form
    {
        static int index = 1;
        StreamWriter stream_writer;
        List<string> exercises;
        NewQuestion f3;
        Exam newExam;
        int question_number;

        internal Exam NewExam { get => newExam; set => newExam = value; }

        public ExamCreation()
        {
            question_number = 0;
            exercises = new List<string>();
            f3 = new NewQuestion();
            stream_writer = new StreamWriter(@"EXAMS/gameExam" + index++ + ".txt", true);
            InitializeComponent();
        }
        public ExamCreation(Exam exe)
        {
            question_number = 0;
            exercises = new List<string>();
            f3 = new NewQuestion();
            stream_writer = new StreamWriter(@"EXAMS/gameExam" + index++ + ".txt", true);
            InitializeComponent();
            NewExam = exe;
            SetNextQuestion();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pts = GetTotPoints(newExam);
            if (pts != 100)
            {
                MessageBox.Show("Your exam must have total of 100 points, right now you have " + pts);
            }
            else if (int.Parse(NumOfExe.Text) == 0)
            {
                int qnum = 1;
                foreach (string exe in exercises)
                {
                    stream_writer.WriteLine(qnum + ";" + exe);
                    stream_writer.Flush();
                    qnum++;
                }
                this.Close();
            }
            else MessageBox.Show("You still have " + NumOfExe.Text + "left to add");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tot_questions = int.Parse(NumOfExe.Text);
            if (tot_questions > 0)
            {
                if (newExam.AllSamePoints == true)
                {
                    Exercise exe = new Exercise();
                    NewExam.AddExe(exe);
                    float points = (100 / (float)NewExam.NumOfQuestions);
                    NewQuestion f3 = new NewQuestion(exe, points);
                    f3.ShowDialog();
                    QuestionsList.Items.Add("#" + question_number.ToString() + " - " + exe.ExeToString());
                    exercises.Add(exe.ExeToString());
                    SetNextQuestion();
                }
                else
                {
                    Exercise exe = new Exercise();
                    NewExam.AddExe(exe);
                    NewQuestion f3 = new NewQuestion(exe);
                    f3.ShowDialog();
                    QuestionsList.Items.Add("#" + question_number.ToString() + " - " + exe.ExeToString());
                    exercises.Add(exe.ExeToString());
                    SetNextQuestion();
                }
            }
            else
            {
                MessageBox.Show("No questions left to add");
            }
        }

        private void QuestionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void SetNextQuestion()
        {
            NumOfExe.Text = NewExam.QuestionsLeft().ToString();
            question_number++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float tmp_pts = GetTotPoints(newExam);
            if (tmp_pts == 100)
            {
                MessageBox.Show("You have 100 points! Press 'Save and quit' to finish exam!");
            }
            else
            {
                MessageBox.Show("You have total of: " + tmp_pts.ToString() + " points");
            }

        }
        public float GetTotPoints(Exam exam)
        {
            return exam.GetExamPoints();
        }
    }
}
