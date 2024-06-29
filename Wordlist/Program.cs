// See https://aka.ms/new-console-template for more information
using Wordlist.Helpers;
using Wordlist.Services;

internal class Program
{
    private static void Main()
    {
        var textFilePath = PathHelper.GetValidatedFilePath("../../../Data/wordlist.txt");
        ITextFileReaderService textFileReaderService = new TextFileReaderService(textFilePath);
        IValidationService validationService = new ValidationService();

        var wordList = textFileReaderService.ReadAllWords().ToList();
        var validWord = validationService.FindAllValidCombinations(wordList, 6);

        foreach (var word in validWord)
        {
            Console.WriteLine($"{word.Words[0]} + {word.Words[1]} => { string.Join("",word.Words)}");
        }
    }
}