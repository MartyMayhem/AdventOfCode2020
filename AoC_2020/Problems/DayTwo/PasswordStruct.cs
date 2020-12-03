using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC_2020.Problems.DayTwo
{
    public class PasswordStruct
    {
        public int lowValue { get; set; }
        public int highValue { get; set; }
        public char letterInPassword { get; set; }
        public string passwordToValidate { get; set; }
        public bool isValidPassword => passwordToValidate.Count(f => f == letterInPassword) >= lowValue && passwordToValidate.Count(f => f == letterInPassword) <= highValue;

    }
}
