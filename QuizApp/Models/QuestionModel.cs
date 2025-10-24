using System;

namespace QuizApp.Models;

public class Question
{
    private string[] _answers = new string[4];

    public Guid Id { get; } = Guid.NewGuid();
    public string Statement { get; }

    public string[] Answers
    {
        get => _answers;
        private set
        {
            if (value.Length > 4)
                throw new ArgumentException(
                    "Answers can contain at most 4 items.");
            _answers = value;
        }
    }

    public string CorrectAnswers { get; }
    public bool IsAnswered { get; set; }

    public Question(string statement, int correctAnswers,
        params string[] answers)
    {
        Statement = statement;
        Answers = answers;
        CorrectAnswers = answers[correctAnswers];
    }
    
    public bool IsCorrect (string str)=> str.Equals(CorrectAnswers);

}