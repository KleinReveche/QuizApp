using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Repo;
using Microsoft.VisualBasic.FileIO;

namespace QuizApp.Core.Data.Serializable;

public static class UsersImportManager
{
    public static List<User> ImportFromCsv(StreamReader stream, IRepo repo)
    {
        var users = new List<User>();
        using var csvParser = new TextFieldParser(stream);
        csvParser.CommentTokens = ["#"];
        csvParser.SetDelimiters([","]);
        csvParser.HasFieldsEnclosedInQuotes = false;
        csvParser.ReadLine();

        while (!csvParser.EndOfData)
        {
            var fields = csvParser.ReadFields();
            if (fields == null) continue;

            var user = new User
            {
                FirstName = fields[0],
                LastName = fields[1],
                Username = fields[2],
                Email = fields[3]
            };

            users.Add(user);
        }

        return users;
    }

    public static List<User> ImportFromCsv(string location, IRepo repo)
    {
        var users = new List<User>();
        using var csvParser = new TextFieldParser(location);
        csvParser.CommentTokens = ["#"];
        csvParser.SetDelimiters([","]);
        csvParser.HasFieldsEnclosedInQuotes = false;
        csvParser.ReadLine();

        while (!csvParser.EndOfData)
        {
            var fields = csvParser.ReadFields();
            if (fields == null) continue;

            var user = new User
            {
                FirstName = fields[0],
                LastName = fields[1],
                Username = fields[2],
                Email = fields[3]
            };

            users.Add(user);
        }

        return users;
    }
}

