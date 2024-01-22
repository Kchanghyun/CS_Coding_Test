using System;
using System.Collections.Generic;

public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    public void Print()
    {
        Console.WriteLine("Printing Report...");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
    }

    public void SaveToFile(string fileName)
    {
        Console.WriteLine($"Saving Report to {fileName}...");
        // 여기서 파일에 저장하는 로직이 들어갈 것임
    }

    public void LoadFromDatabase(int reportId)
    {
        Console.WriteLine($"Loading Report from Database with ID: {reportId}");
        // 여기서 데이터베이스에서 레포트를 로딩하는 로직이 들어갈 것임
    }
}

class Program
{
    static void Main(string[] args)
    {
        Report report = new Report()
        {
            Title = "My Report",
            Content = "This is a report content."
        };

        report.Print();
        report.SaveToFile("report.txt");
        report.LoadFromDatabase(1);
    }
}