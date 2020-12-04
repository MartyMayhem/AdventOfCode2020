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
        public bool isValidPasswordProblemOne => passwordToValidate.Count(f => f == letterInPassword) >= lowValue && passwordToValidate.Count(f => f == letterInPassword) <= highValue;
        public int offsetlowValue => lowValue - 1;
        public int OffSetHighValue => highValue - 1;
        public bool IsCharacterInCorrectPlace =>
            (offsetlowValue -1 == 0 && OffSetHighValue - 1 == 0) ? false :
                (passwordToValidate[offsetlowValue] == letterInPassword && passwordToValidate[OffSetHighValue] != letterInPassword)
                || (passwordToValidate[offsetlowValue] != letterInPassword && passwordToValidate[OffSetHighValue] == letterInPassword);
            
        
    }

}
