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
    public partial class NewQuestion : Form
    {
        //Data Fields:
        Exercise tmp_exe;
        int qnum = 0;
        float points = 0;
        //Properties:
        public Exercise Tmp_exe { get => tmp_exe; set => tmp_exe = value; }
        public int Qnum { get => qnum; set => qnum = value; }
        public float Points { get => points; set => points = value; }
        //Constructors:
        public NewQuestion(Exercise exe, float pts)
        {
            InitializeComponent();
            tmp_exe = exe;
            Points = pts;
            PointsResault.Text = pts.ToString();
            PointsResault.Enabled = false;
        }
        public NewQuestion(Exercise exe)
        {
            InitializeComponent();
            Tmp_exe = exe;
            Points = 0;
        }
        public NewQuestion()
        {

            InitializeComponent();
            
        }
        //Methods:
        private void One_Click(object sender, EventArgs e)
        {
            SetSymbol(1);
        }
        private void Three_Click(object sender, EventArgs e)
        {
            SetSymbol(3);
        }
        private void Four_Click(object sender, EventArgs e)
        {
            SetSymbol(4);
        }
        private void Five_Click(object sender, EventArgs e)
        {
            SetSymbol(5);
        }
        private void Six_Click(object sender, EventArgs e)
        {
            SetSymbol(6);
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            SetSymbol(8);
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            SetSymbol(9);
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            QuestionResault.Text += "+";
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            QuestionResault.Text += "-";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            SetSymbol(0);
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            if (Equal.Text != "Finish Answer")
            {
                if (PointsResault.Text != "")
                {
                    Equal.Enabled = false;
                }
                else
                {
                    Equal.Text = "Finish Answer";
                }
                QuestionResault.Enabled = false;
                QuestionResault.Text += "=";
                Divide.Enabled = false;
                Plus.Enabled = false;
                Sub.Enabled = false;
                Multiply.Enabled = false;
                LeftPar.Enabled = false;
                RightPar.Enabled = false;
            }
            else
            {
                AnswerResault.Enabled = false;
                Equal.Enabled = false;
            }
        }
        private void ClearChar_Click(object sender, EventArgs e)
        {
            if (QuestionResault.Enabled == false && AnswerResault.Enabled == false)
            {
                if (PointsResault.Text.Length == 1) PointsResault.Text = "0";
                else
                {
                    PointsResault.Text = PointsResault.Text.Remove(PointsResault.Text.Length - 1);
                }
            }
            else
            {
                if (QuestionResault.Enabled == true)
                {
                    if (QuestionResault.Text.Length == 1) QuestionResault.Text = "0";
                    else
                    {
                        QuestionResault.Text = QuestionResault.Text.Remove(QuestionResault.Text.Length - 1);
                    }
                }
                else
                {
                    if (AnswerResault.Text.Length == 1) AnswerResault.Text = "0";
                    else
                    {
                        AnswerResault.Text = AnswerResault.Text.Remove(AnswerResault.Text.Length - 1);
                    }
                }
            }
        }
        public void SetSymbol(int digit)
        {
            string strdigit = digit.ToString();
            if (QuestionResault.Enabled == true)
            {
                if (QuestionResault.Text == "0")
                {
                    QuestionResault.Text = strdigit;
                }
                else
                {
                    QuestionResault.Text += strdigit;
                }
            }
            else
            {
                if (AnswerResault.Text == "0" && AnswerResault.Enabled == true)
                {
                    AnswerResault.Text = strdigit;
                }
                else if (AnswerResault.Enabled == true)
                {
                    AnswerResault.Text += strdigit;
                }
            }
            if (QuestionResault.Enabled == false && AnswerResault.Enabled == false)
            {
                if (PointsResault.Text == "0")
                {
                    PointsResault.Text = strdigit;
                }
                else
                {
                    PointsResault.Text += strdigit;
                }
            }
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            if (QuestionResault.Enabled == false && AnswerResault.Enabled == false)
            {
                PointsResault.Text = "0";
            }
            else
            {
                if (QuestionResault.Enabled == true)
                {
                    QuestionResault.Text = "0";
                }
                else
                {
                    AnswerResault.Text = "0";
                }
            }
        }
        private void AddQuestion_Click(object sender, EventArgs e)
        {
            bool isOk;
            if (PointsResault.Text == "")
            {
                isOk = true;
            }
            else
            {
                isOk = (float.Parse(PointsResault.Text) > 0);
            }

            if (QuestionResault.Enabled == false && AnswerResault.Text != "" && PointsResault.Text !="" && isOk == true)
            {
                Points = float.Parse(PointsResault.Text);
                tmp_exe.Question = QuestionResault.Text;
                tmp_exe.Answer = AnswerResault.Text;
                tmp_exe.Points = Points;
                this.Close();
                //Exercise exe = new Exercise(2,QuestionResault.Text,AnswerResault.Text)
                //exerciselist.Enqueue(qnum.ToString() + QuestionResault.Text + ";" + AnswerResault.Text + ";" + "<" + points + ">");
                //qnum++;
                //listBox1.Items.Add("Question #" + qnum.ToString() + " - " + QuestionResault.Text + AnswerResault.Text);
                //ResetCalc();

            }
            else
            {
                if (QuestionResault.Enabled == false && AnswerResault.Text == "") MessageBox.Show("Your answer can not be null");
                else if (QuestionResault.Enabled == false && AnswerResault.Enabled == false) MessageBox.Show("The number of points canno't be equal or less than 0");  
                else  MessageBox.Show("Please enter your question and press the '=' to enter answer");
            }
        }
        private void Two_Click_1(object sender, EventArgs e)
        {
            SetSymbol(2);
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            QuestionResault.Text += "*";
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            QuestionResault.Text += "/";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            SetSymbol(7);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all exercises?", "Delete all items", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //listBox1.Items.Clear();
            }
        }
        private void LeftPar_Click(object sender, EventArgs e)
        {
            if (QuestionResault.Enabled == true)
            {
                if (QuestionResault.Text == "0")
                {
                    QuestionResault.Text = "(";
                }
                else
                {
                    QuestionResault.Text += "(";
                }
            }
        }
        private void RightPar_Click(object sender, EventArgs e)
        {
            if (QuestionResault.Enabled == true)
            {
                if (QuestionResault.Text == "0")
                {
                    QuestionResault.Text = ")";
                }
                else
                {
                    QuestionResault.Text += ")";
                }
            }
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (QuestionResault.Enabled == false && AnswerResault.Enabled == false)
            {
                if(PointsResault.Text != "") PointsResault.Text += ".";
            }
            else
            {
                if (QuestionResault.Enabled == true && QuestionResault.Text != "")
                {
                    QuestionResault.Text += ".";
                }
                else if (AnswerResault.Text != "")
                {
                    AnswerResault.Text += ".";
                }
            }
        }
        private void AnswerResault_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
