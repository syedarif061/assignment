using localcinema;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

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

                Console.WriteLine("Welcome To the Cinema");
                Console.WriteLine("please selece the options");
                Console.WriteLine("     1. To buy a ticket for 1 person.");
                Console.WriteLine("     2. For group of people (No. of people & tickets with total cost) .");
                Console.WriteLine("     3. user input and repeat.");
                Console.WriteLine("     4. break the sentence.");
                Console.WriteLine("     Q. Quit.");

               
                switch (Console.ReadLine())
                {   
                    case "1":
                        oneticket();
                        break;
                    case "2":
                        grouptickets();
                        break;
                    case "3":
                        user();
                        break;
                    case "4":
                        sentence();
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

            
            private static void oneticket()
            {

            
                Console.Write("1. Enter age: ");

            //int age;
            //string input = Console.ReadLine();
            //age = int.Parse(input);
            int age = Convert.ToInt32(Console.ReadLine());
            

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

        private static void sentence()
        
        {
            Console.WriteLine("Write the sentence and i will show the last word for you. ");
            string input; 
            input = Console.ReadLine();
            var a = input.Split();
            Console.WriteLine(a[a.Length - 1]);


            Print();
        }

            


        private static void user()

        {
           
            {
                Console.WriteLine("Enter what you want to print!");
                string userPrint = Console.ReadLine();

                Console.WriteLine("Enter the number of times you want to print: ");
                int number = int.Parse(Console.ReadLine());

                while (number > 0)
                {
                    Console.WriteLine(userPrint);
                    number--;
                }

                Console.ReadLine();
                Print();
            }

        }


        private static void grouptickets()
        {
            
            
           
            
           //int persons;
            int price1 = 0;
            int price2= 0;
            int price3= 0;
            //int total_price;
            //persons = 1, 
            int total_price = 0;
            int i=0;

            Console.Write("How many tickets do you want? ");
           
            //string input = Console.ReadLine();
            //tickets = int.Parse(input);
            int t = Convert.ToInt32(Console.ReadLine());


            
            do
            {
                Console.Write("Enter age for person ");
                //int age;
                //string input1 = Console.ReadLine();
                //age = int.Parse(input1);
                
                
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("", i);

                
                    if (age > 64)
                    
                        price1 += 90;
                   
                    

                     if (age < 20)
                    
                        price2 += 80;
                   
                    

                      if (age >= 20 && age <= 65)
                    
                        price3 += 120;
                
                    

                else 
                    Console.WriteLine("wrong result");

                    i++;
             }

                while (i < t) ;
                total_price = price1 + price2 + price3;
            Console.WriteLine( "Total ticket");
            Console.WriteLine(t);
            Console.WriteLine("total price");
            Console.WriteLine(total_price);

                Print();

               




              }

        }   


    }






    
    
