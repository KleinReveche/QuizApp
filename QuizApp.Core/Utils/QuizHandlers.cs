using System.Text;
using System.Text.Json;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Repo;

namespace QuizApp.Core.Utils;

public static class QuizHandlers
{
    public const string NewLineIndicator = "<br>";
    public const string QuizSeparator = "-----";
    
    public static string QuizToString(Quiz quiz)
    {
        var sb = new StringBuilder();
        sb.AppendLine(quiz.Title);
        sb.AppendLine(quiz.TimerInSeconds.ToString());
        sb.AppendLine(QuizSeparator);
        foreach (var question in quiz.Questions)
        {
            sb.AppendLine(question.QuestionText);
            for (var i = 0; i < question.Answers.Count; i++)
            {
                sb.Append(question.CorrectAnswerIndex == i ? ">*" : ">");
                sb.Append(' ');
                sb.AppendLine(question.Answers[i]);
            }
            sb.AppendLine(QuizSeparator);
        }
        return sb.ToString();
    }
    
    public static bool ValidateQuiz(string quiz, out string errorMessage)
    {
        var blocks = quiz.Split(QuizSeparator, StringSplitOptions.TrimEntries);
        if (blocks.Length < 2) 
        {
            errorMessage = "Quiz must have at least one question.";
            return false;
        }

        var titleBlock = blocks[0].Split(Environment.NewLine);

        if (titleBlock.Length < 2) {
            errorMessage = "Quiz must have a title and a timer.";
            return false;
        }

        var title = titleBlock[0];
        var timer = titleBlock[1];

        if (string.IsNullOrEmpty(title)) 
        {
            errorMessage = "Quiz must have a title.";
            return false;
        }

        if (string.IsNullOrEmpty(timer))
        {
            errorMessage = "Quiz must have a timer.";
            return false;
        }

        if (!int.TryParse(timer, out _))
        {
            errorMessage = "Timer must be a number in seconds.";
            return false;
        }

        for (var i = 1; i < blocks.Length; i++)
        {
            if (string.IsNullOrEmpty(blocks[i])) continue;
            var lines = blocks[i].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length < 3) 
            {
                errorMessage = "Question must have at least one answer.";
                return false;
            }

            var questionText = lines[0].Trim();
            if (string.IsNullOrEmpty(questionText)) 
            {
                errorMessage = "Question must have text.";
                return false;
            }

            var hasCorrectAnswer = false;
            for (var j = 1; j < lines.Length; j++)
            {
                var answer = lines[j].Trim();
                if (answer.StartsWith(">* "))
                {
                    if (hasCorrectAnswer) 
                    {
                        errorMessage = "Question must have only one correct answer.";
                        return false;
                    }
                    hasCorrectAnswer = true;
                }
                else if (!answer.StartsWith("> "))
                {
                    errorMessage = "Answer must start with '>' or '>*'.";
                    return false;
                }
            }

            if (hasCorrectAnswer) continue;
            errorMessage = "Question must have a correct answer.";
            return false;
        }

        errorMessage = string.Empty;
        return true;
    }

    public static Quiz? TextToQuiz(string quizText)
    {
        var text = quizText.Trim().Split(QuizSeparator, StringSplitOptions.TrimEntries);
        var titleBlock = text[0].Split(Environment.NewLine);
        var quizTitle = titleBlock[0].Trim();
        var timer = titleBlock[1].Trim();
        var questions = new List<Question>();
        
        foreach (var question in text.Skip(1))
        {
            if (string.IsNullOrEmpty(question)) continue;
            var lines = question.Trim().Split(Environment.NewLine);
            var questionText = lines[0].Trim();
            var answers = new List<string>();
            var correctAnswerIndex = -147;
            
            for (var i = 1; i < lines.Length; i++)
            {
                var answer = lines[i].Trim();
                if (!answer.StartsWith('>')) continue;
                if (answer.StartsWith(">*")) correctAnswerIndex = i - 1;
                answers.Add(answer.Replace(">* ", "").Replace("> ", ""));
            }
            
            if (correctAnswerIndex == -147) return null;
            
            var q = new Question
            {
                QuestionText = questionText,
                Answers = answers,
                CorrectAnswerIndex = correctAnswerIndex
            };
            questions.Add(q);
        }

        return new Quiz
        {
            Title = quizTitle,
            Questions = questions,
            QuizDone = false,
            TimerInSeconds = int.Parse(timer)
        };
    }

    public static Quiz? JsonToQuiz(IRepo repo, string json, QuizJsonContext context, bool scrambled = false)
    {
        try
        {
            var oldQuiz = JsonSerializer.Deserialize(scrambled ? JsonScrambler.Decode(json) : json, context.Quiz);
            if (oldQuiz == null) return null;

            var questions = oldQuiz.Questions.Select(oldQuestion => new Question { QuestionText = oldQuestion.QuestionText, Answers = oldQuestion.Answers, CorrectAnswerIndex = oldQuestion.CorrectAnswerIndex }).ToList();

            return new Quiz
            {
                Title = oldQuiz.Title,
                Questions = questions,
                QuizDone = oldQuiz.QuizDone,
                TimerInSeconds = oldQuiz.TimerInSeconds
            };
        }
        catch
        {
            return null;
        }
    }
}