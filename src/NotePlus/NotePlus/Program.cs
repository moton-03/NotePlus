Console.WriteLine("Text:");

string text = Console.ReadLine();

Console.WriteLine("File Path:");

string filePath;

do
{
    filePath = Console.ReadLine();
} while (filePath == "");


File.WriteAllText(filePath, text);