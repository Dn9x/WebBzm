using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Util
{
    public sealed class InputUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsDangerous(string inputString)
        {
            string SqlStr = @"and|or|exec|execute|insert|select|delete|update|alter|create|drop|count|\*|chr|char|asc|mid|substring|master|truncate|declare|xp_cmdshell|restore|backup|net +user|net +localgroup +administrators";
            try
            {
                if ((inputString != null) && (inputString != String.Empty))
                {
                    string str_Regex = @"\b(" + SqlStr + @")\b";

                    Regex Regex = new Regex(str_Regex, RegexOptions.IgnoreCase);

                    if (true == Regex.IsMatch(inputString))
                        return false;

                }
            }
            catch
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ReplaceInput(string inputString)
        {
            string SqlStr = @"and|or|exec|execute|insert|select|delete|update|alter|create|drop|count|\*|chr|char|asc|mid|substring|master|truncate|declare|xp_cmdshell|restore|backup|net +user|net +localgroup +administrators";
            try
            {
                if ((inputString != null) && (inputString != String.Empty))
                {
                    string str_Regex = @"\b(" + SqlStr + @")\b";

                    Regex Regex = new Regex(str_Regex, RegexOptions.IgnoreCase);

                    MatchCollection matches = Regex.Matches(inputString);
                    for (int i = 0; i < matches.Count; i++)
                    {
                        inputString = inputString.Replace(matches[i].Value, "[" + matches[i].Value + "]");
                    }
                }
            }
            catch
            {
                return "";
            }

            return inputString;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="outputstring"></param>
        /// <returns></returns>
        public static string ReplaceOutput(string outputstring)
        {
            string SqlStr = @"and|or|exec|execute|insert|select|delete|update|alter|create|drop|count|\*|chr|char|asc|mid|substring|master|truncate|declare|xp_cmdshell|restore|backup|net +user|net +localgroup +administrators";
            try
            {
                if ((outputstring != null) && (outputstring != String.Empty))
                {
                    string str_Regex = @"\[\b(" + SqlStr + @")\b\]";
                    Regex Regex = new Regex(str_Regex, RegexOptions.IgnoreCase);
                    MatchCollection matches = Regex.Matches(outputstring);
                    for (int i = 0; i < matches.Count; i++)
                    {
                        outputstring = outputstring.Replace(matches[i].Value, matches[i].Value.Substring(1, matches[i].Value.Length - 2));
                    }
                }
            }
            catch
            {
                return "";
            }

            return outputstring;
        }


    }
}
