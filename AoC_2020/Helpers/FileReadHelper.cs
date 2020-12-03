using AoC_2020.Problems.DayTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC_2020.Helpers
{
   public static class FileReadHelper
    {
        public static List<PasswordStruct> ReadPasswordFile(string[] passwords)
        {

            List<PasswordStruct> structs = new List<PasswordStruct>();


            for (var i = 0; i < passwords.Length; i++)
            {
                var splitStrings = InputSplit(passwords[i], ' ');
                string[] freq = splitStrings[0].Split('-');
                structs.Add(new PasswordStruct() { lowValue = Int16.Parse(freq.ElementAt(0)), highValue = Int16.Parse(freq.ElementAt(1)), letterInPassword = splitStrings[1].ElementAt(0), passwordToValidate = splitStrings[2] });
            }
            return structs;
        }
        public static string[] InputSplit(string line, char splitOnCharacter)
        {
            return line.Split(splitOnCharacter);
        }
    }
}
