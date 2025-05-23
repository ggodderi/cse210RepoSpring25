class WordCounter
{
    private List<string>? _words;

    private Dictionary<string, int>? _allWordCounts;

    private void initalizeData()
    {
        _words = new List<string>();
        _allWordCounts = new Dictionary<string, int>();
    }
    public WordCounter()
    {
        initalizeData();
    }

    public WordCounter(string sentence)
    {
        initalizeData();
        SplitStringIntoWords(sentence);
    }

    public WordCounter(string filename, int x)
    {
        initalizeData();
        string fileData = File.ReadAllText(filename);
        SplitStringIntoWords(fileData);
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

    public void CountAllWords()
    {
        foreach (string word in _words)
        {
            if (_allWordCounts.ContainsKey(word))
            {
                _allWordCounts[word]++;
            }
            else
            {
                _allWordCounts.Add(word, 1);
            }
        }
    }

    public void DisplayAllWordCounts()
    {
        foreach (string key in _allWordCounts.Keys)
        {
            Console.WriteLine($"{key}: Count: {_allWordCounts[key]}");
        }
    }
}