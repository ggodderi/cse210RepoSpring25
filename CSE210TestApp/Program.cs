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
    }
}
