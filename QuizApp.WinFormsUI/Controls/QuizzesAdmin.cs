using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Serializable;
using QuizApp.Core.Utils;
using QuizApp.WinFormsUI.Properties;
using ReaLTaiizor.Controls;

namespace QuizApp.WinFormsUI.Controls;

public partial class QuizzesAdmin : UserControl
{
    private List<Quiz> _quizzes = [];
    private bool _isCreatingQuiz = false;

    public QuizzesAdmin()
    {
        InitializeComponent();
        btnSave.Visible = false;
        btnDelete.Visible = false;
        btnValidate.Visible = false;
        btnExport.Visible = false;
    }

    private void BtnCreateQuiz_Click(object sender, EventArgs e)
    {
        if (!GetConfirmation()) return;

        var newQuiz = new Quiz
        {
            Id = QuizApp.Repo.GetNewQuizId(),
            Title = "New Quiz",
            Questions = [
                new Question
                {
                    Id = QuizApp.Repo.GetNewQuestionId(),
                    QuestionText = "New Question",
                    Answers = ["New Answer 1", "New Answer 2", "New Answer 3"],
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Id = QuizApp.Repo.GetNewQuestionId(),
                    QuestionText = "New Question 2",
                    Answers = ["New Answer 1", "New Answer 2", "New Answer 3"],
                    CorrectAnswerIndex = 2
                }
            ],
            TakerScores = []
        };

        _quizzes.Add(newQuiz);
        listQuizzes.Items.Add(newQuiz.Title);
        LblNoQuizAvailable.Visible = false;
        listQuizzes.Visible = true;
        quizzesTabPage.Visible = true;
        listQuizzes.SelectedIndex = listQuizzes.Items.Count - 1;
        EditBox.Text = QuizHandlers.QuizToString(newQuiz);
        btnSave.Visible = true;
        btnDelete.Visible = true;
        btnValidate.Visible = true;
        btnExport.Visible = true;
        _isCreatingQuiz = true;
    }

