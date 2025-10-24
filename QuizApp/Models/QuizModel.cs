using System;
using System.Collections.Generic;

namespace QuizApp.Models;

public class QuizModel
{
    private Random _rnd = new();

    public string Title { get; set; }
    public List<Question> Questions { get; set; } = new();
    
    public QuizModel(string title = "")
    {
        Title = title;
    }

    public Question GetRandomQuestion() =>
        Questions[_rnd.Next(0, Questions.Count)];

    public void AddQuestion(string statement, int correctAnswers,
        params string[] answers) => Questions.Add(new Question(statement, correctAnswers, answers));
    public void RemoveQuestion(int index) => Questions.RemoveAt(index);
}