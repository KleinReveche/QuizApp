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
            lblWelcome = new ReaLTaiizor.Controls.BigLabel();
            lblNoQuiz = new ReaLTaiizor.Controls.BigLabel();
            grpBxUserDetails = new ReaLTaiizor.Controls.HopeGroupBox();
            lblOverallScore = new Label();
            lblDateDone = new Label();
            lblQuizName = new Label();
            btnTakeQuiz = new ReaLTaiizor.Controls.ForeverButton();
            label1 = new Label();
            lblScoreText = new Label();
            lblDateTaken = new Label();
            listUsers = new ReaLTaiizor.Controls.MetroListBox();
            grpBxUserDetails.SuspendLayout();
            SuspendLayout();
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
            // lblNoQuiz
            // 
            lblNoQuiz.AutoSize = true;
            lblNoQuiz.BackColor = Color.Transparent;
            lblNoQuiz.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoQuiz.ForeColor = Color.FromArgb(80, 80, 80);
            lblNoQuiz.Location = new Point(27, 84);
            lblNoQuiz.Name = "lblNoQuiz";
            lblNoQuiz.Size = new Size(428, 30);
            lblNoQuiz.TabIndex = 18;
            lblNoQuiz.Text = "Great! No quizzes available at the moment.";
            lblNoQuiz.Visible = false;
            // 
            // grpBxUserDetails
            // 
            grpBxUserDetails.BorderColor = Color.FromArgb(255, 222, 170);
            grpBxUserDetails.Controls.Add(lblOverallScore);
            grpBxUserDetails.Controls.Add(lblDateDone);
            grpBxUserDetails.Controls.Add(lblQuizName);
            grpBxUserDetails.Controls.Add(btnTakeQuiz);
            grpBxUserDetails.Controls.Add(label1);
            grpBxUserDetails.Controls.Add(lblScoreText);
            grpBxUserDetails.Controls.Add(lblDateTaken);
            grpBxUserDetails.Font = new Font("Segoe UI", 12F);
            grpBxUserDetails.ForeColor = Color.FromArgb(48, 49, 51);
            grpBxUserDetails.LineColor = Color.FromArgb(255, 222, 170);
            grpBxUserDetails.Location = new Point(392, 85);
            grpBxUserDetails.Name = "grpBxUserDetails";
            grpBxUserDetails.ShowText = false;
            grpBxUserDetails.Size = new Size(430, 291);
            grpBxUserDetails.TabIndex = 25;
            grpBxUserDetails.TabStop = false;
            grpBxUserDetails.ThemeColor = Color.FromArgb(61, 50, 50);
            grpBxUserDetails.Visible = false;
            // 
            // lblOverallScore
            // 
            lblOverallScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblOverallScore.AutoSize = true;
            lblOverallScore.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOverallScore.ForeColor = Color.FromArgb(255, 249, 249);
            lblOverallScore.Location = new Point(331, 142);
            lblOverallScore.Margin = new Padding(4, 0, 4, 0);
            lblOverallScore.Name = "lblOverallScore";
            lblOverallScore.RightToLeft = RightToLeft.No;
            lblOverallScore.Size = new Size(70, 25);
            lblOverallScore.TabIndex = 35;
            lblOverallScore.Text = "30/30";
            lblOverallScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateDone
            // 
            lblDateDone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateDone.AutoSize = true;
            lblDateDone.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateDone.ForeColor = Color.FromArgb(255, 249, 249);
            lblDateDone.Location = new Point(273, 101);
            lblDateDone.Margin = new Padding(4, 0, 4, 0);
            lblDateDone.Name = "lblDateDone";
            lblDateDone.RightToLeft = RightToLeft.No;
            lblDateDone.Size = new Size(128, 25);
            lblDateDone.TabIndex = 34;
            lblDateDone.Text = "09/13/2003";
            lblDateDone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblQuizName
            // 
            lblQuizName.Anchor = AnchorStyles.None;
            lblQuizName.AutoSize = true;
            lblQuizName.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizName.ForeColor = Color.FromArgb(255, 249, 249);
            lblQuizName.Location = new Point(30, 43);
            lblQuizName.Margin = new Padding(4, 0, 4, 0);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(159, 32);
            lblQuizName.TabIndex = 29;
            lblQuizName.Text = "Quiz Name";
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.BackColor = Color.Transparent;
            btnTakeQuiz.BaseColor = Color.FromArgb(255, 184, 117);
            btnTakeQuiz.Enabled = false;
            btnTakeQuiz.Font = new Font("Segoe UI", 12F);
            btnTakeQuiz.Location = new Point(286, 217);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Rounded = true;
            btnTakeQuiz.Size = new Size(115, 45);
            btnTakeQuiz.TabIndex = 28;
            btnTakeQuiz.Text = "Take Quiz";
            btnTakeQuiz.TextColor = Color.FromArgb(75, 40, 0);
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 249, 249);
            label1.Location = new Point(261, 204);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 25);
            label1.TabIndex = 32;
            label1.Text = " ";
            // 
            // lblScoreText
            // 
            lblScoreText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblScoreText.AutoSize = true;
            lblScoreText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreText.ForeColor = Color.FromArgb(255, 249, 249);
            lblScoreText.Location = new Point(34, 142);
            lblScoreText.Margin = new Padding(4, 0, 4, 0);
            lblScoreText.Name = "lblScoreText";
            lblScoreText.Size = new Size(72, 25);
            lblScoreText.TabIndex = 29;
            lblScoreText.Text = "Score";
            // 
            // lblDateTaken
            // 
            lblDateTaken.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateTaken.AutoSize = true;
            lblDateTaken.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTaken.ForeColor = Color.FromArgb(255, 249, 249);
            lblDateTaken.Location = new Point(30, 101);
            lblDateTaken.Margin = new Padding(4, 0, 4, 0);
            lblDateTaken.Name = "lblDateTaken";
            lblDateTaken.Size = new Size(135, 25);
            lblDateTaken.TabIndex = 28;
            lblDateTaken.Text = "Date Taken";
            // 
            // listUsers
            // 
            listUsers.BackColor = Color.FromArgb(50, 40, 39);
            listUsers.BorderColor = Color.FromArgb(64, 64, 64);
            listUsers.DisabledBackColor = Color.FromArgb(80, 80, 80);
            listUsers.DisabledForeColor = Color.FromArgb(109, 109, 109);
            listUsers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUsers.HoveredItemBackColor = Color.FromArgb(186, 100, 100);
            listUsers.HoveredItemColor = Color.FromArgb(64, 64, 64);
            listUsers.IsDerivedStyle = false;
            listUsers.ItemHeight = 40;
            listUsers.Location = new Point(27, 85);
            listUsers.MultiSelect = false;
            listUsers.Name = "listUsers";
            listUsers.SelectedIndex = -1;
            listUsers.SelectedItem = null;
            listUsers.SelectedItemBackColor = Color.FromArgb(115, 51, 51);
            listUsers.SelectedItemColor = Color.White;
            listUsers.SelectedText = null;
            listUsers.SelectedValue = null;
            listUsers.ShowBorder = false;
            listUsers.ShowScrollBar = true;
            listUsers.Size = new Size(359, 644);
            listUsers.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            listUsers.StyleManager = null;
            listUsers.TabIndex = 26;
            listUsers.ThemeAuthor = "Taiizor";
            listUsers.ThemeName = "MetroDark";
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;
            // 
            // QuizzesStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(grpBxUserDetails);
            Controls.Add(listUsers);
            Controls.Add(lblNoQuiz);
            Controls.Add(lblWelcome);
            Name = "QuizzesStudent";
            Size = new Size(1149, 764);
            Load += QuizzesStudent_Load;
            Layout += QuizzesStudent_Layout;
            grpBxUserDetails.ResumeLayout(false);
            grpBxUserDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private ReaLTaiizor.Controls.BigLabel lblNoQuiz;
        private ReaLTaiizor.Controls.HopeGroupBox grpBxUserDetails;
        private Label lblQuizName;
        private ReaLTaiizor.Controls.MetroListBox listUsers;
        private Label lblScoreText;
        private Label lblDateTaken;
        private Label label1;
        private ReaLTaiizor.Controls.ForeverButton btnTakeQuiz;
        private Label lblOverallScore;
        private Label lblDateDone;
    }
}
