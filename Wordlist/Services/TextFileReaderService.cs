namespace Wordlist.Services
{
    public class TextFileReaderService : ITextFileReaderService
    {
        private readonly string _filePath;
        public TextFileReaderService(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<string> ReadAllWords()
        {
            return File.ReadLines(_filePath);
        }

    }
}
