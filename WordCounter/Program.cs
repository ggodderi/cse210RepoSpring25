﻿class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        WordCounter wordCounter = new WordCounter("This is a text string that will test my counter class to see if things work well text text.");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("text");

        Console.WriteLine($"The word: text, is found {count} times");
    }
}