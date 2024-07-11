using System.Text.Json;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Repo;
using QuizApp.Core.Utils;

namespace QuizApp.Core.Data.Serializable;

public static class QuizFilesManager
{
    private static readonly JsonSerializerOptions SourceGenOptions = new()
    {
        TypeInfoResolver = QuizJsonContext.Default,
        WriteIndented = true
    };

    private static readonly QuizJsonContext Context = new(SourceGenOptions);

    public static Quiz? LoadQuizJson(Stream stream, IRepo repo) => QuizHandlers.JsonToQuiz(repo, new StreamReader(stream).ReadToEnd(), Context);
    public static Quiz? LoadQuizQuiz(Stream stream, IRepo repo) => QuizHandlers.JsonToQuiz(repo, new StreamReader(stream).ReadToEnd(), Context, true);

    /**
     * Loads quiz from a formatted text file.
     * 
     * Formatting:
     * 
     * Use '*' to indicate correct answer.
     * 
     * Quiz Title
     * -----
     * Question 1
     * > Answer 1
     * >* Answer 2
     * > Answer 3
     * -----
     * Question 2
     * > Answer 1
     * > Answer 2
     * >* Answer 3
     * -----
     * Question 3
     * >* Answer 1
     * > Answer 2
     * 
     * @param stream The stream to read the quiz from.
     * @return The quiz object or null if the file is not formatted correctly.
     */
    public static Quiz? LoadQuizTxt(Stream stream, IRepo repo)
    {
        var quizText = new StreamReader(stream).ReadToEnd();
        return QuizHandlers.TextToQuiz(quizText);
    }

    public static void SaveQuizQuiz(Quiz quiz, string location)
    {
        var json = JsonSerializer.Serialize(quiz, Context.Quiz);
        File.WriteAllText(location, JsonScrambler.Encode(json));
    }

    public static void SaveQuizJson(Quiz quiz, string location)
    {
        var json = JsonSerializer.Serialize(quiz, Context.Quiz);
        File.WriteAllText(location, json);
    }

    public static void SaveQuizTxt(Quiz quiz, string location)
    {
        File.WriteAllText(location, QuizHandlers.QuizToString(quiz));
    }
}