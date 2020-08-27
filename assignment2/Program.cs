using localcinema;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace localcinema
{
    class Program
    {

        static void Main(string[] args)
        {
            Print();
        }

            //Console.WriteLine("Add a new Customer and age");

            private static void Print()
            {


                Console.WriteLine("     1. Main Menu.");
                Console.WriteLine("     2. Menu.");
                Console.WriteLine("     Q. Quit.");

               
                switch (Console.ReadLine())
                {
                    case "1":
                        Mainmenu();
                        break;
                    case "2":
                        Print();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }


            private static void Mainmenu()
            {

            
                Console.Write("1. Enter age: ");

                int age;
                string input = Console.ReadLine();
                age = int.Parse(input);
                 if (age < 20)
                {
                    Console.WriteLine("you are young and the youth price:SEK 80");
                    Print();
                }
                if (age > 64)
                {
                    Console.WriteLine("You are pensionar and retirement price:SEK 90 ");
                    Print();
                }
                else
                {
                    Console.WriteLine("You are Adult and standard price:SEK 120");
                    Print();
                }

            


        }



    }
    }
