using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criando a referência do versículo
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // 2. Criando o texto da escritura
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        // 3. Loop do programa de memorização
        while (!scripture.IsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                return;
            }

            // Esconde 3 palavras a cada repetição
            scripture.HideWord(3);
        }

        // Exibe a tela final com todas as palavras ocultas
        Console.Clear();
        Console.WriteLine(scripture.DisplayText());
        Console.WriteLine("\nAll words are hidden. Good job!");
    }
}

// ==========================================
// CLASS WORD
// ==========================================
public class Word
{
    private string _singleWord;
    private bool _isShown;

    public Word(string text)
    {
        _singleWord = text;
        _isShown = true;
    }

    public bool IsShown()
    {
        return _isShown;
    }

    public string DisplayWordText()
    {
        if (_isShown)
        {
            return _singleWord;
        }
        else
        {
            return new string('_', _singleWord.Length);
        }
    }

    public void Hide()
    {
        _isShown = false;
    }

    public void Show()
    {
        _isShown = true;
    }
}

// ==========================================
// CLASS REFERENCE
// ==========================================
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseInformation;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseInformation = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseInformation = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verseInformation == _endVerse)
        {
            return $"{_book} {_chapter}:{_verseInformation}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseInformation}-{_endVerse}";
        }
    }
}

// ==========================================
// CLASS SCRIPTURE
// ==========================================
public class Scripture
{
    private Reference _reference;
    private List<Word> _text = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _text.Add(new Word(word));
        }
    }

    public void HideWord(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _text.Where(w => w.IsShown()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string DisplayText()
    {
        string formattedText = string.Join(" ", _text.Select(w => w.DisplayWordText()));
        return $"{_reference.GetDisplayText()} - {formattedText}";
    }

    public bool IsHidden()
    {
        return _text.All(w => !w.IsShown());
    }
}