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

    public partial class TeacherMenu : Form
    {
        //Data Fields:
        List<Exam> exam_list = new List<Exam>();
        int Pointer = 0;
        //Constructors:
        public TeacherMenu()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NumOfQuestion.Text != "" && IsDigitsOnly(NumOfQuestion.Text) == true)
            {
                Exam tmp = new Exam(int.Parse(NumOfQuestion.Text), SamePoints.Checked);
                exam_list.Add(tmp);
                ExamCreation f2 = new ExamCreation(tmp);

                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("The number of questions must contain digits only");
            }
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
