using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev
{
    class Odev1
    {
        static void Main()
        {
            ArrayList takenNumbers = new ArrayList(20);
            bool check = false;
            int a = 0;
            // Creating a while loop for control the code.
            while (a < 1)
            {
                // Taking from users 20 numbers and assigning them to ArrayList.
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Please enter " + (i + 1) + ". number.");
                    takenNumbers.Add(Console.ReadLine());
                    check = CheckValue(Convert.ToString(takenNumbers[i]));
                    // If user enter a non-numeric or negative numeric numbers, this condition break the loop and return to user a warning statement.
                    if (!check)
                    {
                        Console.WriteLine("Please enter only positive numeric values.");
                        break;
                    }
                }

                if (!check)
                    break;

                ArrayList primeList = new ArrayList();
                ArrayList nonPrimeList = new ArrayList();

                // Creating a loop which check numbers if it is a prime or not and assing them to their own lists.
                foreach (string i in takenNumbers)
                    if (IsPrime(int.Parse(i)))
                        primeList.Add(int.Parse(i));
                    else
                        nonPrimeList.Add(int.Parse(i));

                // Sorting lists.
                primeList.Sort();
                nonPrimeList.Sort();

                // The outputs which give to user reversing versions of lists.
                Console.WriteLine("Prime numbers from biggest to smallest: ");
                primeList.Reverse();
                foreach (int i in primeList)
                    Console.WriteLine(i);

                Console.WriteLine("Non-prime numbers from biggest to smallest: ");
                nonPrimeList.Reverse();
                foreach (int i in nonPrimeList)
                    Console.WriteLine(i);

                // The outputs which give to user their avarage and number of elements
                Console.WriteLine("Number of prime numbers: ");
                Console.WriteLine(primeList.Count);

                int total = 0;
                foreach (int i in primeList)
                    total += i;
                Console.WriteLine("Avarage of prime numbers: " + total / primeList.Count);

                Console.WriteLine("Number of non-prime numbers: ");
                Console.WriteLine(nonPrimeList.Count);

                total = 0;
                foreach (int i in nonPrimeList)
                    total += i;
                Console.WriteLine("Avarage of non-prime numbers: " + total / nonPrimeList.Count);

                a++;
            }
        }

        // The Method which check the value if it is positive numeric number or not.
        static bool CheckValue(string s)
        {
            bool result = int.TryParse(s, out int i);
            if (result == false)
                return false;
            else if (Convert.ToInt32(s) <= 0)
                return false;
            return true;
        }

        // The Method which check the number if it is a prime number or not.
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundry = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundry; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }

    class Odev2
    {
        static void Main2()
        {

            int a = 0;
            string value = "";
            int[] arr = new int[20];
            int[] arrGreatest = new int[3];
            int[] arrLowest = new int[3];
            bool check = false;

            // Creating a loop which control the code.
            while (a < 1)
            {
                // Taking 20 numbers from the user.
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Please enter " + (i + 1) + ". number.");
                    value = Console.ReadLine();

                    // Checking the given input if it is a numeric value or not.
                    check = CheckValue(value);
                    if (!check)
                    {
                        Console.WriteLine("Please enter only numeric values.");
                        break;
                    }
                    else
                        arr[i] = int.Parse(value);
                }

                if (!check)
                    break;

                // Sorting the list for finding greatest and lowest values.
                Array.Sort(arr);

                // Divided greatest and lowets values to different arrays.
                for (int i = 0; i < arrLowest.Length; i++)
                    arrLowest[i] = arr[i];

                for (int i = 0; i < arrGreatest.Length; i++)
                {
                    Array.Reverse(arr);
                    arrGreatest[i] = arr[i];
                }


                // Finding their avarage value.
                Console.WriteLine("Avarage of lowest 3 values: " + FindAvarage(arrLowest));
                Console.WriteLine("Avarage of greatest 3 values: " + FindAvarage(arrGreatest));
                Console.WriteLine("Sum of avarages: " + (FindAvarage(arrLowest) + FindAvarage(arrGreatest)));

            }
        }

        // The Method which check the value if it is a numeric value or not.
        static bool CheckValue(string s)
        {
            bool result = int.TryParse(s, out int i);
            if (result == false)
                return false;

            return true;
        }

        // The Method which find an array's avarage value.
        static int FindAvarage(int[] i)
        {
            int total = 0;
            foreach (int number in i)
                total += number;
            return total / i.Length;
        }
    }
    class Odev3
    {
        static void Main3()
        {
            int a = 0;
            List<char> vowels = new List<char>();
            string sentence = "";

            // Creating a loop which control the code.
            while (a < 1)
            {
                // Taking from user a sentence.
                Console.WriteLine("Please enter a sentence: ");
                sentence = Console.ReadLine();

                // Checking the value if it is full of letters or not.
                bool check = CheckSentence(sentence);
                if (!check)
                {
                    Console.WriteLine("Please enter only letters.");
                    break;
                }

                // Finding vowels and put together in a List.
                for (int i = 0; i < sentence.Length; i++)
                {
                    if ((sentence[i] == 'a') || (sentence[i] == 'e') || (sentence[i] == 'ı') || (sentence[i] == 'i') || (sentence[i] == 'o') || (sentence[i] == 'ö') || (sentence[i] == 'u') || (sentence[i] == 'ü'))
                        vowels.Add(sentence[i]);                        
                }

                // Output of vowels.
                Console.WriteLine("Vowels in your sentence: ");
                vowels.ForEach(letter => Console.Write(letter));

                a++;
            }
        }

        // The Method which checking the sentence if it is full of letters or not.
        static bool CheckSentence(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                else if (!Char.IsLetter(s[i]))
                return false;
            }
            return true;
        }
    }
}

