namespace Wordlist.Services
{
    public interface ITextFileReaderService
    {
        IEnumerable<string> ReadAllWords();
    }
}
