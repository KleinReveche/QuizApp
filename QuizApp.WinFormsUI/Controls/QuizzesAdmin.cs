using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Serializable;
using QuizApp.Core.Utils;
using QuizApp.WinFormsUI.Forms;
using QuizApp.WinFormsUI.Properties;
using ReaLTaiizor.Controls;

namespace QuizApp.WinFormsUI.Controls;

public partial class QuizzesAdmin : UserControl
{
    private List<Quiz> _quizzes = [];
    private bool _isCreatingQuiz;
    private bool _isCreatingQuestion;
    private readonly List<Question> _tempQuestions = [];
    private readonly HopeTextBox[] _textBoxes;
    private readonly CyberRadioButton[] _radioButtons;
    private int _answer;

    public QuizzesAdmin()
    {
        InitializeComponent();
        panelQuiz.Visible = false;
        _textBoxes = [boxAnswer1, boxAnswer2, boxAnswer3, boxAnswer4, boxAnswer5];
        _radioButtons = [rbAnswer1, rbAnswer2, rbAnswer3, rbAnswer4, rbAnswer5];
    }

    private void BtnCreateQuiz_Click(object sender, EventArgs e)
    {
        if (InQuizCreation()) return;

        var newQuiz = new Quiz
        {
            Title = "New Quiz",
            Questions = [
                new Question
                {
                    QuestionText = "New Question",
                    Answers = ["New Answer 1", "New Answer 2", "New Answer 3"],
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    QuestionText = "New Question 2",
                    Answers = ["New Answer 1", "New Answer 2", "New Answer 3"],
                    CorrectAnswerIndex = 2
                }
            ],
            QuizDone = false,
            TimerInSeconds = 60
        };

        _quizzes.Add(newQuiz);
        listQuizzes.Items.Add(newQuiz.Title);
        lblNoQuizAvailable.Visible = false;
        listQuizzes.Visible = true;
        listQuizzes.SelectedIndex = listQuizzes.Items.Count - 1;
        editBox.Text = QuizHandlers.QuizToString(newQuiz);
        panelQuiz.Visible = true;
        quizzesTabPage.Visible = true;
        _isCreatingQuiz = true;
    }

