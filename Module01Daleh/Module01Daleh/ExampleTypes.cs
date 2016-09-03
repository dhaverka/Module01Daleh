using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Display of data types with a sample value
namespace Module02Daleh
{
    class ExampleTypes
    {
        static void Main(string[] args)
        {
            byte b1 = 0;
            byte b2 = 255;
            WriteLine("Data Types with an example of values");
            WriteLine("\nByte:");
            WriteLine("     Range of Byte values allowed are {0} thru {1}", b1, b2);
            WriteLine("     The highest byte value 255 is also known as hexadecimal value {0}", b2.ToString("X2"));
            char c1 = '\u005C';
            WriteLine("\nChar Unicode:");
            WriteLine("     Which character has a Unicode value of 005C?  It is the {0}", c1.ToString());
            WriteLine("\nShort:");
            short s1 = -32768;
            short s2 = 32767;
            int s3;
            s3 = s2 + (s1 * -1);
            WriteLine("     Guess how many integer values exist between low short {0} and high short {1} .  Answer is: {2}", s1.ToString(), s2.ToString(), s3.ToString());
            WriteLine("\nInt:");
            int i1 = -2147483648;
            int i2 = 2147483647;
            WriteLine("     Wow, a lot of values exist between low int {0} and high int {1}", i1.ToString(), i2.ToString());
            WriteLine("\nLong:");
            long l1 = 9223372036854775807;
            WriteLine("     KC Royals player Alex Gordon coverage of left field is this many strands of grass.");
            WriteLine("     {0}", l1.ToString("N0"));
            WriteLine("\nFloat:");        
            float f1 = 0F;       
            WriteLine("     Did you know that float values are 7 significant digits of accuracy");
            WriteLine("     My accrual value is 1234.56789");
            f1 = 1234.567879F;
            WriteLine("     My bank account is gaining in this rounded accrued interest. Isn't floating great.");         
            WriteLine("     {0}", f1.ToString("F3"));
            WriteLine("\nDouble:");
            double d1 = 777777777.9898;
            WriteLine("     Yes, that is alot of 7 values. More than a double trouble of 98.");
            WriteLine("     {0}", d1.ToString("0.0000"));
            bool bull;
            bull = false;
            WriteLine("\nBoolean\n     Initially, a boolean value is: {0}", bull);
            bull = true;
            WriteLine("     But, you can make it: {0}", bull);
            string story = "Some programmers will write alot of code for a Module 02 assignment";
            WriteLine("\nString\n     {0}.\n\nThe End of Assignment - Hope you had fun", story);
            ReadLine();
        }
    }
}
