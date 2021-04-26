using System;

namespace CanonDemoNS
{
    public class OctalUtility
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OctalToUInt("747777777777"));
        }

        public static uint OctalToUInt(String octal)
        {

            //loop through each digit from right to left
            //multiply the digit by 8^(number of digits) and add the result to total
            uint multiplier = 1;
            uint total = 0;
            for (int i = octal.Length-1; i > -1; i--)
            {
                char c = octal[i];
                uint digit = 0;
                if ('0' == c)
                {
                    digit = 0;
                } else if ('1' == c)
                {
                    digit = 1;
                }
                else if ('2' == c)
                {
                    digit = 2;
                }
                else if ('3' == c)
                {
                    digit = 3;
                }
                else if ('4' == c)
                {
                    digit = 4;
                }
                else if ('5' == c)
                {
                    digit = 5;
                }
                else if ('6' == c)
                {
                    digit = 6;
                }
                else if ('7' == c)
                {
                    digit = 7;
                } else
                {
                    throw new Exception("Parse failed - not a valid octal string");
                }

                //check for overflow - throws OverflowException if any uint exceeds the maximum valid uint value
                checked
                {
                    total += multiplier * digit;
                }
                
                multiplier *= 8;
            }

            return total;
        }

    }
}
