using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeExamGame
{
    public partial class ActiveExam : Form
    {
        //Data Fields:
        float question_pts;
        List<Exercise> exe_list;
        Exercise current_exe;
        int question_index;
        List<bool> answer_res;
        //Constructors:
        public ActiveExam(Exam new_exam)
        {
            question_pts = 0;
            exe_list = new_exam.exercises;
            answer_res = new List<bool>();
            current_exe = exe_list.ElementAt(question_index);
            question_index = 0;
            InitializeComponent();
            TotQuestionPts.Visible = false;
            QuestionPts.Visible = false;
            Question.Visible = false;
            QuestionNum.Visible = false;
            QuestionNumLab.Visible = false;
            AnswerBox.Visible = false;
            SendBtn.Visible = false;
            SetFirstQuestion();
        }
        //Methods:
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Visible = false;
            SetExam();
        }
        public void SetExam()
        {
            TotQuestionPts.Visible = true;
            QuestionPts.Visible = true;
            Question.Visible = true;
            QuestionNum.Visible = true;
            QuestionNumLab.Visible = true;
            AnswerBox.Visible = true;
            SendBtn.Visible = true;
        }
        public void SetFirstQuestion()
        {
            question_pts = exe_list.ElementAt(question_index).Points.Value;
            QuestionPts.Text = question_pts.ToString();
            Question.Text = exe_list.ElementAt(question_index).Question;
            QuestionNum.Text = (question_index + 1).ToString();
            AnswerBox.Clear();
        }
        public void SetNextQuestion()
        {
            question_index++;
            question_pts = exe_list.ElementAt(question_index).Points.Value;
            QuestionPts.Text = question_pts.ToString();
            Question.Text = exe_list.ElementAt(question_index).Question;
            QuestionNum.Text = (question_index + 1).ToString();
            AnswerBox.Clear();
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (exe_list.ElementAt(question_index).Answer == AnswerBox.Text)
            {
                answer_res.Add(true);
            }
            else
            {
                answer_res.Add(false);
            }

            if (question_index < exe_list.Count() - 1)
            {
                SetNextQuestion();
            }
            else
            {
                MessageBox.Show("The exam is over!");
                ResaultForm res = new ResaultForm(exe_list, answer_res);
                res.ShowDialog();
                this.Close();
            }
        }
    }
}
