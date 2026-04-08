using System;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FunctionTest
{
    internal class Program
    {
        // Display Menu Function
        public static void displayMenue()
        {
            Console.WriteLine("Functions Menu: ");
            Console.WriteLine("...............");
            Console.WriteLine("1. Today's Greeting:");
            Console.WriteLine("2.Star Border");
            Console.WriteLine("3.Random Motivational Quote");
            Console.WriteLine("4. Personalised Invoice Header:");
            Console.WriteLine("5. Number Pattern Printer");
            Console.WriteLine("6. Word Frequency Analyser");
            Console.WriteLine("7. Temperature Converter:");
            Console.WriteLine("8.Password Strength Checker");
            Console.WriteLine("9.Simple Statistics Calculator");
            Console.WriteLine("10.Session Timer:");
            Console.WriteLine("11.Magic Number Generator");
            Console.WriteLine("12.Inspirational Day Message");
            Console.WriteLine("13. Flexible Discount Calculator:");
            Console.WriteLine("14.Configurable Report Header");
            Console.WriteLine("15. Smart Product Search");
            Console.WriteLine("16.Exit:");
            Console.Write("Choose option: ");
        }

        // Today's Greeting Function
        public static void PrintDailyGreeting()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Good morning, Trainee!");
            Console.WriteLine("Date: " + now.ToString("dd/MM/yyyy"));
            Console.WriteLine("Time: " + now.ToString("hh:mm tt"));
            Console.WriteLine("Let's code something great today!");
        }

        // Personalised Invoice Header Function
        public static void PrintInvoiceHeader(string customerName, string invoiceDate)
        {




            Console.WriteLine("========================================");
            Console.WriteLine("INVOICE");
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            customerName = textInfo.ToTitleCase(customerName.ToLower());
            Console.WriteLine("Customer : " + customerName);
            Console.WriteLine("Date : " + invoiceDate);
            Console.WriteLine("========================================");
        }


        public static void PrintStarBorder()
        {
            // Print a top row of 40 stars
            for (int i = 0; i < 40; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // Print the text " Welcome to C# Functions!" on the next line
            Console.WriteLine(" Welcome to C# Functions!");

            //  Print a bottom row of 40 stars
            for (int i = 0; i < 40; i++)
            {
                Console.Write("*"); // FIX: use Write instead of WriteLine
            }
            Console.WriteLine();
        }

        public static void PrintRandomQuote()
        {
            string[] quotes = new string[]
            {
        "Code is like humor. When you have to explain it, it's bad."
            };

            Random rand = new Random();
            //pick a random quote from an array
            int index = rand.Next(0, quotes.Length);

            // print a quote surrounded by dashes
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\"" + quotes[index] + "\"");
            Console.WriteLine("----------------------------------------");
        }
        public static void PrintNumberPattern(int rows)
        {
            // right-aligned triangle of numbers
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            // If rows is less than 1, print "Invalid input. Rows must be at least 1."
            if (rows < 1)
            {
                Console.WriteLine("Invalid input. Rows must be at least 1.");
                return;
            }
        }

        public static void PrintWordStats(string sentence)
        {
            //checking for empty or whitespace input
            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Sentence is empty. Please provide valid input.");
                return;
            }
            //Split sentence into words
            string[] words = sentence.Split(' ');
            //total number of words in the sentence
            int wordCount = words.Length;

            string longest = words[0];
            string shortest = words[0];

            // loop for checking each word in the sentence to know the sortest and longest word 
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }

                if (word.Length < shortest.Length)
                {
                    shortest = word;
                }
            }
            // all words reversed in order
            Array.Reverse(words);
            string reversedSentence = string.Join(" ", words);
            Console.WriteLine("Total words: " + wordCount);
            Console.WriteLine("Longest word: " + longest);
            Console.WriteLine("Shortest word: " + shortest);
            Console.WriteLine("Reversed sentence: " + reversedSentence);
        }


        public static string GetPasswordStrength(string password)
        {
            int score = 0;
            //Length is 8 or more characters
            if (password.Length >= 8)
                score++;
            // Contains at least one uppercase letter
            if (Regex.IsMatch(password, "[A-Z]"))
                score++;
            //Contains at least one digit
            if (Regex.IsMatch(password, "[0-9]"))
                score++;
            //Contains at least one special character from: ! @ # $ % ^ & *
            if (Regex.IsMatch(password, "[!@#$%^&*]"))
                score++;
            //Rating: 0–1 points → Weak | 2–3 points → Moderate | 4 points → Strong
            if (score <= 1)
                return "Weak";
            else if (score <= 3)
                return "Moderate";
            else
                return "Strong";
        }



        public static string CalculateStats(int[] numbers)
        {
            //check if the array is null or empty
            if (numbers == null || numbers.Length == 0)
            {
                return "No data provided.";
            }

            int min = numbers.Min();
            int max = numbers.Max();
            int sum = numbers.Sum();
            double average = Math.Round(numbers.Average(), 2);


            //Whether the array is sorted in ascending order (Yes / No)
            bool isAscending = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isAscending = false;
                    break;
                }
            }
            //Whether the array is sorted in ascending order (Yes / No)
            string text = isAscending ? "Yes" : "No";

            string summary = "Minemum is " + min + " , Maximum is:" + max + ", sum is: " + sum + ", average is: " + average + ", Sorted Ascending:" + text;
            return summary;
        }

