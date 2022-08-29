namespace HelloWorldConsole;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        string fileName = "sampleQuotes.txt";
        string pathText = Path.Combine(Environment.CurrentDirectory, fileName);

        var lines = ReadFrom(pathText);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static IEnumerable<string> ReadFrom(string file)
    {
        string? line;
        using (var reader = File.OpenText(file))
        {
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}
