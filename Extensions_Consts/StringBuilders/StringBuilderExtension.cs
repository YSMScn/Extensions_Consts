using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.StringBuilders
{
    public static class StringBuilderExtension
    {
        public static StringBuilder TrimEnd(this StringBuilder sb, string target = "")
        {
            if (sb?.Length == 0 || target.Length > sb?.Length)
            {
                return sb;
            }
            if (string.IsNullOrWhiteSpace(target))
            {
                TrimEndWhiteSpace(sb);
            }
            else
            {
                var targetLength = target.Length;
                var sbLength = sb.Length;
                var firstIndex = sbLength - targetLength;
                var needTrim = true;
                for(var i = 0; firstIndex < sbLength; i++)
                {
                    if (!sb[firstIndex + i].Equals(target[i]))
                    {
                        needTrim = false;
                        break;
                    }
                }
                if (needTrim)
                {
                    sb.Length = firstIndex + 1;
                }
            }
            return sb;
        }

        public static StringBuilder TrimEnd(this StringBuilder sb, char target)
        {
            return TrimEnd(sb, target.ToString());
        }

        private static void TrimEndWhiteSpace(StringBuilder sb)
        {
            var index = sb.Length - 1;
            for (; index >= 0; index--)
            {
                if (!char.IsWhiteSpace(sb[index]))
                {
                    break;
                }
            }
            if (index < sb.Length - 1)
            {
                sb.Length = index + 1;
            }
        }
    }
}
