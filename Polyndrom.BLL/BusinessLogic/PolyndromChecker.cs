using System;
using System.Collections.Generic;
using System.Text;

namespace Polyndrom.BLL.BusinessLogic
{
    public static class PolyndromChecker
    {
        public static bool IsTrue(string wordToCheck)
        {
            if(wordToCheck!=null && wordToCheck.Length>2)
            {
                var arr = wordToCheck.ToCharArray();
                Array.Reverse(arr);
                string reverseword = new string(arr);
                return wordToCheck.Equals(reverseword);
            }
            return false;

        }
    }
}
