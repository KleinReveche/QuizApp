namespace QuizApp.WinFormsUI.Forms
{
    partial class QuizForm
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
            components = new System.ComponentModel.Container();
            lblQuizName = new ReaLTaiizor.Controls.BigLabel();
            rbAnswer1 = new ReaLTaiizor.Controls.CyberRadioButton();
            lblQuestion = new ReaLTaiizor.Controls.BigLabel();
            rbAnswer4 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer3 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer2 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer5 = new ReaLTaiizor.Controls.CyberRadioButton();
            btnNext = new ReaLTaiizor.Controls.ForeverButton();
            panel1 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            lblTimer = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuizName
            // 
            lblQuizName.AutoSize = true;
            lblQuizName.BackColor = Color.Transparent;
            lblQuizName.Font = new Font("Segoe UI", 25F);
            lblQuizName.ForeColor = Color.FromArgb(80, 80, 80);
            lblQuizName.Location = new Point(12, 9);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(186, 46);
            lblQuizName.TabIndex = 0;
            lblQuizName.Text = "Quiz Name";
            // 
            // rbAnswer1
            // 
            rbAnswer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbAnswer1.BackColor = Color.Transparent;
            rbAnswer1.Background = true;
            rbAnswer1.Background_WidthPen = 2F;
            rbAnswer1.BackgroundPen = true;
            rbAnswer1.Checked = false;
            rbAnswer1.Color_1_Background_value = Color.Empty;
            rbAnswer1.Color_2_Background_value = Color.Empty;
            rbAnswer1.ColorBackground = Color.FromArgb(37, 52, 68);
            rbAnswer1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbAnswer1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbAnswer1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rbAnswer1.ColorChecked = Color.FromArgb(29, 200, 238);
            rbAnswer1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbAnswer1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbAnswer1.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbAnswer1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbAnswer1.Effect_1_Transparency = 25;
            rbAnswer1.Effect_2 = true;
            rbAnswer1.Effect_2_ColorBackground = Color.White;
            rbAnswer1.Effect_2_Transparency = 15;
            rbAnswer1.Font = new Font("Century Gothic", 16.2F);
            rbAnswer1.ForeColor = Color.FromArgb(245, 245, 245);
            rbAnswer1.LinearGradient_Background = false;
            rbAnswer1.LinearGradient_Value = false;
            rbAnswer1.LinearGradientPen = false;
            rbAnswer1.Location = new Point(8, 2);
            rbAnswer1.Name = "rbAnswer1";
            rbAnswer1.RGB = false;
            rbAnswer1.Rounding = true;
            rbAnswer1.RoundingInt = 100;
            rbAnswer1.Size = new Size(688, 45);
            rbAnswer1.SizeChecked = 8;
            rbAnswer1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer1.TabIndex = 1;
            rbAnswer1.Tag = "Cyber";
            rbAnswer1.TextButton = "Answer";
            rbAnswer1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer1.Timer_Effect_1 = 1;
            rbAnswer1.Timer_RGB = 300;
            rbAnswer1.Click += rbAnswer_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(43, 103);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(123, 60);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "lblQuestion\r\n\r\n";
            // 
            // rbAnswer4
            // 
            rbAnswer4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbAnswer4.BackColor = Color.Transparent;
            rbAnswer4.Background = true;
            rbAnswer4.Background_WidthPen = 2F;
            rbAnswer4.BackgroundPen = true;
            rbAnswer4.Checked = false;
            rbAnswer4.Color_1_Background_value = Color.Empty;
            rbAnswer4.Color_2_Background_value = Color.Empty;
            rbAnswer4.ColorBackground = Color.FromArgb(37, 52, 68);
            rbAnswer4.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbAnswer4.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbAnswer4.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rbAnswer4.ColorChecked = Color.FromArgb(29, 200, 238);
            rbAnswer4.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbAnswer4.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbAnswer4.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbAnswer4.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbAnswer4.Effect_1_Transparency = 25;
            rbAnswer4.Effect_2 = true;
            rbAnswer4.Effect_2_ColorBackground = Color.White;
            rbAnswer4.Effect_2_Transparency = 15;
            rbAnswer4.Font = new Font("Century Gothic", 16.2F);
            rbAnswer4.ForeColor = Color.FromArgb(245, 245, 245);
            rbAnswer4.LinearGradient_Background = false;
            rbAnswer4.LinearGradient_Value = false;
            rbAnswer4.LinearGradientPen = false;
            rbAnswer4.Location = new Point(8, 155);
            rbAnswer4.Name = "rbAnswer4";
            rbAnswer4.RGB = false;
            rbAnswer4.Rounding = true;
            rbAnswer4.RoundingInt = 100;
            rbAnswer4.Size = new Size(688, 45);
            rbAnswer4.SizeChecked = 8;
            rbAnswer4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer4.TabIndex = 3;
            rbAnswer4.Tag = "Cyber";
            rbAnswer4.TextButton = "Answer";
            rbAnswer4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer4.Timer_Effect_1 = 1;
            rbAnswer4.Timer_RGB = 300;
            rbAnswer4.Click += rbAnswer_Click;
            // 
            // rbAnswer3
            // 
            rbAnswer3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbAnswer3.BackColor = Color.Transparent;
            rbAnswer3.Background = true;
            rbAnswer3.Background_WidthPen = 2F;
            rbAnswer3.BackgroundPen = true;
            rbAnswer3.Checked = false;
            rbAnswer3.Color_1_Background_value = Color.Empty;
            rbAnswer3.Color_2_Background_value = Color.Empty;
            rbAnswer3.ColorBackground = Color.FromArgb(37, 52, 68);
            rbAnswer3.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbAnswer3.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbAnswer3.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rbAnswer3.ColorChecked = Color.FromArgb(29, 200, 238);
            rbAnswer3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbAnswer3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbAnswer3.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbAnswer3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbAnswer3.Effect_1_Transparency = 25;
            rbAnswer3.Effect_2 = true;
            rbAnswer3.Effect_2_ColorBackground = Color.White;
            rbAnswer3.Effect_2_Transparency = 15;
            rbAnswer3.Font = new Font("Century Gothic", 16.2F);
            rbAnswer3.ForeColor = Color.FromArgb(245, 245, 245);
            rbAnswer3.LinearGradient_Background = false;
            rbAnswer3.LinearGradient_Value = false;
            rbAnswer3.LinearGradientPen = false;
            rbAnswer3.Location = new Point(8, 104);
            rbAnswer3.Name = "rbAnswer3";
            rbAnswer3.RGB = false;
            rbAnswer3.Rounding = true;
            rbAnswer3.RoundingInt = 100;
            rbAnswer3.Size = new Size(688, 45);
            rbAnswer3.SizeChecked = 8;
            rbAnswer3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer3.TabIndex = 4;
            rbAnswer3.Tag = "Cyber";
            rbAnswer3.TextButton = "Answer";
            rbAnswer3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer3.Timer_Effect_1 = 1;
            rbAnswer3.Timer_RGB = 300;
            rbAnswer3.Click += rbAnswer_Click;
            // 
            // rbAnswer2
            // 
            rbAnswer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbAnswer2.BackColor = Color.Transparent;
            rbAnswer2.Background = true;
            rbAnswer2.Background_WidthPen = 2F;
            rbAnswer2.BackgroundPen = true;
            rbAnswer2.Checked = false;
            rbAnswer2.Color_1_Background_value = Color.Empty;
            rbAnswer2.Color_2_Background_value = Color.Empty;
            rbAnswer2.ColorBackground = Color.FromArgb(37, 52, 68);
            rbAnswer2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbAnswer2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbAnswer2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rbAnswer2.ColorChecked = Color.FromArgb(29, 200, 238);
            rbAnswer2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbAnswer2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbAnswer2.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbAnswer2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbAnswer2.Effect_1_Transparency = 25;
            rbAnswer2.Effect_2 = true;
            rbAnswer2.Effect_2_ColorBackground = Color.White;
            rbAnswer2.Effect_2_Transparency = 15;
            rbAnswer2.Font = new Font("Century Gothic", 16.2F);
            rbAnswer2.ForeColor = Color.FromArgb(245, 245, 245);
            rbAnswer2.LinearGradient_Background = false;
            rbAnswer2.LinearGradient_Value = false;
            rbAnswer2.LinearGradientPen = false;
            rbAnswer2.Location = new Point(8, 53);
            rbAnswer2.Name = "rbAnswer2";
            rbAnswer2.RGB = false;
            rbAnswer2.Rounding = true;
            rbAnswer2.RoundingInt = 100;
            rbAnswer2.Size = new Size(688, 45);
            rbAnswer2.SizeChecked = 8;
            rbAnswer2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer2.TabIndex = 5;
            rbAnswer2.Tag = "Cyber";
            rbAnswer2.TextButton = "Answer";
            rbAnswer2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer2.Timer_Effect_1 = 1;
            rbAnswer2.Timer_RGB = 300;
            rbAnswer2.Click += rbAnswer_Click;
            // 
            // rbAnswer5
            // 
            rbAnswer5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbAnswer5.BackColor = Color.Transparent;
            rbAnswer5.Background = true;
            rbAnswer5.Background_WidthPen = 2F;
            rbAnswer5.BackgroundPen = true;
            rbAnswer5.Checked = false;
            rbAnswer5.Color_1_Background_value = Color.Empty;
            rbAnswer5.Color_2_Background_value = Color.Empty;
            rbAnswer5.ColorBackground = Color.FromArgb(37, 52, 68);
            rbAnswer5.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbAnswer5.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbAnswer5.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rbAnswer5.ColorChecked = Color.FromArgb(29, 200, 238);
            rbAnswer5.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbAnswer5.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbAnswer5.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbAnswer5.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbAnswer5.Effect_1_Transparency = 25;
            rbAnswer5.Effect_2 = true;
            rbAnswer5.Effect_2_ColorBackground = Color.White;
            rbAnswer5.Effect_2_Transparency = 15;
            rbAnswer5.Font = new Font("Century Gothic", 16.2F);
            rbAnswer5.ForeColor = Color.FromArgb(245, 245, 245);
            rbAnswer5.LinearGradient_Background = false;
            rbAnswer5.LinearGradient_Value = false;
            rbAnswer5.LinearGradientPen = false;
            rbAnswer5.Location = new Point(8, 206);
            rbAnswer5.Name = "rbAnswer5";
            rbAnswer5.RGB = false;
            rbAnswer5.Rounding = true;
            rbAnswer5.RoundingInt = 100;
            rbAnswer5.Size = new Size(688, 45);
            rbAnswer5.SizeChecked = 8;
            rbAnswer5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer5.TabIndex = 6;
            rbAnswer5.Tag = "Cyber";
            rbAnswer5.TextButton = "Answer";
            rbAnswer5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer5.Timer_Effect_1 = 1;
            rbAnswer5.Timer_RGB = 300;
            rbAnswer5.Click += rbAnswer_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BaseColor = Color.FromArgb(255, 184, 117);
            btnNext.Font = new Font("Segoe UI", 12F);
            btnNext.Location = new Point(634, 512);
            btnNext.Name = "btnNext";
            btnNext.Rounded = true;
            btnNext.Size = new Size(115, 45);
            btnNext.TabIndex = 20;
            btnNext.Text = "Next";
            btnNext.TextColor = Color.FromArgb(75, 40, 0);
            btnNext.Click += btnNext_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbAnswer5);
            panel1.Controls.Add(rbAnswer2);
            panel1.Controls.Add(rbAnswer3);
            panel1.Controls.Add(rbAnswer4);
            panel1.Controls.Add(rbAnswer1);
            panel1.Location = new Point(43, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 254);
            panel1.TabIndex = 21;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Dock = DockStyle.Right;
            lblTimer.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.FromArgb(80, 80, 80);
            lblTimer.Location = new Point(720, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(80, 128);
            lblTimer.TabIndex = 22;
            lblTimer.Text = " ";
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 17);
            ClientSize = new Size(800, 600);
            Controls.Add(lblTimer);
            Controls.Add(panel1);
            Controls.Add(btnNext);
            Controls.Add(lblQuestion);
            Controls.Add(lblQuizName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += QuizForm_Load;
            KeyDown += QuizForm_KeyDown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblQuizName;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer1;
        private ReaLTaiizor.Controls.BigLabel lblQuestion;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer4;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer3;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer2;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer5;
        private ReaLTaiizor.Controls.ForeverButton btnNext;
        private Panel panel1;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.BigLabel lblTimer;
    }
}