﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {

        public bool CharacterIsALetter(char c)
        {

            
               return (c >= 'a' && c <= 'z') ||
               (c >= 'A' && c <= 'Z');
            

            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;

            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;

            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num) % 2 == 1;

            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count<double>() == 0)
        
            return 0;
        
            return numbers.Max() + numbers.Min();

            //throw new NotImplementedException();
        }


    public int GetLengthOfShortestString(string str1, string str2)
        {

            return (str1.Length > str2.Length) ? str2.Length : str1.Length;

            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;


            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sumEvens = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvens += numbers[i];
                }
            }
            return sumEvens;

            //throw new NotImplementedException();

        }

        public bool IsSumOdd(List<int> numbers)
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

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            return number / 2;

            //throw new NotImplementedException();
        }
    }

}