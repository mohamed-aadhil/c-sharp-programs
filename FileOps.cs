using System;
using System.IO;
using System.Text;
using System.Diagnostics;

class FileOps
{
    static void Main()
    {
        string filePath = "test.txt";
        string message = "This is a repeated line of text to test efficiency.\n";

        int repeatCount = 10000; // Simulate large data

        // --- Write using string ---
        Stopwatch sw1 = Stopwatch.StartNew();
        string longText = "";
        for (int i = 0; i < repeatCount; i++)
        {
            longText += message; // Inefficient string concatenation
        }

        File.WriteAllText(filePath, longText); // Write to file
        sw1.Stop();
        Console.WriteLine($"[Write] Using string took: {sw1.ElapsedMilliseconds} ms");

        // --- Read using string ---
        Stopwatch sw2 = Stopwatch.StartNew();
        string readData = File.ReadAllText(filePath);
        string[] lines = readData.Split('\n');
        string combined = "";
        foreach (string line in lines)
        {
            combined += line + "\n"; // Again, inefficient
        }
        sw2.Stop();
        Console.WriteLine($"[Read] Using string took: {sw2.ElapsedMilliseconds} ms");

        Console.WriteLine();

        // --- Write using StringBuilder ---
        Stopwatch sw3 = Stopwatch.StartNew();
        StringBuilder sbWrite = new StringBuilder();
        for (int i = 0; i < repeatCount; i++)
        {
            sbWrite.Append(message); // Efficient
        }

        File.WriteAllText(filePath, sbWrite.ToString()); // Write to file
        sw3.Stop();
        Console.WriteLine($"[Write] Using StringBuilder took: {sw3.ElapsedMilliseconds} ms");

        // --- Read using StringBuilder ---
        Stopwatch sw4 = Stopwatch.StartNew();
        string readBack = File.ReadAllText(filePath);
        string[] readLines = readBack.Split('\n');
        StringBuilder sbRead = new StringBuilder();
        foreach (string line in readLines)
        {
            sbRead.Append(line).Append('\n'); // Efficient
        }
        sw4.Stop();
        Console.WriteLine($"[Read] Using StringBuilder took: {sw4.ElapsedMilliseconds} ms");
    }
}
