class Program
{
    public static void Main(string[] args)
    {
        WordCounter wordCounter = new WordCounter("This is a test of a word counter test");
        Console.WriteLine(wordCounter.CountOccuranceOfSingleWord("test"));
        Console.WriteLine(wordCounter.CountOccuranceOfSingleWord("a"));
        WordCounter wordCounter1 = new WordCounter("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        Console.WriteLine(wordCounter1.CountOccuranceOfSingleWord("men"));
        Console.WriteLine(wordCounter1.CountOccuranceOfSingleWord("them"));

        WordCounter wordCounter2 = new WordCounter(@"C:\Users\ggodderi\OneDrive - BYU-Idaho\Documents\CSEE\ClassRepos\cse210RepoSpring25\CSE210TestApp\DeclarationOfIndependence.txt", 1);
        Console.WriteLine(wordCounter2.CountOccuranceOfSingleWord("men"));
        Console.WriteLine(wordCounter2.CountOccuranceOfSingleWord("them"));
        Console.WriteLine(wordCounter2.CountOccuranceOfSingleWord("people"));

        wordCounter1.CountAllWords();
        wordCounter1.DisplayAllWordCounts();
        wordCounter2.CountAllWords();
        wordCounter2.DisplayAllWordCounts();

    }
}
