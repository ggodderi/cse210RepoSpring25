class WordCounter
{
    private List<string> _words;

    public WordCounter()
    {
        _words = new List<string>();
    }

    public WordCounter(string sentence)
    {
        _words = new List<string>();
        SplitStringIntoWords(sentence);
    }

    private void SplitStringIntoWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(word);
        }
    }

    public int CountOccuranceOfSingleWord(string wordToCount)
    {
        int count = 0;
        foreach (string word in _words)
        {
            if (word == wordToCount)
            {
                count++;
            }
        }
        return count;
    }
}