﻿using QuizApp.WinFormsUI.Controls;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms
{
    partial class StudentDashboardForm
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
            SidePanel = new Panel();
            btnSettings = new Button();
            btnQuizzes = new Button();
            logo = new PictureBox();
            SidePanelIndicator = new Panel();
            ActionBar = new Panel();
            ActionBarAccented = new Panel();
            btnClose = new Label();
            settings = new Settings(_user, _defaultPassword);
            quizzes = new QuizzesStudent(_user);
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(39, 29, 29);
            SidePanel.Controls.Add(btnSettings);
            SidePanel.Controls.Add(btnQuizzes);
            SidePanel.Controls.Add(logo);
            SidePanel.Controls.Add(SidePanelIndicator);
            SidePanel.Controls.Add(ActionBar);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Margin = new Padding(4);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(222, 718);
            SidePanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(39, 29, 29);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(16, 257);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(206, 66);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "       Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnMenu_Click;
            // 
            // btnQuizzes
            // 
            btnQuizzes.BackColor = Color.FromArgb(39, 29, 29);
            btnQuizzes.FlatAppearance.BorderSize = 0;
            btnQuizzes.FlatStyle = FlatStyle.Flat;
            btnQuizzes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuizzes.ForeColor = Color.White;
            btnQuizzes.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuizzes.Location = new Point(16, 189);
            btnQuizzes.Margin = new Padding(4);
            btnQuizzes.Name = "btnQuizzes";
            btnQuizzes.Size = new Size(206, 66);
            btnQuizzes.TabIndex = 4;
            btnQuizzes.Text = "       Quizzes";
            btnQuizzes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuizzes.UseVisualStyleBackColor = false;
            btnQuizzes.Click += btnMenu_Click;
            // 
            // logo
            // 
            logo.ErrorImage = Resources.trace_logo;
            logo.Image = Resources.trace_logo;
            logo.InitialImage = Resources.trace_logo;
            logo.Location = new Point(53, 32);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(119, 123);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // SidePanelIndicator
            // 
            SidePanelIndicator.BackColor = Color.FromArgb(152, 26, 37);
            SidePanelIndicator.Location = new Point(1, 189);
            SidePanelIndicator.Margin = new Padding(4);
            SidePanelIndicator.Name = "SidePanelIndicator";
            SidePanelIndicator.Size = new Size(13, 66);
            SidePanelIndicator.TabIndex = 4;
            // 
            // ActionBar
            // 
            ActionBar.Location = new Point(3, 0);
            ActionBar.Name = "ActionBar";
            ActionBar.Size = new Size(219, 14);
            ActionBar.TabIndex = 3;
            ActionBar.MouseDown += ActionBar_MouseDown;
            // 
            // ActionBarAccented
            // 
            ActionBarAccented.BackColor = Color.FromArgb(152, 26, 37);
            ActionBarAccented.Dock = DockStyle.Top;
            ActionBarAccented.Location = new Point(222, 0);
            ActionBarAccented.Margin = new Padding(4);
            ActionBarAccented.Name = "ActionBarAccented";
            ActionBarAccented.Size = new Size(1146, 14);
            ActionBarAccented.TabIndex = 1;
            ActionBarAccented.MouseDown += ActionBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(255, 249, 249);
            btnClose.Location = new Point(1330, 18);
            btnClose.Margin = new Padding(4, 0, 4, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "x";
            btnClose.Click += btnClose_Click;
            // 
            // settings
            // 
            settings.AutoSize = true;
            settings.BackColor = Color.Transparent;
            settings.Location = new Point(221, 15);
            settings.Name = "settings";
            settings.Size = new Size(1149, 707);
            settings.TabIndex = 6;
            settings.Visible = false;
            // 
            // quizzes
            // 
            quizzes.AutoSize = true;
            quizzes.Location = new Point(222, 14);
            quizzes.Name = "quizzes";
            quizzes.Size = new Size(1149, 709);
            quizzes.TabIndex = 7;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 17);
            ClientSize = new Size(1368, 718);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(ActionBarAccented);
            Controls.Add(SidePanel);
            Controls.Add(quizzes);
            Controls.Add(settings);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Resources.trace_logo_ico;
            Name = "StudentDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboard";
            WindowState = FormWindowState.Maximized;
            Paint += StudentDashboardForm_Paint;
            Layout += StudentDashboard_Layout;
            SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel SidePanel;
        private Panel ActionBarAccented;
        private Label btnClose;
        private Panel ActionBar;
        private Panel SidePanelIndicator;
        private Button btnQuizzes;
        private PictureBox logo;
        private Button btnSettings;
        private QuizzesStudent quizzes;
        private Settings settings;
    }
}