    private bool InQuizCreation()
    {
        if (!_isCreatingQuiz) return false;

        var result = MessageBox.Show(Resources.discard_quiz, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return true;
        _isCreatingQuiz = false;
        listQuizzes.Items.RemoveAt(listQuizzes.Items.Count - 1);
        _quizzes.RemoveAt(_quizzes.Count - 1);
        editBox.Text = "";

        if (_quizzes.Count != 0) return false;

        lblNoQuizAvailable.Visible = true;
        listQuizzes.Visible = false;
        quizzesTabPage.Visible = false;
        panelQuiz.Visible = false;
        return false;
    }

    private void BtnImport_Click(object sender, EventArgs e)
    {
        if (InQuizCreation()) return;
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

                InsertQuiz(newQuizJson);
                break;
            case ".txt":
                var newQuizTxt = QuizFilesManager.LoadQuizTxt(file, QuizApp.Repo);
                if (newQuizTxt == null)
                {
                    MessageBox.Show(Resources.load_failed_quiz, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InsertQuiz(newQuizTxt);
                break;
            case ".quiz":
                var newQuizQuiz = QuizFilesManager.LoadQuizQuiz(file, QuizApp.Repo);
                if (newQuizQuiz == null)
                {
                    MessageBox.Show(Resources.load_failed_quiz, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InsertQuiz(newQuizQuiz);
                break;
            default:
                throw new NotSupportedException();
        }

        lblNoQuizAvailable.Visible = false;
        listQuizzes.Visible = true;
        if (listQuizzes.SelectedIndex > 0) quizzesTabPage.Visible = false;
    }

    private void InsertQuiz(Quiz quiz)
    {
        _quizzes.Add(quiz);
        QuizApp.Repo.AddQuiz(quiz);
        listQuizzes.Items.Add(quiz.Title);
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (listQuizzes.SelectedIndex < 0) return;
        if (_isCreatingQuiz)
        {
            InQuizCreation();
            return;
        }

        var result = MessageBox.Show(Resources.delete_quiz, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return;
        var lastHotLightedIndex = listQuizzes.SelectedIndex;

        var quiz = _quizzes[lastHotLightedIndex];
        QuizApp.Repo.RemoveQuiz(quiz);
        _quizzes.Remove(quiz);
        listQuizzes.Items.RemoveAt(lastHotLightedIndex);

        if (_quizzes.Count == 0)
        {
            lblNoQuizAvailable.Visible = true;
            listQuizzes.Visible = false;
            quizzesTabPage.Visible = false;
            panelQuiz.Visible = false;
        }
        else
        {
            if (lastHotLightedIndex == 0) lastHotLightedIndex++;
            listQuizzes.SelectedIndex = lastHotLightedIndex - 1;
            editBox.Text = QuizHandlers.QuizToString(_quizzes[lastHotLightedIndex - 1]);
        }

    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (listQuizzes.SelectedIndex < 0) return;
        SaveQuiz();
    }

    private bool SaveQuiz()
    {
        var quizText = editBox.Text;

        if (!QuizHandlers.ValidateQuiz(quizText, out var errorMessage))
        {
            MessageBox.Show(errorMessage, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        var result = MessageBox.Show(Resources.save_confirmation, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return false;

        var quiz = QuizHandlers.TextToQuiz(quizText);
        if (quiz == null)
        {
            MessageBox.Show(Resources.failed_save, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (_isCreatingQuiz)
            QuizApp.Repo.AddQuiz(quiz);
        else
            QuizApp.Repo.UpdateQuiz(_quizzes[listQuizzes.SelectedIndex], quiz);

        _quizzes[listQuizzes.SelectedIndex] = quiz;
        listQuizzes.Items[listQuizzes.SelectedIndex] = quiz.Title;
        editBox.Text = QuizHandlers.QuizToString(quiz);
        MessageBox.Show(Resources.save_success, Resources.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
        _isCreatingQuiz = false;
        return true;
    }

    private void BtnValidate_Click(object sender, EventArgs e)
    {
        if (listQuizzes.SelectedIndex < 0) return;
        var quizText = editBox.Text;

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
        ShowQuizzes();
    }

    private void ShowQuizzes()
    {
        if (_quizzes.Count == 0)
        {
            lblNoQuizAvailable.Visible = true;
            listQuizzes.Visible = false;
            quizzesTabPage.Visible = false;
        }
        else
        {
            lblNoQuizAvailable.Visible = false;
            listQuizzes.Items.Clear();
            foreach (var quiz in _quizzes)
            {
                listQuizzes.Items.Add(quiz.Title);
            }
            listQuizzes.Visible = true;
            if (listQuizzes.SelectedIndex > 0) quizzesTabPage.Visible = false;
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

        using var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = Resources.files_supported_separate;
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
        var extension = Path.GetExtension(saveFileDialog.FileName);
        var location = saveFileDialog.FileName;

        switch (extension)
        {
            case ".json":
                QuizFilesManager.SaveQuizJson(quiz, location);
                break;
            case ".txt":
                QuizFilesManager.SaveQuizTxt(quiz, location);
                break;
            case ".quiz":
                QuizFilesManager.SaveQuizQuiz(quiz, location);
                break;
            default:
                throw new NotSupportedException();
        }
    }

    private void QuizzesAdmin_Load(object sender, EventArgs e)
    {
        _quizzes = QuizApp.Repo.GetQuizzes();
        ShowQuizzes();
    }

    private void listQuizzes_SelectedIndexChanged(object sender)
    {
        if (sender is not MetroListBox list) return;
        var index = list.SelectedIndex;

        if (index < 0) return;
        panelQuiz.Visible = true;
        quizzesTabPage.Visible = true;
        boxQuizName.Text = _quizzes[index].Title;
        timer.ValueNumber = _quizzes[index].TimerInSeconds;

        var quiz = _quizzes[index];
        var text = QuizHandlers.QuizToString(quiz);
        LoadQuizQuestions();
        editBox.Text = text;

    }

    private void LoadQuizQuestions()
    {
        _tempQuestions.Clear();
        listQuestions.Items.Clear();
        var quiz = _quizzes[listQuizzes.SelectedIndex];
        foreach (var question in quiz.Questions)
        {
            listQuestions.Items.Add(question.QuestionText);
            _tempQuestions.Add(question);
        }

    }

    private void listQuestions_SelectedIndexChanged(object sender)
    {
        if (sender is not MetroListBox list) return;
        
        panelQuestion.Visible = true;
        var index = list.SelectedIndex;
        if (index < 0) return;

        var question = _tempQuestions[index];
        boxQuestion.Text = question.QuestionText;
        var answers = question.Answers;
        for (var i = 0; i < answers.Count; i++)
        {
            _textBoxes[i].Text = answers[i];
        }

        ChangeCorrectAnswer(question.CorrectAnswerIndex);

        _answer = question.CorrectAnswerIndex;
        UpdateRawEditBox();

    }

    private void ChangeCorrectAnswer(int index)
    {
        for (var i = 0; i < _radioButtons.Length; i++)
        {
            _radioButtons[i].Checked = i == index;
        }
    }

    private void fbAddQuestion_Click(object sender, EventArgs e)
    {
        _isCreatingQuestion = true;

        var newQuestion = new Question
        {
            QuestionText = "New Question",
            Answers = ["New Answer 1", "New Answer 2", "New Answer 3"],
            CorrectAnswerIndex = 1
        };

        _tempQuestions.Add(newQuestion);
        listQuestions.Items.Add(newQuestion.QuestionText);
    }

    private void rbAnswer_Click(object sender, EventArgs e)
    {
        if (sender is not CyberRadioButton radioButton) return;

        var index = int.Parse(radioButton.Name[^1].ToString());
        foreach (var rb in _radioButtons.Where(rb => rb != radioButton)) rb.Checked = false;

        switch (index)
        {
            case 1:
                if (string.IsNullOrEmpty(boxAnswer1.Text))
                {
                    MessageBox.Show(Resources.no_answer, Resources.error);
                    return;
                }

                _answer = 0;
                UpdateRawEditBox();
                break;
            case 2:
                if (string.IsNullOrEmpty(boxAnswer2.Text))
                {
                    MessageBox.Show(Resources.no_answer, Resources.error);
                    return;
                }

                if (string.IsNullOrEmpty(boxAnswer1.Text))
                {
                    MessageBox.Show(Resources.no_answer_above, Resources.error);
                    return;
                }

                _answer = 1;
                UpdateRawEditBox();
                break;
            case 3:
                if (string.IsNullOrEmpty(boxAnswer3.Text))
                {
                    MessageBox.Show(Resources.no_answer, Resources.error);
                    return;
                }

                if (string.IsNullOrEmpty(boxAnswer2.Text))
                {
                    MessageBox.Show(Resources.no_answer_above, Resources.error);
                    return;
                }

                _answer = 2;
                UpdateRawEditBox();
                break;
            case 4:
                if (string.IsNullOrEmpty(boxAnswer4.Text))
                {
                    MessageBox.Show(Resources.no_answer, Resources.error);
                    return;
                }

                if (string.IsNullOrEmpty(boxAnswer3.Text))
                {
                    MessageBox.Show(Resources.no_answer_above, Resources.error);
                    return;
                }

                _answer = 3;
                UpdateRawEditBox();
                break;
            case 5:
                if (string.IsNullOrEmpty(boxAnswer5.Text))
                {
                    MessageBox.Show(Resources.no_answer, Resources.error);
                    return;
                }

                if (string.IsNullOrEmpty(boxAnswer4.Text))
                {
                    MessageBox.Show(Resources.no_answer_above, Resources.error);
                    return;
                }

                _answer = 4;
                UpdateRawEditBox();
                break;
            default:
                throw new NotSupportedException();
        }
    }

    private void UpdateRawEditBox(bool refreshCheckbox = false)
    {
        if (refreshCheckbox) ChangeCorrectAnswer(_answer);

        var tempQuestions = (from textBox in _textBoxes where !string.IsNullOrEmpty(textBox.Text) select textBox.Text).ToList();
        var question = new Question
        {
            QuestionText = boxQuestion.Text,
            Answers = tempQuestions,
            CorrectAnswerIndex = _answer
        };

        var quiz = _quizzes[listQuizzes.SelectedIndex];
        var index = listQuestions.SelectedIndex;   
        if (index < 0 || index >= quiz.Questions.Count) return;
        quiz.Questions[index] = question;
        quiz.TimerInSeconds = (int)timer.ValueNumber;
        quiz.Title = boxQuizName.Text;
        editBox.Text = QuizHandlers.QuizToString(quiz);
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        var quiz = _quizzes[listQuizzes.SelectedIndex];
        new QuizForm(quiz, null).ShowDialog();
    }

    private void box_KeyPress(object sender, KeyPressEventArgs e)
    {
        UpdateRawEditBox();
    }

    private void editBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!QuizHandlers.ValidateQuiz(editBox.Text, out _)) return;

        var quiz = QuizHandlers.TextToQuiz(editBox.Text);
        if (quiz == null) return;
        boxQuizName.Text = quiz.Title;
        timer.ValueNumber = quiz.TimerInSeconds;
        _quizzes[listQuizzes.SelectedIndex] = quiz;

        var index = listQuestions.SelectedIndex;
        if (index < 0) return;
        var question = quiz.Questions[index];
        boxQuestion.Text = question.QuestionText;
        var answers = question.Answers;
        for (var i = 0; i < answers.Count; i++)
        {
            _textBoxes[i].Text = answers[i];
        }
        ChangeCorrectAnswer(question.CorrectAnswerIndex);
    }

    private void timer_Click(object sender, EventArgs e)
    {
        UpdateRawEditBox();
    }

    private void fbSave_Click(object sender, EventArgs e)
    {
        SaveQuestion();
    }
    
    private void SaveQuestion()
    {
        if (listQuizzes.SelectedIndex < 0) return;
        if (!_isCreatingQuestion) return;

        if (listQuestions.SelectedIndex < 0) return;
        var quiz = _quizzes[listQuizzes.SelectedIndex];
        var updatedQuiz = new Quiz
        {
            Title = quiz.Title,
            Questions = _tempQuestions,
            QuizDone = quiz.QuizDone,
            TimerInSeconds = quiz.TimerInSeconds
        };
        QuizApp.Repo.UpdateQuiz(quiz, updatedQuiz);
        MessageBox.Show(Resources.save_question_success, Resources.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
        _isCreatingQuestion = false;
        UpdateRawEditBox();
    }
    
    private bool IgnoreSaveQuestion()
    {
        if (!_isCreatingQuestion) return false;

        var result = MessageBox.Show(Resources.discard_question, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No) return true;
        _isCreatingQuestion = false;
        _tempQuestions.RemoveAt(_tempQuestions.Count - 1);
        listQuestions.Items.RemoveAt(listQuestions.Items.Count - 1);
        return false;
    }
}