using System;
using System.Text.RegularExpressions;

namespace PasswordRecovery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Введите набор символов>");
            string inputLine = Console.ReadLine();

            Algorithms permAlgorithm = new Algorithms();
            permAlgorithm.InputSet = permAlgorithm.MakeCharArray(inputLine);

            permAlgorithm.Recursion(0);
            Console.WriteLine("# всего вариантов: " + permAlgorithm.PermutationCount);

            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();*/
            string one = "12.08.1998";
            string one1 = "45.08.1998";
            string one2 = "sdfgsdt";
            string one3 = "...";
            string one4 = "00.00.0000";
            string one5 = "10.20.1998";
            Console.WriteLine(IsDateContains(one));
            Console.WriteLine(IsDateContains(one1));
            Console.WriteLine(IsDateContains(one2));
            Console.WriteLine(IsDateContains(one3));
            Console.WriteLine(IsDateContains(one4));
            Console.WriteLine(IsDateContains(one5));
            Console.ReadLine();
            bool IsDateContains(string input)
            {
                Regex regex = new Regex(@"^(((0[1-9]|[12]\d|3[01])\.(0[13578]|1[02])\.((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\.(0[13456789]|1[012])\.((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\.02\.((19|[2-9]\d)\d{2}))|(29\.02\.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$");
                Match match = regex.Match(input);
                if (match.Success)
                {
                    return true;
                }
                else return false;
            }
        }
    }

    class Algorithms
    {
        private int elementLevel = -1;
        private int numberOfElements;
        private int[] permutationValue = new int[0];

        public char[] InputSet { get; set; }

        public int PermutationCount { get; set; } = 0;

        public char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;
            return charString;
        }

        public void Recursion(int k)
        {
            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                OutputPermutation(permutationValue);
            }
            else
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                    {
                        Recursion(i);
                    }
                }
            }
            elementLevel--;
            permutationValue.SetValue(0, k);
        }

        private void OutputPermutation(int[] value)
        {
            foreach (int i in value)
            {
                Console.Write(InputSet.GetValue(i - 1));
            }
            Console.WriteLine();
            PermutationCount++;
        }
    }
}
