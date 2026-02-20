namespace FileTools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> file1 = FileTools.FileList(@"C:\Users\radomyr.klymov\Downloads\CD-Manager-main.zip");

            Console.WriteLine(string.Join(Environment.NewLine, file1));
        }
    }
}
