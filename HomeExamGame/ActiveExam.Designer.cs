namespace HomeExamGame
{
    partial class ActiveExam
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
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.QuestionNumLab = new System.Windows.Forms.Label();
            this.QuestionNum = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.TotQuestionPts = new System.Windows.Forms.Label();
            this.QuestionPts = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBox.Location = new System.Drawing.Point(258, 262);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(216, 26);
            this.AnswerBox.TabIndex = 0;
            // 
            // QuestionNumLab
            // 
            this.QuestionNumLab.AutoSize = true;
            this.QuestionNumLab.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNumLab.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumLab.ForeColor = System.Drawing.Color.White;
            this.QuestionNumLab.Location = new System.Drawing.Point(32, 37);
            this.QuestionNumLab.Name = "QuestionNumLab";
            this.QuestionNumLab.Size = new System.Drawing.Size(104, 26);
            this.QuestionNumLab.TabIndex = 1;
            this.QuestionNumLab.Text = "Question #";
            // 
            // QuestionNum
            // 
            this.QuestionNum.AutoSize = true;
            this.QuestionNum.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNum.ForeColor = System.Drawing.Color.White;
            this.QuestionNum.Location = new System.Drawing.Point(131, 37);
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.Size = new System.Drawing.Size(23, 26);
            this.QuestionNum.TabIndex = 2;
            this.QuestionNum.Text = "1";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(283, 191);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(169, 59);
            this.Question.TabIndex = 3;
            this.Question.Text = "40+40=";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(324, 294);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(87, 33);
            this.SendBtn.TabIndex = 6;
            this.SendBtn.Text = "Send!";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // TotQuestionPts
            // 
            this.TotQuestionPts.AutoSize = true;
            this.TotQuestionPts.BackColor = System.Drawing.Color.Transparent;
            this.TotQuestionPts.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotQuestionPts.ForeColor = System.Drawing.Color.White;
            this.TotQuestionPts.Location = new System.Drawing.Point(32, 63);
            this.TotQuestionPts.Name = "TotQuestionPts";
            this.TotQuestionPts.Size = new System.Drawing.Size(153, 26);
            this.TotQuestionPts.TabIndex = 7;
            this.TotQuestionPts.Text = "Question Points:";
            // 
            // QuestionPts
            // 
            this.QuestionPts.AutoSize = true;
            this.QuestionPts.BackColor = System.Drawing.Color.Transparent;
            this.QuestionPts.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionPts.ForeColor = System.Drawing.Color.White;
            this.QuestionPts.Location = new System.Drawing.Point(179, 63);
            this.QuestionPts.Name = "QuestionPts";
            this.QuestionPts.Size = new System.Drawing.Size(23, 26);
            this.QuestionPts.TabIndex = 8;
            this.QuestionPts.Text = "0";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(194, 170);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(331, 172);
            this.StartBtn.TabIndex = 15;
            this.StartBtn.Text = "Press to start exam!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ActiveExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeExamGame.Properties.Resources.MainWallpaper;
            this.ClientSize = new System.Drawing.Size(729, 486);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.QuestionPts);
            this.Controls.Add(this.TotQuestionPts);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.QuestionNum);
            this.Controls.Add(this.QuestionNumLab);
            this.Controls.Add(this.AnswerBox);
            this.Name = "ActiveExam";
            this.Text = "ActiveExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Label QuestionNumLab;
        private System.Windows.Forms.Label QuestionNum;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label TotQuestionPts;
        private System.Windows.Forms.Label QuestionPts;
        private System.Windows.Forms.Button StartBtn;
    }
}