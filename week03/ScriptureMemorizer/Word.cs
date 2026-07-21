using System;
using System.Collections.Generic;

class Word
{
    public int _wordRef;
    public string _printWord;
    public bool _disabled;
    public int _wordLen;

    public Word(int wordRef,int wordLength)
    {
        _wordRef = wordRef;
        _printWord = "";
        _wordLen = wordLength;
        _disabled = false;
        for (int i = 0; i < wordLength; i++)
        {
            _printWord += "_";
        }
        // Console.WriteLine(word);
    }

    public string GetUnderscore()
    {
        return _printWord;
    }

    public int GetPrint()
    {
        return _wordRef;
    }

    public void Disable()
    {
        if (!_disabled)
        {
            _disabled = true;
            // string ret = "";
            // for (int i = 0; i < _wordLen; i++)
            // {
            //     ret += "_";
            // }
            // _printWord = ret;
        }
    }

    public bool CheckDisabled()
    {
        return _disabled;
    }

}