    private bool GetConfirmation()
    {
        if (!_isCreatingQuiz) return true;

        var result = MessageBox.Show(Resources.disregardQuiz, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return false;
        _isCreatingQuiz = false;
        listQuizzes.Items.RemoveAt(listQuizzes.Items.Count - 1);
        _quizzes.RemoveAt(_quizzes.Count - 1);
        EditBox.Text = "";
        return true;
    }

    private void BtnImport_Click(object sender, EventArgs e)
    {
        if (!GetConfirmation()) return;
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = Resources.files_supported;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        var extension = Path.GetExtension(openFileDialog.FileName);
        var file = openFileDialog.OpenFile();

        switch (extension)
        {
            case ".json":
                var newQuizJson = QuizFilesManager.LoadQuizJson(file, QuizApp.Repo);
                if (newQuizJson == null)
                {
                    MessageBox.Show(Resources.load_failed_quiz, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listQuizzes.Items.Add(newQuizJson.Title);
                QuizApp.Repo.AddQuiz(newQuizJson);
                break;
            case ".txt":
                var newQuizTxt = QuizFilesManager.LoadQuizTxt(file, QuizApp.Repo);
                if (newQuizTxt == null)
                {
                    MessageBox.Show(Resources.load_failed_quiz, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listQuizzes.Items.Add(newQuizTxt.Title);

                //TODO: REMOVE THIS:
                _quizzes.Add(newQuizTxt);
                QuizApp.Repo.AddQuiz(newQuizTxt);
                break;
            case ".quiz":
                // TODO: CHANGE
                var newQuizQuiz = QuizFilesManager.LoadQuizQuiz(file, QuizApp.Repo);
                if (newQuizQuiz == null)
                {
                    MessageBox.Show(Resources.load_failed_quiz, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listQuizzes.Items.Add(newQuizQuiz.Title);
                QuizApp.Repo.AddQuiz(newQuizQuiz);
                break;
            default:
                throw new NotSupportedException();
        }

        LblNoQuizAvailable.Visible = false;
        listQuizzes.Visible = true;
        if (listQuizzes.HotLightedIndex > 0) quizzesTabPage.Visible = false;
    }

    private void ListQuizzes_Click(object sender, EventArgs e)
    {
        if (sender is not RoyalListBox list) return;
        var index = list.HotLightedIndex;

        if (index < 0) return;
        btnSave.Visible = true;
        btnDelete.Visible = true;
        btnValidate.Visible = true;
        btnExport.Visible = true;
        quizzesTabPage.Visible = true;

        var quiz = _quizzes[index];
        var text = QuizHandlers.QuizToString(quiz);
        EditBox.Text = text;
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (listQuizzes.SelectedIndex < 0) return;
        var result = MessageBox.Show(Resources.delete_quiz, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return;
        var lastHotLightedIndex = listQuizzes.SelectedIndex;

        var quiz = _quizzes[lastHotLightedIndex];
        QuizApp.Repo.RemoveQuiz(quiz);
        _quizzes.Remove(quiz);
        listQuizzes.Items.RemoveAt(lastHotLightedIndex);

        if (_quizzes.Count == 0)
        {
            LblNoQuizAvailable.Visible = true;
            listQuizzes.Visible = false;
            quizzesTabPage.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnValidate.Visible = false;
            btnExport.Visible = false;
        }
        else
        {
            if (lastHotLightedIndex == 0) lastHotLightedIndex++;
            listQuizzes.HotLightedIndex = lastHotLightedIndex - 1;
            listQuizzes.SelectedIndex = lastHotLightedIndex - 1;
            EditBox.Text = QuizHandlers.QuizToString(_quizzes[lastHotLightedIndex - 1]);
        }

    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (listQuizzes.SelectedIndex < 0) return;
        SaveQuiz();
    }

    private bool SaveQuiz()
    {
        var quizText = EditBox.Text;

        if (!QuizHandlers.ValidateQuiz(quizText, out var errorMessage))
        {
            MessageBox.Show(errorMessage, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        var result = MessageBox.Show(Resources.save_confirmation, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return false;

        var quiz = QuizHandlers.TextToQuiz(quizText, QuizApp.Repo);
        if (quiz == null)
        {
            MessageBox.Show(Resources.failed_save, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        QuizApp.Repo.AddQuiz(quiz);
        _quizzes[listQuizzes.SelectedIndex] = quiz;
        listQuizzes.Items[listQuizzes.SelectedIndex] = quiz.Title;
        EditBox.Text = QuizHandlers.QuizToString(quiz);
        MessageBox.Show(Resources.save_success, Resources.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
        _isCreatingQuiz = false;
        return true;
    }

    private void BtnValidate_Click(object sender, EventArgs e)
    {
        if (listQuizzes.SelectedIndex < 0) return;
        var quizText = EditBox.Text;

        if (QuizHandlers.ValidateQuiz(quizText, out var errorMessage))
        {
            MessageBox.Show(Resources.no_syntax_error, Resources.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(errorMessage, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void QuizzesAdmin_Layout(object sender, LayoutEventArgs e)
    {
        if (_quizzes.Count == 0)
        {
            LblNoQuizAvailable.Visible = true;
            listQuizzes.Visible = false;
            quizzesTabPage.Visible = false;
        }
        else
        {
            LblNoQuizAvailable.Visible = false;
            listQuizzes.Items.Clear();
            foreach (var quiz in _quizzes)
            {
                listQuizzes.Items.Add(quiz.Title);
            }
            listQuizzes.Visible = true;
            if (listQuizzes.HotLightedIndex > 0) quizzesTabPage.Visible = false;
        }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        if (_isCreatingQuiz)
        {
            if (!SaveQuiz()) return;
        }
        
        if (listQuizzes.SelectedIndex < 0) return;
        var quiz = _quizzes[listQuizzes.SelectedIndex];
        
        using var saveFileDialog = new CommonSaveFileDialog();
        saveFileDialog.Filters.Add(new CommonFileDialogFilter("Quiz files", "*.quiz"));
        saveFileDialog.Filters.Add(new CommonFileDialogFilter("JSON files", "*.json"));
        saveFileDialog.Filters.Add(new CommonFileDialogFilter("Text files", "*.txt"));        
        saveFileDialog.DefaultFileName = quiz.Title;
        
        var checkbox = new CommonFileDialogCheckBox("Remove user scores", true);
        saveFileDialog.Controls.Add(checkbox);

        if (saveFileDialog.ShowDialog() != CommonFileDialogResult.Ok) return;
        var extension = Path.GetExtension(saveFileDialog.FileName);
        var location = saveFileDialog.FileName;
        var overwrite = checkbox.IsChecked;

        switch (extension)
        {
            case ".json":
                QuizFilesManager.SaveQuizJson(quiz, location, overwrite);
                break;
            case ".txt":
                QuizFilesManager.SaveQuizTxt(quiz, location);
                break;
            case ".quiz":
                QuizFilesManager.SaveQuizQuiz(quiz, location, overwrite);
                break;
            default:
                throw new NotSupportedException();
        }
    }
}