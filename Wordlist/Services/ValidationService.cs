using Wordlist.Models;

namespace Wordlist.Services
{
    public class ValidationService : IValidationService
    {
        public IEnumerable<ValidWord> FindAllValidCombinations(IReadOnlyCollection<string> words, int wordLength)
        {
            var possibleValidCombination = words.Where(s => s.Length == wordLength).ToList();
            var joinableWords = words.Where(s => s.Length < wordLength).ToList();
            List<ValidWord> result = [];
            foreach (string possibleCombination in possibleValidCombination)
            {
                string remainingLetters = possibleCombination;
                ValidWord validWord = new ([]);
                int i = 0;
                while (i < joinableWords.Count && !string.IsNullOrEmpty(remainingLetters))
                {
                    var joinableWord = joinableWords[i];
                    if (!remainingLetters.StartsWith(joinableWord))
                    {
                        i++;
                        continue;
                    }

                    remainingLetters = remainingLetters[joinableWord.Length..];
                    validWord.Words.Insert(validWord.Words.Count, joinableWord);
                    if (string.IsNullOrEmpty(remainingLetters)) result.Add(validWord);
                    i = 0;
                }
            }

            return [.. result];
        }
    }
}
