namespace QuizApp.WinFormsUI.Controls
{
    partial class QuizzesAdmin
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
            BtnCreateQuiz = new ReaLTaiizor.Controls.ForeverButton();
            BtnImport = new ReaLTaiizor.Controls.ForeverButton();
            LblNoQuizAvailable = new ReaLTaiizor.Controls.BigLabel();
            listQuizzes = new ReaLTaiizor.Controls.RoyalListBox();
            btnDelete = new ReaLTaiizor.Controls.ForeverButton();
            btnSave = new ReaLTaiizor.Controls.ForeverButton();
            quizzesTabPage = new ReaLTaiizor.Controls.HopeTabPage();
            EditQuiz = new TabPage();
            EditBox = new ReaLTaiizor.Controls.HopeRichTextBox();
            tabPage2 = new TabPage();
            btnValidate = new ReaLTaiizor.Controls.ForeverButton();
            btnExport = new ReaLTaiizor.Controls.ForeverButton();
            quizzesTabPage.SuspendLayout();
            EditQuiz.SuspendLayout();
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
            lblWelcome.Size = new Size(266, 46);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Manage Quizzes";
            // 
            // BtnCreateQuiz
            // 
            BtnCreateQuiz.BackColor = Color.Transparent;
            BtnCreateQuiz.BaseColor = Color.FromArgb(229, 196, 146);
            BtnCreateQuiz.Font = new Font("Segoe UI", 12F);
            BtnCreateQuiz.Location = new Point(28, 80);
            BtnCreateQuiz.Name = "BtnCreateQuiz";
            BtnCreateQuiz.Rounded = true;
            BtnCreateQuiz.Size = new Size(189, 45);
            BtnCreateQuiz.TabIndex = 13;
            BtnCreateQuiz.Text = "Create New Quiz";
            BtnCreateQuiz.TextColor = Color.FromArgb(65, 45, 5);
            BtnCreateQuiz.Click += BtnCreateQuiz_Click;
            // 
            // BtnImport
            // 
            BtnImport.BackColor = Color.Transparent;
            BtnImport.BaseColor = Color.FromArgb(68, 41, 40);
            BtnImport.Font = new Font("Segoe UI", 12F);
            BtnImport.Location = new Point(237, 80);
            BtnImport.Name = "BtnImport";
            BtnImport.Rounded = true;
            BtnImport.Size = new Size(115, 45);
            BtnImport.TabIndex = 15;
            BtnImport.Text = "Import Quiz";
            BtnImport.TextColor = Color.FromArgb(230, 189, 186);
            BtnImport.Click += BtnImport_Click;
            // 
            // LblNoQuizAvailable
            // 
            LblNoQuizAvailable.AutoSize = true;
            LblNoQuizAvailable.BackColor = Color.Transparent;
            LblNoQuizAvailable.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNoQuizAvailable.ForeColor = Color.FromArgb(80, 80, 80);
            LblNoQuizAvailable.Location = new Point(28, 171);
            LblNoQuizAvailable.Name = "LblNoQuizAvailable";
            LblNoQuizAvailable.Size = new Size(216, 30);
            LblNoQuizAvailable.TabIndex = 16;
            LblNoQuizAvailable.Text = "No Quizzes Available";
            LblNoQuizAvailable.Visible = false;
            // 
            // listQuizzes
            // 
            listQuizzes.BackColor = Color.FromArgb(50, 40, 39);
            listQuizzes.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listQuizzes.HotLightColor = Color.FromArgb(221, 221, 221);
            listQuizzes.HotLightedIndex = -1;
            listQuizzes.ItemHeight = 40;
            listQuizzes.Location = new Point(28, 131);
            listQuizzes.MultiSelection = false;
            listQuizzes.Name = "listQuizzes";
            listQuizzes.SelectedColor = Color.FromArgb(115, 51, 51);
            listQuizzes.SelectedIndex = -1;
            listQuizzes.Size = new Size(334, 644);
            listQuizzes.TabIndex = 17;
            listQuizzes.Text = "royalListBox1";
            listQuizzes.Click += ListQuizzes_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BaseColor = Color.FromArgb(147, 0, 10);
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(1263, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Rounded = true;
            btnDelete.Size = new Size(71, 45);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.FromArgb(255, 180, 171);
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.Transparent;
            btnSave.BaseColor = Color.FromArgb(90, 67, 25);
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(1109, 80);
            btnSave.Name = "btnSave";
            btnSave.Rounded = true;
            btnSave.Size = new Size(71, 45);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.FromArgb(255, 222, 170);
            btnSave.Click += BtnSave_Click;
            // 
            // quizzesTabPage
            // 
            quizzesTabPage.BaseColor = Color.FromArgb(44, 55, 66);
            quizzesTabPage.Controls.Add(EditQuiz);
            quizzesTabPage.Controls.Add(tabPage2);
            quizzesTabPage.Font = new Font("Segoe UI", 12F);
            quizzesTabPage.ForeColorA = Color.Silver;
            quizzesTabPage.ForeColorB = Color.Gray;
            quizzesTabPage.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            quizzesTabPage.ItemSize = new Size(120, 40);
            quizzesTabPage.Location = new Point(368, 131);
            quizzesTabPage.Name = "quizzesTabPage";
            quizzesTabPage.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            quizzesTabPage.SelectedIndex = 0;
            quizzesTabPage.Size = new Size(966, 644);
            quizzesTabPage.SizeMode = TabSizeMode.Fixed;
            quizzesTabPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            quizzesTabPage.TabIndex = 22;
            quizzesTabPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            quizzesTabPage.ThemeColorA = Color.FromArgb(64, 158, 255);
            quizzesTabPage.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            quizzesTabPage.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // EditQuiz
            // 
            EditQuiz.Controls.Add(EditBox);
            EditQuiz.Location = new Point(0, 40);
            EditQuiz.Name = "EditQuiz";
            EditQuiz.Padding = new Padding(3);
            EditQuiz.Size = new Size(966, 604);
            EditQuiz.TabIndex = 0;
            EditQuiz.Text = "Edit Quiz";
            EditQuiz.UseVisualStyleBackColor = true;
            // 
            // EditBox
            // 
            EditBox.BorderColor = Color.FromArgb(220, 223, 230);
            EditBox.Font = new Font("Segoe UI", 12F);
            EditBox.ForeColor = Color.FromArgb(48, 49, 51);
            EditBox.Hint = "";
            EditBox.HoverBorderColor = Color.FromArgb(64, 158, 255);
            EditBox.Location = new Point(0, 0);
            EditBox.MaxLength = 32767;
            EditBox.Multiline = true;
            EditBox.Name = "EditBox";
            EditBox.PasswordChar = '\0';
            EditBox.ScrollBars = ScrollBars.None;
            EditBox.SelectedText = "";
            EditBox.SelectionLength = 0;
            EditBox.SelectionStart = 0;
            EditBox.Size = new Size(966, 616);
            EditBox.TabIndex = 0;
            EditBox.TabStop = false;
            EditBox.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(966, 604);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Soon";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            btnValidate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnValidate.BackColor = Color.Transparent;
            btnValidate.BaseColor = Color.FromArgb(93, 63, 62);
            btnValidate.Font = new Font("Segoe UI", 12F);
            btnValidate.Location = new Point(1032, 80);
            btnValidate.Name = "btnValidate";
            btnValidate.Rounded = true;
            btnValidate.Size = new Size(71, 45);
            btnValidate.TabIndex = 23;
            btnValidate.Text = "Validate";
            btnValidate.TextColor = Color.FromArgb(255, 222, 170);
            btnValidate.Click += BtnValidate_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.Transparent;
            btnExport.BaseColor = Color.FromArgb(90, 67, 25);
            btnExport.Font = new Font("Segoe UI", 12F);
            btnExport.Location = new Point(1186, 80);
            btnExport.Name = "btnExport";
            btnExport.Rounded = true;
            btnExport.Size = new Size(71, 45);
            btnExport.TabIndex = 24;
            btnExport.Text = "Export";
            btnExport.TextColor = Color.FromArgb(255, 222, 170);
            btnExport.Click += btnExport_Click;
            // 
            // QuizzesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnExport);
            Controls.Add(btnValidate);
            Controls.Add(quizzesTabPage);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(BtnImport);
            Controls.Add(BtnCreateQuiz);
            Controls.Add(lblWelcome);
            Controls.Add(LblNoQuizAvailable);
            Controls.Add(listQuizzes);
            Name = "QuizzesAdmin";
            Size = new Size(1337, 787);
            Load += QuizzesAdmin_Load;
            Layout += QuizzesAdmin_Layout;
            quizzesTabPage.ResumeLayout(false);
            EditQuiz.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private ReaLTaiizor.Controls.ForeverButton BtnCreateQuiz;
        private ReaLTaiizor.Controls.ForeverButton BtnImport;
        private ReaLTaiizor.Controls.BigLabel LblNoQuizAvailable;
        private ReaLTaiizor.Controls.RoyalListBox listQuizzes;
        private ReaLTaiizor.Controls.ForeverButton btnDelete;
        private ReaLTaiizor.Controls.ForeverButton btnSave;
        private ReaLTaiizor.Controls.HopeTabPage quizzesTabPage;
        private TabPage EditQuiz;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.HopeRichTextBox EditBox;
        private ReaLTaiizor.Controls.ForeverButton btnValidate;
        private ReaLTaiizor.Controls.ForeverButton btnExport;
    }
}
