Console.WriteLine("Text:");

var text = Console.ReadLine();

Console.WriteLine("File Path:");

var filePath = Console.ReadLine();

File.WriteAllText(filePath, text);