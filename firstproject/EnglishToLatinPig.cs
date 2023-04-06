using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class EnglishToLatinPig
    {
        public static Action<dynamic> print = (x) => Console.WriteLine(x);
        public EnglishToLatinPig(string word) {
            while (true)
            {
                giveMainPrompt();
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "a":
                        print("Enter your Word");
                        string input = Console.ReadLine();
                        Console.WriteLine(PigLatinTranslator.TranslateWord(input)); 
                        break;
                    case "b":
                        print("Enter your Sentance");
                        input = Console.ReadLine();
                        Console.WriteLine(PigLatinTranslator.TranslateSentence(input)); 
                        break;
                    case "c":
                        return;
                    default:
                        print("Invalid Option");
                        break;
                }
            }
        }
        public static void giveMainPrompt()
        {
            print(@"Enter any option
                a) Translate a word
                b) Translate a sentance
                c) Exit");
        }
        public class PigLatinTranslator
{
    static char[] VOWELS = { 'a', 'e', 'i', 'o', 'u' };
    
    public static string TranslateWord(string word)
    {
            // "" -> ""
        if (string.IsNullOrWhiteSpace(word))
        {
            return word;
        }
        // apple -> appleyay
        if (VOWELS.Contains(char.ToLower(word[0])))
        {
            return word + "yay";
        }
        // flag -> alfgay
        else
        {
            int i = 0;
            while (i < word.Length && !VOWELS.Contains(char.ToLower(word[i])))
            {
                i++;
            }
            return word.Substring(i) + word.Substring(0, i) + "ay";
        }
    }
    
    public static string TranslateSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = TranslateWord(words[i]);
        }
        return string.Join(" ", words);
    }
}
    }
}
