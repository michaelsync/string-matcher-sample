using System.Text;

namespace TextMatcher.Core
{
    public static class Extensions
    {
        public static string CutString(this string stringToBeCut, int startIndex, int length)
        {
            var sb = new StringBuilder();
            
            for (var i = startIndex; i < length; i++)
            {
                sb.Append(stringToBeCut[i]);
            }

            return sb.ToString();
        }    
    }
}