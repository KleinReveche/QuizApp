using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Core.Data.Models;

public class Quiz
{
    public int Id { get; init; }
    [StringLength(1024)] public required string Title { get; set; }
    public required List<Question> Questions { get; init; }
    public required bool QuizDone { get; init; }
    public required int TimerInSeconds { get; set; } = 60;
}

public class Question
{
    public int Id { get; init; }
    [StringLength(1024)] public required string QuestionText { get; set; }
    public required List<string> Answers { get; set; }
    public required int CorrectAnswerIndex { get; set; }
}

public class TakerScore
{
    public int Id { get; init; }
    public required int UserId { get; init; }
    public required int? Score { get; init; }
    public required DateTime? DateTaken { get; init; }
    public required List<int> Answers { get; init; }
    public required int QuizId { get; init; }
}


[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(Quiz))]
public partial class QuizJsonContext : JsonSerializerContext;