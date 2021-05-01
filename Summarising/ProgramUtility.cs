using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising
{
    public class ProgramUtility
    {
        public static string SummarizeText(String text, int max_length = 20)
        {
            if (text.Length < max_length)
            {
                return text;
            }
            var words = text.Split(' ');
            var totalCharacters = 0;

            var summaryWords = new List<String>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > max_length)
                    break;
            }
            return String.Join(" ", summaryWords) + " ...";

        }
    }
}
