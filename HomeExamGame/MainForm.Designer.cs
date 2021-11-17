namespace HomeExamGame
{
    partial class MainForm
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
            this.StudentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentBtn
            // 
            this.StudentBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBtn.Location = new System.Drawing.Point(128, 249);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(230, 148);
            this.StudentBtn.TabIndex = 0;
            this.StudentBtn.Text = "I am a student!";
            this.StudentBtn.UseVisualStyleBackColor = true;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Choose An Option:";
            // 
            // TeacherBtn
            // 
            this.TeacherBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherBtn.Location = new System.Drawing.Point(364, 249);
            this.TeacherBtn.Name = "TeacherBtn";
            this.TeacherBtn.Size = new System.Drawing.Size(230, 148);
            this.TeacherBtn.TabIndex = 2;
            this.TeacherBtn.Text = "I am a teacher!";
            this.TeacherBtn.UseVisualStyleBackColor = true;
            this.TeacherBtn.Click += new System.EventHandler(this.TeacherBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeExamGame.Properties.Resources.LogoWallpaper;
            this.ClientSize = new System.Drawing.Size(728, 486);
            this.Controls.Add(this.TeacherBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TeacherBtn;
    }
}