static void Main(string[] args)
            {
                // Show menu first
                displayMenue();

                // Read choice safely
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1: // Today's Greeting
                            PrintDailyGreeting();
                            break;
                    case 2:// Print Star Border
                            PrintStarBorder();
                        break;
                    case 3://Print Random Quote
                        PrintRandomQuote();
                        break;
                        case 4: // Personalised Invoice Header
                                // Example calls
                        Console.WriteLine("Enter Cutomer Name:");
                        string customerName = Console.ReadLine();
                        Console.WriteLine("Enter Date:");
                        string invoiceDate = Console.ReadLine();
                        

                        PrintInvoiceHeader(customerName, invoiceDate);
                      

                        break;
                    case 5://PrintNumberPattern
                        Console.WriteLine("Enter a number of rows:");
                        int numberOfRows=int.Parse(Console.ReadLine());
                        PrintNumberPattern(numberOfRows);
                        break;
                    case 6://Print Word Stats
                        Console.WriteLine("Enter  a sentence:");
                        string sentenceInput= Console.ReadLine();
                        PrintWordStats(sentenceInput);

                        break;

                        case 7: // Temperature Converter
                        
                        break;
                    case 8://GetPasswordStrength
                        string[] testPasswords = {
                         "abc123",       // Weak
                         "Password1",    // Moderate
                          "Pass1!",       // Moderate
                           "Str0ng@Pwd!"   // Strong
                                          };
                        foreach (string pwd in testPasswords)
                        {
                            string strength = GetPasswordStrength(pwd);
                        }
                        Console.WriteLine("Enter a password to test:");
                        string passwordInput = Console.ReadLine();
                        Console.WriteLine("Password: " + passwordInput + "  Strength: " + GetPasswordStrength(passwordInput));
                        break;
                    case 9://Calculate Stats
                        int[] array1 = { 3, 20, 15, 40, 12 };
                        int[] array2 = { 2, 6, 12, 32, 64 };
                        int[] array3 = { };

                        Console.WriteLine("summary of arrary 1:" + CalculateStats(array1));
                        Console.WriteLine("summary of arrary 2:" + CalculateStats(array2));
                        Console.WriteLine("summary of arrary 3:" + CalculateStats(array3));
                        break;
                    case 10://Session Timer
                       
                        break;
                    case 11:
                        break;
                    case 12:
                        break;

                    case 13:// Flexible Discount Calculator
                         
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
