using System;

public class MathAssignment : Assignment
{
    public string _textbookSection = "";
    public string _problems = "";

    public string GetHomeworkList()
    {
        return _textbookSection + _problems;
    }
}