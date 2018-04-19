using System;
using System.Text.RegularExpressions;

namespace PasswordRecovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор символов>");
            string inputLine = Console.ReadLine();

            Algorithms permAlgorithm = new Algorithms();
            permAlgorithm.InputSet = permAlgorithm.MakeCharArray(inputLine);

            permAlgorithm.Recursion(0);
            Console.WriteLine("# всего вариантов: " + permAlgorithm.PermutationCount);

            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
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
