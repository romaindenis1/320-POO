using System;
using System.IO; // 💻 Import the necessary namespace for file handling

class Program
{
    static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 🖥️ Get the path to the desktop
        string filePath = Path.Combine(desktopPath, "beuzi_results.txt"); // 📂 Specify the full path for the file
        using (StreamWriter writer = new StreamWriter(filePath)) // 🖊️ Open the file for writing
        {
            for (int i = 1; i <= 999999999; i++) // 🔄 Count from 1 to 70
            {
                if (i % 7 == 0 || i.ToString().Contains("7")) // 🎉 Check for "Beuzi"
                {
                    writer.WriteLine($"BEUZI ({i}) "); // Write "Beuzi" to the file
                }
                else
                {
                    writer.WriteLine(i); // Write the number to the file
                }
            }
        }

        Console.WriteLine($"Results have been written to {filePath} 🎉✨"); // 🥳 Message confirming the file creation
    }
}
