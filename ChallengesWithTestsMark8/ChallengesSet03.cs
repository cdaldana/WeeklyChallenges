using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == false)
                {
                    return true;
                }
            }
            return false;



            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int oddCount = 0;
            foreach (int t in numbers)
            {
                if (Math.Abs(t) % 2 == 1)
                {
                    oddCount++;
                }
            }
            return oddCount % 2 == 1;

            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false; bool hasLower = false; bool hasDigit = false;

            for (int i = 0; i < password.Length && !(hasUpper && hasLower && hasDigit); i++)
            {
                char c = password[i];
                if (!hasUpper) hasUpper = char.IsUpper(c);
                if (!hasLower) hasLower = char.IsLower(c);
                if (!hasDigit) hasDigit = char.IsDigit(c);

                
            }

            return hasUpper && hasLower && hasDigit;

            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
            //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            var answer = new int[50];
            int m = 0;
            for (int i = 1; i < 100; i += 2)
            {
                answer[m] = i;
                m++;
            }

            return answer;
            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            //throw new NotImplementedException();
        }
    }
}
