﻿string str;
string strres = "";
char cres;

Console.WriteLine("Введите строку:");
str = Console.ReadLine();

foreach (char c in str)
{
    if (Char.IsLetter(c))
    {
        if (c == 'ё')
        {
            cres = (char)((int)c - 80);
        }
        else if (c == 'Ё')
        {
            cres = (char)((int)c + 80);
        }
        else if (Char.IsUpper(c))
        {
            cres = (char)((int)c + 32);
        }
        else
        {
            cres = (char)((int)c - 32);
        }
        strres += cres;
    }
    else
    {
        strres += c;
    }

}

Console.WriteLine(strres);