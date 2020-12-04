using AoC_2020.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC_2020.Problems.DayTwo
{
   public static class DayTwo
    {
        public static string ValidPasswordCountProblemOne(string[] passwords)
        {
            return FileReadHelper.ReadPasswordFile(passwords).Where(r => r.isValidPasswordProblemOne == true).Count().ToString();
        }
        public static string ValidPasswordCountProblemTwo(string[] passwords)
        {
            return FileReadHelper.ReadPasswordFile(passwords).Where(r => r.IsCharacterInCorrectPlace == true).Count().ToString();
        }
    }
}
