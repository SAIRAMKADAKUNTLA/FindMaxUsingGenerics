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
                return thirdNumber;
        }

    }
}
