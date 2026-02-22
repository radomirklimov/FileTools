namespace FileTools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileFields file1 = FileTools.FileList(@"C:\Users\Radomir\Downloads\auf_wiederholung.pdf");

            Console.WriteLine(string.Join(Environment.NewLine, file1));
        }
    }
}
