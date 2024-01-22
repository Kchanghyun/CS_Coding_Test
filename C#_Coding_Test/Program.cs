using System;
using System.Collections.Generic;

public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    public void Print() {
        new PrintReport().Print(this);
    }

    public void SaveToFile(string fileName) {
        new ReportSaveToFile().SaveToFile(fileName);
    }

    public void LoadFromDatabase(int reportId) {
        new ReportLoadFromDatabase().LoadFromDatabase(reportId);
    }
}

// PrintReport클래스는 Print만 할 수 있게
public class PrintReport {
    public void Print(Report report) {
        Console.WriteLine("Printing Report...");
        Console.WriteLine($"Title: {report.Title}");
        Console.WriteLine($"Content: {report.Content}");
    }
}

// ReportSaveToFile클래스는 객체의 Title과 Content를 파일에 저장하는 기능만
public class ReportSaveToFile {
    public void SaveToFile(string fileName) {
        Console.WriteLine($"Saving Report to {fileName}...");
        // 파일에 저장하는 로직
        // Title과 Content가 fileName에 저장되는거겠지?
    }
}

//데이터베이스는 잘 모르지만 1에 해당하는 데이터를 불러오겠지 뭐..
public class ReportLoadFromDatabase {
    public void LoadFromDatabase(int reportId) {
        Console.WriteLine($"Loading Report from Database with ID: {reportId}");
        // 데이터베이스에서 레포트를 로딩하는 로직
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