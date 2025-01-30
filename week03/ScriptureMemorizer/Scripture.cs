using System;
using System.Collections.Generic;

public class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");

        _words = new List<Word>();
        foreach (string w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    // Choose random words from the list
    // Verify if the word is not already hidden
    // If it is not hidden, call the required method to hide it
    {
        Random random = new Random();
        int hiddenWords = 0;

        while (hiddenWords < numberToHide)
        {
            int wordIndex = random.Next(_words.Count);

            if (!_words[wordIndex].IsHidden())
            {
                _words[wordIndex].Hide();
                hiddenWords++;
            }
        }
    }

    public string GetDisplayText()
    // display each hidden and shown word in the correct order 
    {
        string display = "";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display;
    }

    public bool IsCompletelyHidden()
    // check if the words are hidden
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}