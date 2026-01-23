using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // =========================
    // Private Member Variables
    // =========================
    private Reference _reference;
    private List<Word> _words;

    // =========================
    // Constructor
    // =========================
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // =========================
    // Display Scripture
    // =========================
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return $"{referenceText}\n{wordsText}";
    }

    // =========================
    // Hide Random Words
    // =========================
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // =========================
    // Check Completion
    // =========================
    public bool IsCompletelyHidden()
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
