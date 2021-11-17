namespace HomeExamGame
{
    partial class ActiveExercise
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
            this.components = new System.ComponentModel.Container();
            this.SendBtn = new System.Windows.Forms.Button();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.QuestionNum = new System.Windows.Forms.Label();
            this.QuestionsLabel = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.ExeTimer = new System.Windows.Forms.Timer(this.components);
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.TotPointsLabel = new System.Windows.Forms.Label();
            this.TotPoints = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(319, 292);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(87, 33);
            this.SendBtn.TabIndex = 13;
            this.SendBtn.Text = "Send!";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Visible = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeft.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.ForeColor = System.Drawing.Color.White;
            this.TimeLeft.Location = new System.Drawing.Point(103, 25);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(45, 36);
            this.TimeLeft.TabIndex = 12;
            this.TimeLeft.Text = "10";
            this.TimeLeft.Visible = false;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(24, 25);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(83, 36);
            this.TimerLabel.TabIndex = 11;
            this.TimerLabel.Text = "Timer";
            this.TimerLabel.Visible = false;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(278, 189);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(169, 59);
            this.Question.TabIndex = 10;
            this.Question.Text = "40+40=";
            this.Question.Visible = false;
            this.Question.Click += new System.EventHandler(this.label3_Click);
            // 
            // QuestionNum
            // 
            this.QuestionNum.AutoSize = true;
            this.QuestionNum.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNum.ForeColor = System.Drawing.Color.White;
            this.QuestionNum.Location = new System.Drawing.Point(390, 170);
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.Size = new System.Drawing.Size(17, 19);
            this.QuestionNum.TabIndex = 9;
            this.QuestionNum.Text = "1";
            this.QuestionNum.Visible = false;
            // 
            // QuestionsLabel
            // 
            this.QuestionsLabel.AutoSize = true;
            this.QuestionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionsLabel.Location = new System.Drawing.Point(315, 170);
            this.QuestionsLabel.Name = "QuestionsLabel";
            this.QuestionsLabel.Size = new System.Drawing.Size(80, 19);
            this.QuestionsLabel.TabIndex = 8;
            this.QuestionsLabel.Text = "Question #";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBox.Location = new System.Drawing.Point(253, 260);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(216, 26);
            this.AnswerBox.TabIndex = 7;
            this.AnswerBox.WordWrap = false;
            // 
            // ExeTimer
            // 
            this.ExeTimer.Interval = 1000;
            this.ExeTimer.Tick += new System.EventHandler(this.ExeTimer_Tick);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.FeedbackLabel.Location = new System.Drawing.Point(300, 37);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(107, 24);
            this.FeedbackLabel.TabIndex = 15;
            this.FeedbackLabel.Text = "Good Luck!";
            // 
            // TotPointsLabel
            // 
            this.TotPointsLabel.AutoSize = true;
            this.TotPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotPointsLabel.ForeColor = System.Drawing.Color.White;
            this.TotPointsLabel.Location = new System.Drawing.Point(42, 61);
            this.TotPointsLabel.Name = "TotPointsLabel";
            this.TotPointsLabel.Size = new System.Drawing.Size(65, 13);
            this.TotPointsLabel.TabIndex = 16;
            this.TotPointsLabel.Text = "Total points:";
            // 
            // TotPoints
            // 
            this.TotPoints.AutoSize = true;
            this.TotPoints.BackColor = System.Drawing.Color.Transparent;
            this.TotPoints.ForeColor = System.Drawing.Color.White;
            this.TotPoints.Location = new System.Drawing.Point(107, 61);
            this.TotPoints.Name = "TotPoints";
            this.TotPoints.Size = new System.Drawing.Size(13, 13);
            this.TotPoints.TabIndex = 17;
            this.TotPoints.Text = "0";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(194, 170);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(331, 172);
            this.StartBtn.TabIndex = 14;
            this.StartBtn.Text = "Press to start exercise!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ActiveExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeExamGame.Properties.Resources.MainWallpaper;
            this.ClientSize = new System.Drawing.Size(729, 486);
            this.Controls.Add(this.TotPoints);
            this.Controls.Add(this.TotPointsLabel);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.QuestionNum);
            this.Controls.Add(this.QuestionsLabel);
            this.Controls.Add(this.AnswerBox);
            this.Name = "ActiveExercise";
            this.Text = "ActiveExercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label QuestionNum;
        private System.Windows.Forms.Label QuestionsLabel;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Timer ExeTimer;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label TotPointsLabel;
        private System.Windows.Forms.Label TotPoints;
        private System.Windows.Forms.Button StartBtn;
    }
}