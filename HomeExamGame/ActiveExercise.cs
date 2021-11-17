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
    public partial class ActiveExercise : Form
    {
        //Data Fields:
        List<Exercise> exe_list;
        Exercise current_exe;
        int question_index;
        List<bool> answer_res;
        int score;
        int highest_scr;
        int win_in_row;
        int exe_timer;
        //Constructors:
        public ActiveExercise(List<Exercise> selected_list)
        {
            question_index = 0;
            exe_list = new List<Exercise>();
            exe_list = selected_list;
            current_exe = exe_list.ElementAt(question_index);
            answer_res = new List<bool>();
            //questions = File.ReadAllLines(@"Exercises/questions.txt").ToList();
            //foreach (var question in questions)
            //{
            //    questions.Add(question);
            //}

            //newExe = new List<Exercise>();

            //answers;
            Score = 0;
            Highest_scr = 0;
            Win_in_row = 0;
            Exe_timer = 10;
            InitializeComponent();
            question_index--;
            SetNextQuestion();
            ExeTimer.Stop();
        }
        //Properties:
        public int Score { get => score; set => score = value; }
        public int Highest_scr { get => highest_scr; set => highest_scr = value; }
        public int Win_in_row { get => win_in_row; set => win_in_row = value; }
        public int Exe_timer { get => exe_timer; set => exe_timer = value; }
        //Methods:
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Visible = false;
            FeedbackLabel.Visible = false;
            StartExe();

        }
        public void StartExe()
        {
            ExeTimer.Start();
            FeedbackLabel.Visible = true;
            SendBtn.Visible = true;
            QuestionsLabel.Visible = true;
            AnswerBox.Visible = true;
            Question.Visible = true;
            QuestionNum.Visible = true;
            TimerLabel.Visible = true;
            TimeLeft.Visible = true;
        }
        private void ExeTimer_Tick(object sender, EventArgs e)
        {
            exe_timer--;
            TimeLeft.Text = exe_timer.ToString();
            if (exe_timer == -1)
            {
                SetNextQuestion();
                answer_res.Add(false);
                FeedbackLabel.Text = "Time is over!";
            }
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (question_index < exe_list.Count())
            {
                if (exe_list.ElementAt(question_index).Answer == AnswerBox.Text)
                {
                    score += 10;
                    TotPoints.Text = score.ToString();
                    answer_res.Add(true);
                    win_in_row++;
                    switch (win_in_row)
                    {

                        case 3:
                            {
                                ResetTimer();
                                score += 20;
                                FeedbackLabel.Text = "Wow, 3 in a row!\nExtra 20+ Points";
                                TotPoints.Text = score.ToString();
                                break;
                            }
                        case 5:
                            {
                                ResetTimer();
                                score += 50;
                                FeedbackLabel.Text = "Amazing, 5 in a row!\nExtra 50+ Points";
                                TotPoints.Text = score.ToString();
                                break;
                            }
                        case 10:
                            {
                                ResetTimer();
                                score += 100;
                                FeedbackLabel.Text = "incredible skills!\nExtra 100+ Points";
                                TotPoints.Text = score.ToString();
                                break;
                            }
                        default:
                            {
                                ResetTimer();
                                FeedbackLabel.Text = "Good Job!";
                                break;
                            }
                    }
                    SetNextQuestion();
                }
                else
                {
                    FeedbackLabel.Text = "Maybe next time!";
                    answer_res.Add(false);
                    SetNextQuestion();
                    win_in_row = 0;
                }
            }
            else
            {
                MessageBox.Show("The exercise is over!");
                ResaultForm res = new ResaultForm(exe_list, answer_res);
                res.ShowDialog();
                this.Close();
            }
        }
        public void SetNextQuestion()
        {
            //start timer here
            question_index++;
            if (question_index < exe_list.Count())
            {
                Question.Text = exe_list.ElementAt(question_index).Question;
                QuestionNum.Text = (question_index + 1).ToString();
                AnswerBox.Clear();
                ResetTimer();
            }
            else
            {
                ExeTimer.Stop();
                MessageBox.Show("The exercise is over!");
                ResaultForm res = new ResaultForm(exe_list, answer_res, score);
                res.ShowDialog();
                this.Close();
            }
        }
        public void ResetTimer()
        {
            ExeTimer.Stop();
            exe_timer = 10;
            TimeLeft.Text = exe_timer.ToString();
            ExeTimer.Start();
        }
    }
}
