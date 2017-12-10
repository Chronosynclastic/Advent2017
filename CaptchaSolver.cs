using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2017
{
    public class CaptchaSolver
    {
        private CaptchaType Type { get; set; }
        private int captchaLength { get; set; }

        public CaptchaSolver(CaptchaType type)
        {
            Type = type;
        }

        public CaptchaSolver() : this(CaptchaType.Iterative)
        { }


        public int GetBasicCaptchaSum(string captcha)
        {
            int sumReturn = 0;
            int index = 0;
            captchaLength = captcha.Length;

            while(index < captchaLength)
            {
                var currentIndex = index;
                var comparisonIndex = this.GetComparisonIndex(currentIndex);

                if (captcha[currentIndex] == captcha[comparisonIndex])
                {
                    sumReturn += int.Parse(captcha[currentIndex].ToString());
                }

                index++;
            }


            return sumReturn;
        }

        private int GetComparisonIndex(int index)
        {
            int comparisonIndex = -1;

            switch(this.Type)
            {
                case CaptchaType.Iterative:
                    comparisonIndex = (index == captchaLength - 1) ? 0 : index + 1;
                    break;
                case CaptchaType.Circular:
                    var stepsAround = captchaLength / 2;
                    comparisonIndex = (index + stepsAround) % captchaLength;
                    break;
                default:
                    throw new ArgumentException("Captcha Type not defined! Cannot perform Comparison");
            }

            return comparisonIndex;
        }


    }

    public enum CaptchaType
    {
        Undefined = 0,
        Iterative,
        Circular
    }
}
