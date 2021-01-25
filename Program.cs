using System;

namespace Lap_2_Basic_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //50
            //CheckIfTwoOrMoreHaveSameRightDigit(11, 21, 31);
            //CheckIfTwoOrMoreHaveSameRightDigit(11, 22, 31);
            //CheckIfTwoOrMoreHaveSameRightDigit(11, 22, 33);

            //51
            //CheckTreeValues(11, 21, 31);
            //CheckTreeValues(11, 22, 31);
            //CheckTreeValues(10, 20, 15);

            //52
            //CheckTreeValues(11, 21);
            //CheckTreeValues(11, 20);
            //CheckTreeValues(10, 10);

            //53
            //CheckTwoValues(11, 21);
            //CheckTwoValues(11, 20);
            //CheckTwoValues(10, 10);

            //54
            //CheckSumTwoValues(4, 5);
            //CheckSumTwoValues(7, 4);
            //CheckSumTwoValues(10, 10);

            //55
            //CkeckSumThreeValues(4, 5, 7);
            //CkeckSumThreeValues(7, 4, 12);
            //CkeckSumThreeValues(10, 10, 12);
            //CkeckSumThreeValues(12, 12, 18);

            //56
            //CheckSumThreeValues2(4, 5, 7);
            //CheckSumThreeValues2(7, 4, 12);
            //CheckSumThreeValues2(10, 13, 12);
            //CheckSumThreeValues2(13, 12, 18);

            //57
            //CheckSumthreeValues3(4, 5, 7);
            //CheckSumthreeValues3(7, 4, 12);
            //CheckSumthreeValues3(10, 13, 12);
            //CheckSumthreeValues3(17, 12, 18);

            //58
            //CheckTwoValues2(4, 5);
            //CheckTwoValues2(7, 12);
            //CheckTwoValues2(10, 13);
            //CheckTwoValues2(17, 33);

            //59
            //CheckThreeValues(4, 5, 6);
            //CheckThreeValues(7, 12, 13);
            //CheckThreeValues(-1, 0, 1);

            //60
            //CreateNewSringFromeGivenString("Hi", "Hello");
            //CreateNewSringFromeGivenString("whats", "app");

            //61
            //InsertStringIntoAndotherString("[[]]", "Hello");
            //InsertStringIntoAndotherString("(())", "Hi");

            //62
            //CreateNewStringUsingThreeCopiesOfLastChar("Hello");
            //CreateNewStringUsingThreeCopiesOfLastChar("Hi");

            //63
            //CreateNewString("Hello");
            //CreateNewString("Hi");
            //CreateNewString("H");
            //CreateNewString(" ");

            //64
            //CreateNewString2("Hello");
            //CreateNewString2("Hi");

            //65
            //CreateNewString3("Hello");
            //CreateNewString3("Hi");
            //CreateNewString3("Python");

            //66
            //CrateNewString4("Hello", "Hi");
            //CrateNewString4("JS", "Python");

            //67
            CreateNewStringRemoveFirstChar("Hello", "Hi");
            CreateNewStringRemoveFirstChar("JS", "Python");






        }

        //50_Write a C# Sharp program to check if two or more non-negative given integers have
        //the same rightmost digit.
        public static void CheckIfTwoOrMoreHaveSameRightDigit(int value1,int value2,int value3)
        {
            var v1 = value1.ToString();
            var v2 = value2.ToString();
            var v3 = value3.ToString();

            Console.WriteLine(v1[v1.Length - 1] == v2[v2.Length - 1] || v2[v2.Length - 1] == v3[v3.Length - 1] || v1[v1.Length - 1] == v3[v3.Length - 1]);
        }

        //51_ Write a C# Sharp program to check three given integers and return true if one of 
        //them is 20 or more less than one of the others.
        public static void CheckTreeValues(int v1,int v2 ,int v3)
        {
            Console.WriteLine(Math.Abs(v1 - v2) >= 20 || Math.Abs(v2 - v3) >= 20 || Math.Abs(v1 - v3) >= 20);

        }

        //52_Write a C# Sharp program to find the larger from two given integers. However if the
        //two integers have the same remainder when divided by 7, then the return the smaller
        //integer. If the two integers are the same, return 0.
        public static void CheckTreeValues(int v1, int v2)
        {
            if (v1 == v2)
                Console.WriteLine("0");
            else if (v1 % 7 == v2 % 7)
                Console.WriteLine(Math.Min(v1, v2));
            else
                Console.WriteLine(Math.Max(v1, v2));
        }

        //53_ Write a C# Sharp program to check two given integers, each in the range 10..99. 
        //Return true if a digit appears in both numbers, such as the 3 in 13 and 33.
        public static void CheckTwoValues(int v1 ,int v2)
        {
            string _v1 = v1.ToString();
            string _v2 = v2.ToString();

            Console.WriteLine(v1 >= 10 && v1 <= 99 && v2 >= 10 && v2 <= 99 &&_v1[1] == _v2[1]);
        }

        //54_Write a C# Sharp program to compute the sum of two given non-negative integers x and
        //y as long as the sum has the same number of digits as x. If the sum has more digits 
        //than x then return x without y. 
        public static void CheckSumTwoValues(int v1, int v2)
        {

            if ((v1 + v2).ToString().Length == v1.ToString().Length)
                Console.WriteLine(v1 + v2);
            else
                Console.WriteLine(v1);

        }

        //55_Write a C# Sharp program to compute the sum of three given integers. If the two 
        //values are same return the third value.
        public static void CkeckSumThreeValues(int v1,int v2 ,int v3)
        {
            if (v1 == v2)
                Console.WriteLine(v3);
            else
                Console.WriteLine(v1 + v2 + v3);
        }

        //56_Write a C# Sharp program to compute the sum of the three integers. If one of the 
        //values is 13 then do not count it and its right towards the sum.
        public static void CheckSumThreeValues2(int v1,int v2,int v3)
        {
            int[] values = { v1, v2, v3 };
            int count = 0;

            for (int i = 0; i < values.Length ; i++)
            {
                if (values[i] == 13)
                    break;
                else
                    count += values[i];
            }

            Console.WriteLine(count);
        }

        //57_Write a C# Sharp program to compute the sum of the three given integers. However, 
        //if any of the values is in the range 10..20 inclusive then that value counts as 0, 
        //except 13 and 17.
        public static void CheckSumthreeValues3(int v1,int v2,int v3)
        {
            int[] values = { v1, v2, v3 };
            int count = 0;

            foreach (int item in values)
            {
                if (item >= 10 && item <= 20)
                {
                    if (item == 13 || item == 17)
                        count += item;
                }
                else
                    count += item;
            }
            Console.WriteLine(count);
        }

        //58_ Write a C# Sharp program to check two given integers and return the value whichever
        //value is nearest to 13 without going over. Return 0 if both numbers go over.
        public static void CheckTwoValues2(double v1,double v2)
        {
            if (v1 > 13 || v2 > 13)
                Console.WriteLine("0");
            else
            {
                if (Math.Abs(v1 - 13) > Math.Abs(v2 - 13))
                    Console.WriteLine(v2);
                else
                    Console.WriteLine(v1);
            }
        }

        //59_Write a C# Sharp program to check three given integers (small, medium and large)
        //and return true if the difference between small and medium and the difference between
        //medium and large is same.
        public static void CheckThreeValues(int v1,int v2,int v3)
        {
            Console.WriteLine(Math.Abs(v1 - v2) == Math.Abs(v2 - v3));
        }

        //60_ Write a C# Sharp program to create a new string using two given strings s1, s2,
        //the format of the new string will be s1s2s2s1.
        public static void CreateNewSringFromeGivenString(string s1,string s2)
        {
            Console.WriteLine(s1 + s2 + s2 + s1);
        }

        //61_Write a C# Sharp program to insert a given string into middle of the another given
        //string of length 4.
        public static void InsertStringIntoAndotherString(string s1,string s2)
        {
            Console.WriteLine(s1.Substring(0, s1.Length / 2) + s2 + s1.Substring(s1.Length / 2));
        }

        //62_Write a C# Sharp program to create a new string using three copies of the last two
        //character of a given string of length atleast two.
        public static void CreateNewStringUsingThreeCopiesOfLastChar(string s1)
        {
            Console.WriteLine(s1.Substring(s1.Length - 2) + s1.Substring(s1.Length - 2) + s1.Substring(s1.Length - 2));
        }

        //63_Write a C# Sharp program to create a new string using first two characters of a 
        //given string. If the string length is less than 2 then return the original string.
        public static void CreateNewString(string s1)
        {
            if (s1.Length < 2)
                Console.WriteLine(s1);
            else
                Console.WriteLine(s1.Substring(0, 2));
        }

        //64_Write a C# Sharp program to create a new string of the first half of a given string 
        //of even length.
        public static void CreateNewString2(string s1)
        {
            Console.WriteLine(s1.Substring(0, s1.Length / 2));
        }

        //65_Write a C# Sharp program to create a new string without the first and last character 
        //of a given string of length atleast two.
        public static void CreateNewString3(string s1)
        {
            Console.WriteLine(s1.Substring(1, s1.Length - 2));
        }

        //66_Write a C# Sharp program to create a new string from two given string one is shorter
        //and another is longer. The format of the new string will be long string + short string
        //+ long string.
        public static void CrateNewString4(string s1 ,string s2)
        {
            if (s1.Length > s2.Length)
                Console.WriteLine(s1 + s2 + s1);
            else if (s2.Length > s1.Length)
                Console.WriteLine(s2 + s1 + s2);
        }

        //67_Write a C# Sharp program to concat two given string of length atleast 1, after 
        //removing their first character.
        public static void CreateNewStringRemoveFirstChar(string s1 , string s2)
        {
            Console.WriteLine(s1.Substring(1) + s2.Substring(1));
        }

        //68_


    }
}
