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
    public partial class StudentMenu : Form
    {
        //Data Fields:
        //Initialaize all required list's for exercises:
        Student st;
        static List<Exercise> easy_plus_exercises_list = new List<Exercise>()
        {
            new Exercise("7+5","12"),
            new Exercise("6+9","15"),
            new Exercise("3+5","8"),
            new Exercise("4+3","7"),
            new Exercise("6+1","7"),
        };
        static List<Exercise> hard_plus_exercises_list = new List<Exercise>()
        {
            new Exercise("21+50","71"),
            new Exercise("16+19","35"),
            new Exercise("13+35","48"),
            new Exercise("11+13","24"),
            new Exercise("16+11","27"),
        };
        static List<Exercise> easy_minus_exercises_list = new List<Exercise>()
        {
            new Exercise("7-3","4"),
            new Exercise("9-2","7"),
            new Exercise("4-3","1"),
            new Exercise("5-3","2"),
            new Exercise("6-1","5"),
        };
        static List<Exercise> hard_minus_exercises_list = new List<Exercise>()
        {
            new Exercise("50-15","35"),
            new Exercise("25-12","13"),
            new Exercise("81-79","2"),
            new Exercise("74-21","53"),
            new Exercise("65-44","21"),
        };
        static List<Exercise> easy_multiply_exercises_list = new List<Exercise>()
        {
            new Exercise("2*7","14"),
            new Exercise("4*7","28"),
            new Exercise("4*3","12"),
            new Exercise("9*2","18"),
            new Exercise("5*7","35"),
            new Exercise("4*4","16"),
        };
        static List<Exercise> hard_multiply_exercises_list = new List<Exercise>()
        {
            new Exercise("27*2","54"),
            new Exercise("27*10","270"),
            new Exercise("18*12","216"),
            new Exercise("11*17","187"),
            new Exercise("21*10","210"),
        };
        static List<Exercise> easy_divide_exercises_list = new List<Exercise>()
        {
            new Exercise("6/3","2"),
            new Exercise("9/3","3"),
            new Exercise("8/2","4"),
            new Exercise("4/4","1"),
            new Exercise("8/4","2"),
        };
        static List<Exercise> hard_divide_exercises_list = new List<Exercise>()
        {
            new Exercise("110/11","10"),
            new Exercise("216/12","18"),
            new Exercise("187/11","17"),
            new Exercise("64/32","2"),
            new Exercise("232/21","11"),
        };
        static List<Exercise> easy_plusminus_exercises_list = new List<Exercise>()
        {
            new Exercise("9-4+3","8"),
            new Exercise("8-4+6","10"),
            new Exercise("9+3-2","10"),
            new Exercise("4-3-2+1","0"),
            new Exercise("8+5-3","10"),
            new Exercise("5+6-4","7"),
            new Exercise("3-2+1","2"),
        };
        static List<Exercise> hard_plusminus_exercises_list = new List<Exercise>()
        {
            new Exercise("22+44","66"),
            new Exercise("50-16","36"),
            new Exercise("16+35","51"),
            new Exercise("30-4","26"),
            new Exercise("25+32","57"),
            new Exercise("25-13","12"),
            new Exercise("41+9","50"),
        };
        static List<Exercise> easy_divmult_exercises_list = new List<Exercise>()
        {
            new Exercise("(6*6)/2","18"),
            new Exercise("(7*4)/7","4"),
            new Exercise("(8*8)/2","32"),
            new Exercise("(4*9)/6","6"),
            new Exercise("(8/2)*5","20"),
            new Exercise("(6/2)*4","12"),
            new Exercise("(8*1)/8","1"),
        };
        static List<Exercise> hard_divmult_exercises_list = new List<Exercise>()
        {
            new Exercise("(36*12)/36","12"),
            new Exercise("(12*4)/3","16"),
            new Exercise("(18/9)*10","20"),
            new Exercise("(14*2)/7","4"),
            new Exercise("(80/20)*5","20"),
            new Exercise("(16/2)*9","72"),
            new Exercise("(21*4)/2","42"),
        };
        static List<Exercise> easy_alltypes_exercises_list = new List<Exercise>()
        {
            new Exercise("(1+(2*3)-3)/4","1"),
            new Exercise("((4*3)-2)/5","2"),
            new Exercise("((9/3)+5-2)/2","3"),
            new Exercise("(12/4-3+1)*9","9"),
            new Exercise("(8/2)*3-4+2","10"),
        };
        static List<Exercise> hard_alltypes_exercises_list = new List<Exercise>()
        {
            new Exercise("(12*12)/6+6-10","20"),
            new Exercise("(12*10)/4-40+10","0"),
            new Exercise("(22/11)*13-3","23"),
            new Exercise("(19-12)/7*10","10"),
            new Exercise("(80/20)*11-4+1","41"),
        };
        static List<Exercise> easy_basic;
        static List<Exercise> hard_basic;
        int seleceted_exam_idx = 0;
        public enum Qtype 
        {
            basic = 1,
            plus_and_minus = 2,
            mult_and_div = 3,
            all_types = 4
        }
        Qtype last_chosen;
        List<Exam> examList;
        //Constructors:
        public StudentMenu()
        {
            InitializeComponent();
            examList = GetAllExams();
            if (examList.Count() == 0)
            {
                StartExamBtn.Enabled = false;
                ExamList.Enabled = false;
                ChooseExamLab.Text = "no exam's available";
            }
            else
            {
                foreach (Exam exam in examList)
                {
                    ExamList.Items.Add(exam.Exam_name);
                }
                ExamList.SetSelected(0, true);
            }
            last_chosen = Qtype.basic;
            easy_basic = new List<Exercise>();
            easy_basic.AddRange(easy_plus_exercises_list);
            easy_basic.AddRange(easy_minus_exercises_list);
            easy_basic.AddRange(easy_multiply_exercises_list);
            easy_basic.AddRange(easy_divide_exercises_list);
            easy_basic.AddRange(easy_plusminus_exercises_list);
            easy_basic.AddRange(easy_divmult_exercises_list);
            easy_basic.AddRange(easy_alltypes_exercises_list);
            hard_basic = new List<Exercise>();
            hard_basic.AddRange(hard_plus_exercises_list);
            hard_basic.AddRange(hard_minus_exercises_list);
            hard_basic.AddRange(hard_multiply_exercises_list);
            hard_basic.AddRange(hard_divide_exercises_list);
            hard_basic.AddRange(hard_plusminus_exercises_list);
            hard_basic.AddRange(hard_divmult_exercises_list);
            hard_basic.AddRange(hard_alltypes_exercises_list);

        }
        //Methods:
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void StartExeBtn_Click(object sender, EventArgs e)
        {
            if (IsGoodToGo() == true)
            {
                List<Exercise> selected=null;
                if(EasyRadBtn.Checked == true)
                {
                    switch (last_chosen)
                    {
                        case Qtype.basic:
                            selected = easy_basic;
                            break;

                        case Qtype.mult_and_div:
                            selected = easy_divmult_exercises_list;
                                break;

                        case Qtype.plus_and_minus:
                            selected = easy_plusminus_exercises_list;
                            break;

                        case Qtype.all_types:
                            selected = easy_alltypes_exercises_list;
                            break;
                    }
                }
                else
                {
                    switch (last_chosen)
                    {
                        case Qtype.basic:
                            selected = hard_basic;
                            break;

                        case Qtype.mult_and_div:
                            selected = hard_divmult_exercises_list;
                            break;

                        case Qtype.plus_and_minus:
                            selected = hard_plusminus_exercises_list;
                            break;

                        case Qtype.all_types:
                            selected = hard_alltypes_exercises_list;
                            break;
                    }

                }
                ActiveExercise new_exer = new ActiveExercise(selected);
                new_exer.ShowDialog();
            }
        }
        public bool IsGoodToGo()
        {
            if (LastName.Text != "" && FirstName.Text != "") return true;
            else
            {
                MessageBox.Show("Please make sure you entered your personal information");
                return false;
            }

        }
        private void StartExamBtn_Click(object sender, EventArgs e)
        {
            if (IsGoodToGo() == true)
            {
                ActiveExam newExam = new ActiveExam(examList.ElementAt(ExamList.SelectedIndex));
                newExam.ShowDialog();
                //Here you have all the exam

            }
        }
        private void AllSingleTypes_CheckedChanged(object sender, EventArgs e)
        {
            last_chosen = Qtype.basic;
        }
        private void PlusAndMinus_CheckedChanged(object sender, EventArgs e)
        {
            last_chosen = Qtype.plus_and_minus;
        }
        private void DivideAndMult_CheckedChanged(object sender, EventArgs e)
        {
            last_chosen = Qtype.mult_and_div;
        }
        private void AllTypes_CheckedChanged(object sender, EventArgs e)
        {
            last_chosen = Qtype.all_types;
        }
        public List<Exam> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();
            string[] files_name = System.IO.Directory.GetFiles(@"EXAMS");
            int exam_num = 1;
            foreach (var file_nm in files_name)
            {
                string exam_str = System.IO.File.ReadAllText(file_nm);
                exams.Add(new Exam(exam_str, "Exam number # " + exam_num));
                exam_num++;
            }
            return exams;
        }
        private void ExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExamList.SelectedIndex != seleceted_exam_idx)
            {
                seleceted_exam_idx = ExamList.SelectedIndex;
            }
        }
    }
}
