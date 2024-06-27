namespace QuizApp.WinFormsUI.Controls
{
    partial class QuizzesStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblWelcome = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(663, 519);
            button1.Name = "button1";
            button1.Size = new Size(483, 187);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 25F);
            lblWelcome.ForeColor = Color.FromArgb(255, 179, 176);
            lblWelcome.Location = new Point(16, 16);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(135, 46);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Quizzes";
            // 
            // Quizzes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lblWelcome);
            Controls.Add(button1);
            Name = "Quizzes";
            Size = new Size(1149, 709);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
    }
}
