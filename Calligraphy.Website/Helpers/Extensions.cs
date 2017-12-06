using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Calligraphy.Helpers
{
    public static class Extensions
    {
        public static string TruncateSentence(this string str, int wordCount)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                var sentence = new StringBuilder();
                var bits = str.Split(char.Parse(" "));
                for(int i=0; i < bits.Length; i++)
                {
                    if (i <= wordCount - 1 && !string.IsNullOrWhiteSpace(bits[i])) {
                        sentence.Append(string.Format("{0} ", bits[i]));
                    }
                }
                return sentence.Remove(sentence.Length-1, 1).Append("...").ToString();
            }
            return str;
        }
    }
}