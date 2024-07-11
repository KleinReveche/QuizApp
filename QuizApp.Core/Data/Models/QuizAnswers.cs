namespace QuizApp.Core.Data.Models;

public class QuizAnswer
{
    public int Id { get; init; }
    public required int QuestionId { get; init; }
    public required int TakerId { get; init; }
    public required int AnswerIndex { get; init; }
    public required bool IsCorrect { get; init; }
}