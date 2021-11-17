namespace HomeExamGame
{
    partial class ExamCreation
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.QuestionsList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfExe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 23);
            this.button1.TabIndex = 92;
            this.button1.Text = "Save And Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 104);
            this.button2.TabIndex = 93;
            this.button2.Text = "Calculate Total Points";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(142, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 33);
            this.label19.TabIndex = 94;
            this.label19.Text = "Build your exam";
            // 
            // QuestionsList
            // 
            this.QuestionsList.FormattingEnabled = true;
            this.QuestionsList.Location = new System.Drawing.Point(35, 124);
            this.QuestionsList.Name = "QuestionsList";
            this.QuestionsList.Size = new System.Drawing.Size(261, 108);
            this.QuestionsList.TabIndex = 95;
            this.QuestionsList.SelectedIndexChanged += new System.EventHandler(this.QuestionsList_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(414, 47);
            this.button3.TabIndex = 96;
            this.button3.Text = "Add New Question";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "You have             questions left to add";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NumOfExe
            // 
            this.NumOfExe.AutoSize = true;
            this.NumOfExe.BackColor = System.Drawing.Color.Transparent;
            this.NumOfExe.Location = new System.Drawing.Point(225, 263);
            this.NumOfExe.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NumOfExe.Name = "NumOfExe";
            this.NumOfExe.Size = new System.Drawing.Size(13, 13);
            this.NumOfExe.TabIndex = 99;
            this.NumOfExe.Text = "0";
            this.NumOfExe.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExamCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 293);
            this.Controls.Add(this.NumOfExe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.QuestionsList);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ExamCreation";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox QuestionsList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumOfExe;
    }
}