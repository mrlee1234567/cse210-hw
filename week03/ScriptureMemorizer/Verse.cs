using System;
using System.Collections.Generic;

class Verse
{
    static int _verseNumber;
    static List<Word> _text;
    static string _verseString;
    static bool _isHideable;
    static string[] _splitList;

    public Verse(int verstNumber, string verseText)
    {
        int currentInd = 0;
        _verseString = verseText;
        string[] splits = verseText.Split(" ");
        _splitList = splits;
        List<Word> garbage = new List<Word>();
        for (int i = 0; i < splits.Count(); i++)
        {
            string iq;
            iq = string.Copy(splits[currentInd]);
            int wLen = iq.Count();
            garbage.Add(BuildWord(currentInd,wLen));
            // garbage.Distinct();
            currentInd++;
        }
        _text = garbage;
        _verseNumber = verstNumber;
        _isHideable = true;
    }

    static Word BuildWord(int versInd,int wLen)
    {
        Word bud = new Word(versInd, wLen);
        return bud;
    }

    public string GetVerse()
    {
        string res = $"{_verseNumber}:";
        
        foreach (Word i in _text)
        {
            if (i.CheckDisabled())
            {
                res += $" {i.GetUnderscore()}";
            }
            else
            {
                res += $" {_splitList[i.GetPrint()]}";
            }
            
            
        }
        res += "\n";
        return res;
    }

    public bool CheckHiding()
    {
        if (_isHideable)
        {
            bool hid = false;
            foreach (Word i in _text)
            {
                if (i.CheckDisabled())
                {
                    hid = true;
                }
            }
            _isHideable = hid;
        }
        return  _isHideable;
    }

    public void HideRandom(Random rNGenerator)
    {
        List<int> viableInts = new List<int>();
        
        for (int i = 0; i < _text.Count; i++)
        {
            Word iq = _text[i];
            if (iq.CheckDisabled())
            {
                viableInts.Add(i);
            }
        }
        if (viableInts.Count == 0)
        {
            _isHideable = false;
            return;
        }
        int disabame = rNGenerator.Next(viableInts.Count);
        _text[disabame].Disable();
    }

    
}