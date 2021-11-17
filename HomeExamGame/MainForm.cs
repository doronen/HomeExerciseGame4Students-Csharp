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
    public partial class MainForm : Form
    {
        //Constructors:
        public MainForm()
        {
            InitializeComponent();
        }
        //Methods:
        private void TeacherBtn_Click(object sender, EventArgs e)
        {
            TeacherMenu f1 = new TeacherMenu();
            f1.ShowDialog();

        }
        private void StudentBtn_Click(object sender, EventArgs e)
        {
            StudentMenu f2 = new StudentMenu();
            f2.ShowDialog();
        }
    }
}
