namespace HomeExamGame
{
    partial class StudentMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartExamBtn = new System.Windows.Forms.Button();
            this.StartExeBtn = new System.Windows.Forms.Button();
            this.HardRadBtn = new System.Windows.Forms.RadioButton();
            this.EasyRadBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllTypes = new System.Windows.Forms.RadioButton();
            this.DivideAndMult = new System.Windows.Forms.RadioButton();
            this.PlusAndMinus = new System.Windows.Forms.RadioButton();
            this.AllSingleTypes = new System.Windows.Forms.RadioButton();
            this.ExamList = new System.Windows.Forms.ListBox();
            this.ChooseExamLab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(158, 264);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(129, 20);
            this.FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(158, 290);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(129, 20);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome Student!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(275, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "please enter your info to start";
            // 
            // StartExamBtn
            // 
            this.StartExamBtn.Location = new System.Drawing.Point(504, 255);
            this.StartExamBtn.Margin = new System.Windows.Forms.Padding(1);
            this.StartExamBtn.Name = "StartExamBtn";
            this.StartExamBtn.Size = new System.Drawing.Size(146, 65);
            this.StartExamBtn.TabIndex = 7;
            this.StartExamBtn.Text = "Start Exam";
            this.StartExamBtn.UseVisualStyleBackColor = true;
            this.StartExamBtn.Click += new System.EventHandler(this.StartExamBtn_Click);
            // 
            // StartExeBtn
            // 
            this.StartExeBtn.Location = new System.Drawing.Point(304, 255);
            this.StartExeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.StartExeBtn.Name = "StartExeBtn";
            this.StartExeBtn.Size = new System.Drawing.Size(184, 65);
            this.StartExeBtn.TabIndex = 8;
            this.StartExeBtn.Text = "Start Exercise";
            this.StartExeBtn.UseVisualStyleBackColor = true;
            this.StartExeBtn.Click += new System.EventHandler(this.StartExeBtn_Click);
            // 
            // HardRadBtn
            // 
            this.HardRadBtn.AutoSize = true;
            this.HardRadBtn.BackColor = System.Drawing.Color.Transparent;
            this.HardRadBtn.ForeColor = System.Drawing.Color.White;
            this.HardRadBtn.Location = new System.Drawing.Point(393, 419);
            this.HardRadBtn.Name = "HardRadBtn";
            this.HardRadBtn.Size = new System.Drawing.Size(48, 17);
            this.HardRadBtn.TabIndex = 9;
            this.HardRadBtn.Text = "Hard";
            this.HardRadBtn.UseVisualStyleBackColor = false;
            // 
            // EasyRadBtn
            // 
            this.EasyRadBtn.AutoSize = true;
            this.EasyRadBtn.BackColor = System.Drawing.Color.Transparent;
            this.EasyRadBtn.Checked = true;
            this.EasyRadBtn.ForeColor = System.Drawing.Color.White;
            this.EasyRadBtn.Location = new System.Drawing.Point(339, 419);
            this.EasyRadBtn.Name = "EasyRadBtn";
            this.EasyRadBtn.Size = new System.Drawing.Size(48, 17);
            this.EasyRadBtn.TabIndex = 10;
            this.EasyRadBtn.TabStop = true;
            this.EasyRadBtn.Text = "Easy";
            this.EasyRadBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AllTypes);
            this.panel1.Controls.Add(this.DivideAndMult);
            this.panel1.Controls.Add(this.PlusAndMinus);
            this.panel1.Controls.Add(this.AllSingleTypes);
            this.panel1.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(304, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 91);
            this.panel1.TabIndex = 23;
            // 
            // AllTypes
            // 
            this.AllTypes.AutoSize = true;
            this.AllTypes.Location = new System.Drawing.Point(4, 68);
            this.AllTypes.Name = "AllTypes";
            this.AllTypes.Size = new System.Drawing.Size(68, 17);
            this.AllTypes.TabIndex = 3;
            this.AllTypes.Text = "All Types";
            this.AllTypes.UseVisualStyleBackColor = true;
            this.AllTypes.CheckedChanged += new System.EventHandler(this.AllTypes_CheckedChanged);
            // 
            // DivideAndMult
            // 
            this.DivideAndMult.AutoSize = true;
            this.DivideAndMult.Location = new System.Drawing.Point(4, 47);
            this.DivideAndMult.Name = "DivideAndMult";
            this.DivideAndMult.Size = new System.Drawing.Size(114, 17);
            this.DivideAndMult.TabIndex = 2;
            this.DivideAndMult.Text = "Divide and Multiply";
            this.DivideAndMult.UseVisualStyleBackColor = true;
            this.DivideAndMult.CheckedChanged += new System.EventHandler(this.DivideAndMult_CheckedChanged);
            // 
            // PlusAndMinus
            // 
            this.PlusAndMinus.AutoSize = true;
            this.PlusAndMinus.Location = new System.Drawing.Point(4, 25);
            this.PlusAndMinus.Name = "PlusAndMinus";
            this.PlusAndMinus.Size = new System.Drawing.Size(97, 17);
            this.PlusAndMinus.TabIndex = 1;
            this.PlusAndMinus.Text = "Plus and Minus";
            this.PlusAndMinus.UseVisualStyleBackColor = true;
            this.PlusAndMinus.CheckedChanged += new System.EventHandler(this.PlusAndMinus_CheckedChanged);
            // 
            // AllSingleTypes
            // 
            this.AllSingleTypes.AutoSize = true;
            this.AllSingleTypes.Checked = true;
            this.AllSingleTypes.Location = new System.Drawing.Point(4, 4);
            this.AllSingleTypes.Name = "AllSingleTypes";
            this.AllSingleTypes.Size = new System.Drawing.Size(153, 17);
            this.AllSingleTypes.TabIndex = 0;
            this.AllSingleTypes.TabStop = true;
            this.AllSingleTypes.Text = "Plus/Minus/Divide/Multiply";
            this.AllSingleTypes.UseVisualStyleBackColor = true;
            this.AllSingleTypes.CheckedChanged += new System.EventHandler(this.AllSingleTypes_CheckedChanged);
            // 
            // ExamList
            // 
            this.ExamList.FormattingEnabled = true;
            this.ExamList.Location = new System.Drawing.Point(504, 349);
            this.ExamList.Name = "ExamList";
            this.ExamList.Size = new System.Drawing.Size(146, 69);
            this.ExamList.TabIndex = 24;
            this.ExamList.SelectedIndexChanged += new System.EventHandler(this.ExamList_SelectedIndexChanged);
            // 
            // ChooseExamLab
            // 
            this.ChooseExamLab.AutoSize = true;
            this.ChooseExamLab.BackColor = System.Drawing.Color.Transparent;
            this.ChooseExamLab.ForeColor = System.Drawing.Color.White;
            this.ChooseExamLab.Location = new System.Drawing.Point(540, 328);
            this.ChooseExamLab.Name = "ChooseExamLab";
            this.ChooseExamLab.Size = new System.Drawing.Size(75, 13);
            this.ChooseExamLab.TabIndex = 25;
            this.ChooseExamLab.Text = "Choose Exam:";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeExamGame.Properties.Resources.LogoWallpaper1;
            this.ClientSize = new System.Drawing.Size(729, 486);
            this.Controls.Add(this.ChooseExamLab);
            this.Controls.Add(this.ExamList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EasyRadBtn);
            this.Controls.Add(this.HardRadBtn);
            this.Controls.Add(this.StartExeBtn);
            this.Controls.Add(this.StartExamBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Name = "StudentMenu";
            this.Text = "StudentSide";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartExamBtn;
        private System.Windows.Forms.Button StartExeBtn;
        private System.Windows.Forms.RadioButton HardRadBtn;
        private System.Windows.Forms.RadioButton EasyRadBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton AllTypes;
        private System.Windows.Forms.RadioButton DivideAndMult;
        private System.Windows.Forms.RadioButton PlusAndMinus;
        private System.Windows.Forms.RadioButton AllSingleTypes;
        private System.Windows.Forms.ListBox ExamList;
        private System.Windows.Forms.Label ChooseExamLab;
    }
}