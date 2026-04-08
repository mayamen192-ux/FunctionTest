using System;
using System.Globalization;
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
                    case 5:
                        break;
                    case 6:
                        break;

                        case 7: // Temperature Converter
                        
                        break;
                    case 8:
                        break;
                    case 9:
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
