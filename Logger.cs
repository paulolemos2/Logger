using System;
using System.IO;

public class Logger(string filePath)
{
    private readonly string _filePath = filePath; //constructor

    public void Log(string message, string severity)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string logContent = $"[{timestamp}] [{severity}] {message}";

        File.AppendAllText(_filePath, logContent + Environment.NewLine);
    }
}