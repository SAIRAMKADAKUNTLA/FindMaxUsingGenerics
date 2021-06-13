using System;
using System.Collections.Generic;
using System.Text;

namespace FindmaxOf3
{
    public class Maximum
    {
        public int FindIntMax(int firstNumber,int secondNumber,int thirdNumber)
        {
            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }         
            
        }
        public float FindFloatMax(float firstNumber, float secondNumber, float thirdNumber)
        {
            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
                return thirdNumber;
        }
        public string FindStringMax(string first,string second,string third)
        {
            if (first.CompareTo(second) > 0 && (first.CompareTo(third) > 0) ||
               first.CompareTo(second) >= 0 && (first.CompareTo(third) > 0) ||
               first.CompareTo(second) > 0 && (first.CompareTo(third) >= 0))
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && (second.CompareTo(third) > 0) ||
                second.CompareTo(first) >= 0 && (second.CompareTo(third) > 0) ||
                second.CompareTo(first) > 0 && (second.CompareTo(third) >= 0))
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && (third.CompareTo(second) > 0) ||
                third.CompareTo(first) >= 0 && (third.CompareTo(second) > 0) ||
                third.CompareTo(first) > 0 && (third.CompareTo(second) >= 0))
            {
                return third;
            }
            return default;
        }

    }
}
