namespace Wordlist.Models
{
    public class ValidWord
    {
        public IList<string> Words { get; }

        public ValidWord(IList<string> words)
        {
            Words = words;
        }
    }
}
