using Wordlist.Models;

namespace Wordlist.Services
{
    internal interface IValidationService
    {
        IEnumerable<ValidWord> FindAllValidCombinations(IReadOnlyCollection<string> words, int wordLength);
    }
}
