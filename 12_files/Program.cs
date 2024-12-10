// File path:
// - relative path: /photos/image.png
// - absolute path C://Users/vlad/photos/image.png

 var fs = File.CreateText(@"test.txt");

 fs.WriteLine("Hello my dear file!");
 fs.WriteLine("How are you doing?");
 fs.WriteLine($"My name is {Console.ReadLine()}!!!");

 fs.Close();

File.Copy(@"test.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/copy_file.txt");

// works on Windows only
// File.Encrypt("test.txt");

var reader = File.OpenText("test.txt");

Console.WriteLine(reader.ReadLine());
Console.WriteLine(reader.ReadToEnd());

File.Delete("test.txt");