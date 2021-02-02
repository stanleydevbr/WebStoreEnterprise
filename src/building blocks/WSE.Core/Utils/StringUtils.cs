using System.Linq;

namespace WSE.Core.Utils
{
    public static class StringUtils
    {
        public static string ApenasNumeros(this string str, string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }
    }
}
