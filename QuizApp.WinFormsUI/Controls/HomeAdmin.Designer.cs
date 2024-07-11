using QuizApp.Core.Data.Models;

namespace QuizApp.WinFormsUI.Controls
{
    partial class HomeAdmin
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblWelcome = new ReaLTaiizor.Controls.BigLabel();
            listQuizzes = new ReaLTaiizor.Controls.MetroListBox();
            takerScoreBindingSource = new BindingSource(components);
            quizScoreView = new ReaLTaiizor.Controls.PoisonDataGridView();
            TakerName = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)takerScoreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quizScoreView).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 25F);
            lblWelcome.ForeColor = Color.FromArgb(255, 179, 176);
            lblWelcome.Location = new Point(18, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(277, 46);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Admin!";
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
            listQuizzes.Location = new Point(18, 88);
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
            listQuizzes.TabIndex = 26;
            listQuizzes.ThemeAuthor = "Taiizor";
            listQuizzes.ThemeName = "MetroDark";
            listQuizzes.SelectedIndexChanged += listQuizzes_SelectedIndexChanged;
            // 
            // takerScoreBindingSource
            // 
            takerScoreBindingSource.DataSource = typeof(TakerScore);
            // 
            // quizScoreView
            // 
            quizScoreView.AllowUserToAddRows = false;
            quizScoreView.AllowUserToDeleteRows = false;
            quizScoreView.AllowUserToOrderColumns = true;
            quizScoreView.AllowUserToResizeRows = false;
            quizScoreView.BackgroundColor = Color.FromArgb(17, 17, 17);
            quizScoreView.BorderStyle = BorderStyle.None;
            quizScoreView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            quizScoreView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            quizScoreView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            quizScoreView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quizScoreView.Columns.AddRange(new DataGridViewColumn[] { TakerName, Score });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(109, 109, 109);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            quizScoreView.DefaultCellStyle = dataGridViewCellStyle2;
            quizScoreView.EnableHeadersVisualStyles = false;
            quizScoreView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            quizScoreView.GridColor = Color.FromArgb(17, 17, 17);
            quizScoreView.Location = new Point(309, 88);
            quizScoreView.Name = "quizScoreView";
            quizScoreView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            quizScoreView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            quizScoreView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            quizScoreView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            quizScoreView.Size = new Size(642, 644);
            quizScoreView.TabIndex = 0;
            quizScoreView.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            quizScoreView.UseCustomBackColor = true;
            quizScoreView.UseCustomForeColor = true;
            quizScoreView.UseStyleColors = true;
            // 
            // TakerName
            // 
            TakerName.HeaderText = "Name";
            TakerName.Name = "TakerName";
            TakerName.ReadOnly = true;
            TakerName.Width = 300;
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.Name = "Score";
            Score.ReadOnly = true;
            Score.Width = 300;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(quizScoreView);
            Controls.Add(listQuizzes);
            Controls.Add(lblWelcome);
            Name = "HomeAdmin";
            Size = new Size(1158, 735);
            Load += HomeAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)takerScoreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)quizScoreView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private ReaLTaiizor.Controls.MetroListBox listQuizzes;
        private BindingSource takerScoreBindingSource;
        private ReaLTaiizor.Controls.PoisonDataGridView quizScoreView;
        private DataGridViewTextBoxColumn TakerName;
        private DataGridViewTextBoxColumn Score;
    }
}
