using QuizApp.WinFormsUI.Properties;

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
            lblNoQuizAvailable = new ReaLTaiizor.Controls.BigLabel();
            btnDelete = new ReaLTaiizor.Controls.ForeverButton();
            btnSave = new ReaLTaiizor.Controls.ForeverButton();
            quizzesTabPage = new ReaLTaiizor.Controls.HopeTabPage();
            tabEditQuiz = new TabPage();
            panelQuestion = new Panel();
            boxAnswer5 = new ReaLTaiizor.Controls.HopeTextBox();
            lblQuestion = new ReaLTaiizor.Controls.BigLabel();
            boxAnswer4 = new ReaLTaiizor.Controls.HopeTextBox();
            boxQuestion = new ReaLTaiizor.Controls.HopeRichTextBox();
            boxAnswer2 = new ReaLTaiizor.Controls.HopeTextBox();
            boxAnswer3 = new ReaLTaiizor.Controls.HopeTextBox();
            boxAnswer1 = new ReaLTaiizor.Controls.HopeTextBox();
            rbAnswer5 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer2 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer3 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer4 = new ReaLTaiizor.Controls.CyberRadioButton();
            rbAnswer1 = new ReaLTaiizor.Controls.CyberRadioButton();
            fbAddQuestion = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            listQuestions = new ReaLTaiizor.Controls.MetroListBox();
            editRawQuizTab = new TabPage();
            editBox = new ReaLTaiizor.Controls.HopeRichTextBox();
            btnValidate = new ReaLTaiizor.Controls.ForeverButton();
            btnExport = new ReaLTaiizor.Controls.ForeverButton();
            listQuizzes = new ReaLTaiizor.Controls.MetroListBox();
            btnTest = new ReaLTaiizor.Controls.ForeverButton();
            boxQuizName = new ReaLTaiizor.Controls.HopeTextBox();
            lblTimer = new ReaLTaiizor.Controls.BigLabel();
            lblQuizName = new ReaLTaiizor.Controls.BigLabel();
            panelQuiz = new Panel();
            timer = new ReaLTaiizor.Controls.HopeNumeric();
            fbSave = new ReaLTaiizor.Controls.MaterialFloatingActionButton();
            quizzesTabPage.SuspendLayout();
            tabEditQuiz.SuspendLayout();
            panelQuestion.SuspendLayout();
            editRawQuizTab.SuspendLayout();
            panelQuiz.SuspendLayout();
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
            BtnCreateQuiz.Size = new Size(164, 45);
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
            BtnImport.Location = new Point(198, 80);
            BtnImport.Name = "BtnImport";
            BtnImport.Rounded = true;
            BtnImport.Size = new Size(115, 45);
            BtnImport.TabIndex = 15;
            BtnImport.Text = "Import Quiz";
            BtnImport.TextColor = Color.FromArgb(230, 189, 186);
            BtnImport.Click += BtnImport_Click;
            // 
            // lblNoQuizAvailable
            // 
            lblNoQuizAvailable.AutoSize = true;
            lblNoQuizAvailable.BackColor = Color.Transparent;
            lblNoQuizAvailable.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoQuizAvailable.ForeColor = Color.FromArgb(80, 80, 80);
            lblNoQuizAvailable.Location = new Point(28, 171);
            lblNoQuizAvailable.Name = "lblNoQuizAvailable";
            lblNoQuizAvailable.Size = new Size(216, 30);
            lblNoQuizAvailable.TabIndex = 16;
            lblNoQuizAvailable.Text = "No Quizzes Available";
            lblNoQuizAvailable.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BaseColor = Color.FromArgb(147, 0, 10);
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(1029, 4);
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
            btnSave.Location = new Point(875, 4);
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
            quizzesTabPage.Controls.Add(tabEditQuiz);
            quizzesTabPage.Controls.Add(editRawQuizTab);
            quizzesTabPage.Font = new Font("Segoe UI", 12F);
            quizzesTabPage.ForeColorA = Color.Silver;
            quizzesTabPage.ForeColorB = Color.Gray;
            quizzesTabPage.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            quizzesTabPage.ItemSize = new Size(120, 40);
            quizzesTabPage.Location = new Point(319, 131);
            quizzesTabPage.Name = "quizzesTabPage";
            quizzesTabPage.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            quizzesTabPage.SelectedIndex = 0;
            quizzesTabPage.Size = new Size(1040, 644);
            quizzesTabPage.SizeMode = TabSizeMode.Fixed;
            quizzesTabPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            quizzesTabPage.TabIndex = 22;
            quizzesTabPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            quizzesTabPage.ThemeColorA = Color.FromArgb(64, 158, 255);
            quizzesTabPage.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            quizzesTabPage.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabEditQuiz
            // 
            tabEditQuiz.BackColor = Color.FromArgb(64, 49, 48);
            tabEditQuiz.Controls.Add(fbSave);
            tabEditQuiz.Controls.Add(panelQuestion);
            tabEditQuiz.Controls.Add(fbAddQuestion);
            tabEditQuiz.Controls.Add(listQuestions);
            tabEditQuiz.Location = new Point(0, 40);
            tabEditQuiz.Name = "tabEditQuiz";
            tabEditQuiz.Padding = new Padding(3);
            tabEditQuiz.Size = new Size(1040, 604);
            tabEditQuiz.TabIndex = 1;
            tabEditQuiz.Text = "Edit Quiz";
            // 
            // panelQuestion
            // 
            panelQuestion.Controls.Add(boxAnswer5);
            panelQuestion.Controls.Add(lblQuestion);
            panelQuestion.Controls.Add(boxAnswer4);
            panelQuestion.Controls.Add(boxQuestion);
            panelQuestion.Controls.Add(boxAnswer2);
            panelQuestion.Controls.Add(boxAnswer3);
            panelQuestion.Controls.Add(boxAnswer1);
            panelQuestion.Controls.Add(rbAnswer5);
            panelQuestion.Controls.Add(rbAnswer2);
            panelQuestion.Controls.Add(rbAnswer3);
            panelQuestion.Controls.Add(rbAnswer4);
            panelQuestion.Controls.Add(rbAnswer1);
            panelQuestion.Location = new Point(466, 22);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(563, 455);
            panelQuestion.TabIndex = 29;
            panelQuestion.Visible = false;
            // 
            // boxAnswer5
            // 
            boxAnswer5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxAnswer5.BackColor = Color.FromArgb(53, 38, 38);
            boxAnswer5.BaseColor = Color.FromArgb(29, 16, 15);
            boxAnswer5.BorderColorA = Color.FromArgb(64, 158, 255);
            boxAnswer5.BorderColorB = Color.FromArgb(246, 221, 218);
            boxAnswer5.Font = new Font("Segoe UI", 12F);
            boxAnswer5.ForeColor = Color.FromArgb(255, 249, 249);
            boxAnswer5.Hint = "";
            boxAnswer5.Location = new Point(67, 388);
            boxAnswer5.MaxLength = 32767;
            boxAnswer5.Multiline = false;
            boxAnswer5.Name = "boxAnswer5";
            boxAnswer5.PasswordChar = '\0';
            boxAnswer5.ScrollBars = ScrollBars.None;
            boxAnswer5.SelectedText = "";
            boxAnswer5.SelectionLength = 0;
            boxAnswer5.SelectionStart = 0;
            boxAnswer5.Size = new Size(487, 38);
            boxAnswer5.TabIndex = 34;
            boxAnswer5.TabStop = false;
            boxAnswer5.UseSystemPasswordChar = false;
            boxAnswer5.KeyPress += box_KeyPress;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.FromArgb(255, 179, 176);
            lblQuestion.Location = new Point(8, 9);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(100, 30);
            lblQuestion.TabIndex = 26;
            lblQuestion.Text = "Question";
            // 
            // boxAnswer4
            // 
            boxAnswer4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxAnswer4.BackColor = Color.FromArgb(53, 38, 38);
            boxAnswer4.BaseColor = Color.FromArgb(29, 16, 15);
            boxAnswer4.BorderColorA = Color.FromArgb(64, 158, 255);
            boxAnswer4.BorderColorB = Color.FromArgb(246, 221, 218);
            boxAnswer4.Font = new Font("Segoe UI", 12F);
            boxAnswer4.ForeColor = Color.FromArgb(255, 249, 249);
            boxAnswer4.Hint = "";
            boxAnswer4.Location = new Point(67, 335);
            boxAnswer4.MaxLength = 32767;
            boxAnswer4.Multiline = false;
            boxAnswer4.Name = "boxAnswer4";
            boxAnswer4.PasswordChar = '\0';
            boxAnswer4.ScrollBars = ScrollBars.None;
            boxAnswer4.SelectedText = "";
            boxAnswer4.SelectionLength = 0;
            boxAnswer4.SelectionStart = 0;
            boxAnswer4.Size = new Size(487, 38);
            boxAnswer4.TabIndex = 33;
            boxAnswer4.TabStop = false;
            boxAnswer4.UseSystemPasswordChar = false;
            boxAnswer4.KeyPress += box_KeyPress;
            // 
            // boxQuestion
            // 
            boxQuestion.BackColor = Color.FromArgb(69, 53, 53);
            boxQuestion.BorderColor = Color.FromArgb(69, 53, 53);
            boxQuestion.Font = new Font("Segoe UI", 12F);
            boxQuestion.ForeColor = Color.FromArgb(48, 49, 51);
            boxQuestion.Hint = "";
            boxQuestion.HoverBorderColor = Color.FromArgb(64, 158, 255);
            boxQuestion.Location = new Point(8, 42);
            boxQuestion.MaxLength = 32767;
            boxQuestion.Multiline = true;
            boxQuestion.Name = "boxQuestion";
            boxQuestion.PasswordChar = '\0';
            boxQuestion.ScrollBars = ScrollBars.None;
            boxQuestion.SelectedText = "";
            boxQuestion.SelectionLength = 0;
            boxQuestion.SelectionStart = 0;
            boxQuestion.Size = new Size(552, 102);
            boxQuestion.TabIndex = 28;
            boxQuestion.TabStop = false;
            boxQuestion.UseSystemPasswordChar = false;
            boxQuestion.KeyPress += box_KeyPress;
            // 
            // boxAnswer2
            // 
            boxAnswer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxAnswer2.BackColor = Color.FromArgb(53, 38, 38);
            boxAnswer2.BaseColor = Color.FromArgb(29, 16, 15);
            boxAnswer2.BorderColorA = Color.FromArgb(64, 158, 255);
            boxAnswer2.BorderColorB = Color.FromArgb(246, 221, 218);
            boxAnswer2.Font = new Font("Segoe UI", 12F);
            boxAnswer2.ForeColor = Color.FromArgb(255, 249, 249);
            boxAnswer2.Hint = "";
            boxAnswer2.Location = new Point(68, 230);
            boxAnswer2.MaxLength = 32767;
            boxAnswer2.Multiline = false;
            boxAnswer2.Name = "boxAnswer2";
            boxAnswer2.PasswordChar = '\0';
            boxAnswer2.ScrollBars = ScrollBars.None;
            boxAnswer2.SelectedText = "";
            boxAnswer2.SelectionLength = 0;
            boxAnswer2.SelectionStart = 0;
            boxAnswer2.Size = new Size(487, 38);
            boxAnswer2.TabIndex = 32;
            boxAnswer2.TabStop = false;
            boxAnswer2.UseSystemPasswordChar = false;
            boxAnswer2.KeyPress += box_KeyPress;
            // 
            // boxAnswer3
            // 
            boxAnswer3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxAnswer3.BackColor = Color.FromArgb(53, 38, 38);
            boxAnswer3.BaseColor = Color.FromArgb(29, 16, 15);
            boxAnswer3.BorderColorA = Color.FromArgb(64, 158, 255);
            boxAnswer3.BorderColorB = Color.FromArgb(246, 221, 218);
            boxAnswer3.Font = new Font("Segoe UI", 12F);
            boxAnswer3.ForeColor = Color.FromArgb(255, 249, 249);
            boxAnswer3.Hint = "";
            boxAnswer3.Location = new Point(67, 282);
            boxAnswer3.MaxLength = 32767;
            boxAnswer3.Multiline = false;
            boxAnswer3.Name = "boxAnswer3";
            boxAnswer3.PasswordChar = '\0';
            boxAnswer3.ScrollBars = ScrollBars.None;
            boxAnswer3.SelectedText = "";
            boxAnswer3.SelectionLength = 0;
            boxAnswer3.SelectionStart = 0;
            boxAnswer3.Size = new Size(487, 38);
            boxAnswer3.TabIndex = 31;
            boxAnswer3.TabStop = false;
            boxAnswer3.UseSystemPasswordChar = false;
            boxAnswer3.KeyPress += box_KeyPress;
            // 
            // boxAnswer1
            // 
            boxAnswer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxAnswer1.BackColor = Color.FromArgb(53, 38, 38);
            boxAnswer1.BaseColor = Color.FromArgb(29, 16, 15);
            boxAnswer1.BorderColorA = Color.FromArgb(64, 158, 255);
            boxAnswer1.BorderColorB = Color.FromArgb(246, 221, 218);
            boxAnswer1.Font = new Font("Segoe UI", 12F);
            boxAnswer1.ForeColor = Color.FromArgb(255, 249, 249);
            boxAnswer1.Hint = "";
            boxAnswer1.Location = new Point(67, 178);
            boxAnswer1.MaxLength = 32767;
            boxAnswer1.Multiline = false;
            boxAnswer1.Name = "boxAnswer1";
            boxAnswer1.PasswordChar = '\0';
            boxAnswer1.ScrollBars = ScrollBars.None;
            boxAnswer1.SelectedText = "";
            boxAnswer1.SelectionLength = 0;
            boxAnswer1.SelectionStart = 0;
            boxAnswer1.Size = new Size(487, 38);
            boxAnswer1.TabIndex = 30;
            boxAnswer1.TabStop = false;
            boxAnswer1.UseSystemPasswordChar = false;
            boxAnswer1.KeyPress += box_KeyPress;
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
            rbAnswer5.Location = new Point(8, 381);
            rbAnswer5.Name = "rbAnswer5";
            rbAnswer5.RGB = false;
            rbAnswer5.Rounding = true;
            rbAnswer5.RoundingInt = 100;
            rbAnswer5.Size = new Size(59, 45);
            rbAnswer5.SizeChecked = 8;
            rbAnswer5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer5.TabIndex = 6;
            rbAnswer5.Tag = "Cyber";
            rbAnswer5.TextButton = " ";
            rbAnswer5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer5.Timer_Effect_1 = 1;
            rbAnswer5.Timer_RGB = 300;
            rbAnswer5.Click += rbAnswer_Click;
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
            rbAnswer2.Location = new Point(8, 228);
            rbAnswer2.Name = "rbAnswer2";
            rbAnswer2.RGB = false;
            rbAnswer2.Rounding = true;
            rbAnswer2.RoundingInt = 100;
            rbAnswer2.Size = new Size(59, 45);
            rbAnswer2.SizeChecked = 8;
            rbAnswer2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer2.TabIndex = 5;
            rbAnswer2.Tag = "Cyber";
            rbAnswer2.TextButton = " ";
            rbAnswer2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer2.Timer_Effect_1 = 1;
            rbAnswer2.Timer_RGB = 300;
            rbAnswer2.Click += rbAnswer_Click;
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
            rbAnswer3.Location = new Point(8, 279);
            rbAnswer3.Name = "rbAnswer3";
            rbAnswer3.RGB = false;
            rbAnswer3.Rounding = true;
            rbAnswer3.RoundingInt = 100;
            rbAnswer3.Size = new Size(59, 45);
            rbAnswer3.SizeChecked = 8;
            rbAnswer3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer3.TabIndex = 4;
            rbAnswer3.Tag = "Cyber";
            rbAnswer3.TextButton = " ";
            rbAnswer3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer3.Timer_Effect_1 = 1;
            rbAnswer3.Timer_RGB = 300;
            rbAnswer3.Click += rbAnswer_Click;
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
            rbAnswer4.Location = new Point(8, 330);
            rbAnswer4.Name = "rbAnswer4";
            rbAnswer4.RGB = false;
            rbAnswer4.Rounding = true;
            rbAnswer4.RoundingInt = 100;
            rbAnswer4.Size = new Size(59, 45);
            rbAnswer4.SizeChecked = 8;
            rbAnswer4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer4.TabIndex = 3;
            rbAnswer4.Tag = "Cyber";
            rbAnswer4.TextButton = " ";
            rbAnswer4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer4.Timer_Effect_1 = 1;
            rbAnswer4.Timer_RGB = 300;
            rbAnswer4.Click += rbAnswer_Click;
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
            rbAnswer1.Location = new Point(8, 177);
            rbAnswer1.Name = "rbAnswer1";
            rbAnswer1.RGB = false;
            rbAnswer1.Rounding = true;
            rbAnswer1.RoundingInt = 100;
            rbAnswer1.Size = new Size(59, 45);
            rbAnswer1.SizeChecked = 8;
            rbAnswer1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbAnswer1.TabIndex = 1;
            rbAnswer1.Tag = "Cyber";
            rbAnswer1.TextButton = " ";
            rbAnswer1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbAnswer1.Timer_Effect_1 = 1;
            rbAnswer1.Timer_RGB = 300;
            rbAnswer1.Click += rbAnswer_Click;
            // 
            // fbAddQuestion
            // 
            fbAddQuestion.Depth = 0;
            fbAddQuestion.Icon = Resources.plus;
            fbAddQuestion.Location = new Point(392, 542);
            fbAddQuestion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            fbAddQuestion.Name = "fbAddQuestion";
            fbAddQuestion.Size = new Size(59, 62);
            fbAddQuestion.TabIndex = 27;
            fbAddQuestion.Text = "+";
            fbAddQuestion.UseVisualStyleBackColor = true;
            fbAddQuestion.Click += fbAddQuestion_Click;
            // 
            // listQuestions
            // 
            listQuestions.BackColor = Color.FromArgb(53, 38, 38);
            listQuestions.BorderColor = Color.FromArgb(64, 64, 64);
            listQuestions.DisabledBackColor = Color.FromArgb(80, 80, 80);
            listQuestions.DisabledForeColor = Color.FromArgb(109, 109, 109);
            listQuestions.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listQuestions.HoveredItemBackColor = Color.LightGray;
            listQuestions.HoveredItemColor = Color.DimGray;
            listQuestions.IsDerivedStyle = false;
            listQuestions.ItemHeight = 40;
            listQuestions.Location = new Point(0, 0);
            listQuestions.MultiSelect = false;
            listQuestions.Name = "listQuestions";
            listQuestions.SelectedIndex = -1;
            listQuestions.SelectedItem = null;
            listQuestions.SelectedItemBackColor = Color.FromArgb(115, 51, 51);
            listQuestions.SelectedItemColor = Color.White;
            listQuestions.SelectedText = null;
            listQuestions.SelectedValue = null;
            listQuestions.ShowBorder = false;
            listQuestions.ShowScrollBar = false;
            listQuestions.Size = new Size(451, 604);
            listQuestions.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            listQuestions.StyleManager = null;
            listQuestions.TabIndex = 26;
            listQuestions.ThemeAuthor = "Taiizor";
            listQuestions.ThemeName = "MetroDark";
            listQuestions.SelectedIndexChanged += listQuestions_SelectedIndexChanged;
            // 
            // editRawQuizTab
            // 
            editRawQuizTab.Controls.Add(editBox);
            editRawQuizTab.Location = new Point(0, 40);
            editRawQuizTab.Name = "editRawQuizTab";
            editRawQuizTab.Padding = new Padding(3);
            editRawQuizTab.Size = new Size(1040, 604);
            editRawQuizTab.TabIndex = 0;
            editRawQuizTab.Text = "Raw Quiz";
            editRawQuizTab.UseVisualStyleBackColor = true;
            // 
            // editBox
            // 
            editBox.BorderColor = Color.FromArgb(220, 223, 230);
            editBox.Font = new Font("Segoe UI", 12F);
            editBox.ForeColor = Color.FromArgb(48, 49, 51);
            editBox.Hint = "";
            editBox.HoverBorderColor = Color.FromArgb(64, 158, 255);
            editBox.Location = new Point(0, 0);
            editBox.MaxLength = 32767;
            editBox.Multiline = true;
            editBox.Name = "editBox";
            editBox.PasswordChar = '\0';
            editBox.ScrollBars = ScrollBars.Both;
            editBox.SelectedText = "";
            editBox.SelectionLength = 0;
            editBox.SelectionStart = 0;
            editBox.Size = new Size(1040, 616);
            editBox.TabIndex = 0;
            editBox.TabStop = false;
            editBox.UseSystemPasswordChar = false;
            editBox.KeyPress += editBox_KeyPress;
            // 
            // btnValidate
            // 
            btnValidate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnValidate.BackColor = Color.Transparent;
            btnValidate.BaseColor = Color.FromArgb(93, 63, 62);
            btnValidate.Font = new Font("Segoe UI", 12F);
            btnValidate.Location = new Point(798, 4);
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
            btnExport.Location = new Point(952, 4);
            btnExport.Name = "btnExport";
            btnExport.Rounded = true;
            btnExport.Size = new Size(71, 45);
            btnExport.TabIndex = 24;
            btnExport.Text = "Export";
            btnExport.TextColor = Color.FromArgb(255, 222, 170);
            btnExport.Click += btnExport_Click;
            // 
            // listQuizzes
            // 
            listQuizzes.BackColor = Color.FromArgb(30, 30, 30);
            listQuizzes.BorderColor = Color.FromArgb(64, 64, 64);
            listQuizzes.DisabledBackColor = Color.FromArgb(80, 80, 80);
            listQuizzes.DisabledForeColor = Color.FromArgb(109, 109, 109);
            listQuizzes.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listQuizzes.HoveredItemBackColor = Color.LightGray;
            listQuizzes.HoveredItemColor = Color.DimGray;
            listQuizzes.IsDerivedStyle = false;
            listQuizzes.ItemHeight = 40;
            listQuizzes.Location = new Point(28, 131);
            listQuizzes.MultiSelect = false;
            listQuizzes.Name = "listQuizzes";
            listQuizzes.SelectedIndex = -1;
            listQuizzes.SelectedItem = null;
            listQuizzes.SelectedItemBackColor = Color.FromArgb(115, 51, 51);
            listQuizzes.SelectedItemColor = Color.White;
            listQuizzes.SelectedText = null;
            listQuizzes.SelectedValue = null;
            listQuizzes.ShowBorder = false;
            listQuizzes.ShowScrollBar = false;
            listQuizzes.Size = new Size(285, 644);
            listQuizzes.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            listQuizzes.StyleManager = null;
            listQuizzes.TabIndex = 25;
            listQuizzes.ThemeAuthor = "Taiizor";
            listQuizzes.ThemeName = "MetroDark";
            listQuizzes.SelectedIndexChanged += listQuizzes_SelectedIndexChanged;
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTest.BackColor = Color.Transparent;
            btnTest.BaseColor = Color.FromArgb(93, 63, 62);
            btnTest.Font = new Font("Segoe UI", 12F);
            btnTest.Location = new Point(721, 4);
            btnTest.Name = "btnTest";
            btnTest.Rounded = true;
            btnTest.Size = new Size(71, 45);
            btnTest.TabIndex = 26;
            btnTest.Text = "Test";
            btnTest.TextColor = Color.FromArgb(255, 222, 170);
            btnTest.Click += btnTest_Click;
            // 
            // boxQuizName
            // 
            boxQuizName.Anchor = AnchorStyles.None;
            boxQuizName.BackColor = Color.FromArgb(53, 38, 38);
            boxQuizName.BaseColor = Color.FromArgb(29, 16, 15);
            boxQuizName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxQuizName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxQuizName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxQuizName.ForeColor = Color.FromArgb(255, 249, 249);
            boxQuizName.Hint = "";
            boxQuizName.Location = new Point(144, 6);
            boxQuizName.MaxLength = 32767;
            boxQuizName.Multiline = false;
            boxQuizName.Name = "boxQuizName";
            boxQuizName.PasswordChar = '\0';
            boxQuizName.ScrollBars = ScrollBars.None;
            boxQuizName.SelectedText = "";
            boxQuizName.SelectionLength = 0;
            boxQuizName.SelectionStart = 0;
            boxQuizName.Size = new Size(340, 41);
            boxQuizName.TabIndex = 31;
            boxQuizName.TabStop = false;
            boxQuizName.UseSystemPasswordChar = false;
            boxQuizName.KeyPress += box_KeyPress;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.None;
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.FromArgb(255, 179, 176);
            lblTimer.Location = new Point(494, 11);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(69, 30);
            lblTimer.TabIndex = 35;
            lblTimer.Text = "Timer";
            // 
            // lblQuizName
            // 
            lblQuizName.Anchor = AnchorStyles.None;
            lblQuizName.AutoSize = true;
            lblQuizName.BackColor = Color.Transparent;
            lblQuizName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuizName.ForeColor = Color.FromArgb(255, 179, 176);
            lblQuizName.Location = new Point(3, 12);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(121, 30);
            lblQuizName.TabIndex = 36;
            lblQuizName.Text = "Quiz Name";
            // 
            // panelQuiz
            // 
            panelQuiz.BackColor = Color.Transparent;
            panelQuiz.Controls.Add(timer);
            panelQuiz.Controls.Add(lblQuizName);
            panelQuiz.Controls.Add(lblTimer);
            panelQuiz.Controls.Add(boxQuizName);
            panelQuiz.Controls.Add(btnTest);
            panelQuiz.Controls.Add(btnExport);
            panelQuiz.Controls.Add(btnValidate);
            panelQuiz.Controls.Add(btnSave);
            panelQuiz.Controls.Add(btnDelete);
            panelQuiz.Location = new Point(319, 76);
            panelQuiz.Name = "panelQuiz";
            panelQuiz.Size = new Size(1100, 50);
            panelQuiz.TabIndex = 37;
            // 
            // timer
            // 
            timer.BackColor = Color.FromArgb(53, 38, 38);
            timer.BaseColor = Color.FromArgb(26, 17, 17);
            timer.BorderColorA = Color.FromArgb(192, 196, 204);
            timer.BorderColorB = Color.FromArgb(192, 196, 204);
            timer.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            timer.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            timer.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            timer.EnterKey = true;
            timer.Font = new Font("Segoe UI", 12F);
            timer.ForeColor = Color.FromArgb(255, 179, 176);
            timer.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            timer.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            timer.Location = new Point(569, 11);
            timer.MaxNum = 1E+08F;
            timer.MinNum = 0F;
            timer.Name = "timer";
            timer.Precision = 0;
            timer.Size = new Size(128, 32);
            timer.Step = 5F;
            timer.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            timer.TabIndex = 37;
            timer.Text = "timer";
            timer.ValueNumber = 10F;
            timer.Click += timer_Click;
            // 
            // fbSave
            // 
            fbSave.Depth = 0;
            fbSave.Icon = Resources.save;
            fbSave.Location = new Point(973, 483);
            fbSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            fbSave.Name = "fbSave";
            fbSave.Size = new Size(56, 56);
            fbSave.TabIndex = 30;
            fbSave.Text = "materialFloatingActionButton1";
            fbSave.UseVisualStyleBackColor = true;
            fbSave.Click += fbSave_Click;
            // 
            // QuizzesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(26, 17, 17);
            Controls.Add(panelQuiz);
            Controls.Add(quizzesTabPage);
            Controls.Add(BtnImport);
            Controls.Add(BtnCreateQuiz);
            Controls.Add(lblWelcome);
            Controls.Add(lblNoQuizAvailable);
            Controls.Add(listQuizzes);
            Name = "QuizzesAdmin";
            Size = new Size(1422, 787);
            Load += QuizzesAdmin_Load;
            Layout += QuizzesAdmin_Layout;
            quizzesTabPage.ResumeLayout(false);
            tabEditQuiz.ResumeLayout(false);
            panelQuestion.ResumeLayout(false);
            panelQuestion.PerformLayout();
            editRawQuizTab.ResumeLayout(false);
            panelQuiz.ResumeLayout(false);
            panelQuiz.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private ReaLTaiizor.Controls.ForeverButton BtnCreateQuiz;
        private ReaLTaiizor.Controls.ForeverButton BtnImport;
        private ReaLTaiizor.Controls.BigLabel lblNoQuizAvailable;
        private ReaLTaiizor.Controls.ForeverButton btnDelete;
        private ReaLTaiizor.Controls.ForeverButton btnSave;
        private ReaLTaiizor.Controls.HopeTabPage quizzesTabPage;
        private TabPage editRawQuizTab;
        private TabPage tabEditQuiz;
        private ReaLTaiizor.Controls.HopeRichTextBox editBox;
        private ReaLTaiizor.Controls.ForeverButton btnValidate;
        private ReaLTaiizor.Controls.ForeverButton btnExport;
        private ReaLTaiizor.Controls.MetroListBox listQuizzes;
        private ReaLTaiizor.Controls.MetroListBox listQuestions;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton fbAddQuestion;
        private ReaLTaiizor.Controls.BigLabel lblQuestion;
        private ReaLTaiizor.Controls.HopeRichTextBox boxQuestion;
        private Panel panelQuestion;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer5;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer2;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer3;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer4;
        private ReaLTaiizor.Controls.CyberRadioButton rbAnswer1;
        private ReaLTaiizor.Controls.HopeTextBox boxAnswer1;
        private ReaLTaiizor.Controls.HopeTextBox boxAnswer5;
        private ReaLTaiizor.Controls.HopeTextBox boxAnswer4;
        private ReaLTaiizor.Controls.HopeTextBox boxAnswer2;
        private ReaLTaiizor.Controls.HopeTextBox boxAnswer3;
        private ReaLTaiizor.Controls.ForeverButton btnTest;
        private ReaLTaiizor.Controls.HopeTextBox boxQuizName;
        private ReaLTaiizor.Controls.BigLabel lblTimer;
        private ReaLTaiizor.Controls.BigLabel lblQuizName;
        private Panel panelQuiz;
        private ReaLTaiizor.Controls.HopeNumeric timer;
        private ReaLTaiizor.Controls.MaterialFloatingActionButton fbSave;
    }
}
