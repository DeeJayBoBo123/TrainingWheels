using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BasicerShite
{

    internal class Program
    {

        public static void Main()
        {
            bool loopBreak = true;
            while (loopBreak = true)
            {
                Learn();
                Console.Write("Keep going? (yes/no)");
                var yn = Console.ReadKey().KeyChar;
                if (yn == 'y')
                {
                    loopBreak = true;
                    Console.WriteLine("");
                }
                else if (yn == 'n')
                    break; //end the while loop
                else
                    Console.WriteLine("Wrong input, try again");
                    loopBreak = true;
            }   
            
        }
        public static void Learn()
        {
        choice:
            Console.Write("Choose option (number):");
            string entry = Console.ReadLine();
            if (int.TryParse(entry, out int _))
            {
                int key = Convert.ToInt32(entry);


                switch (key)
                {
                    case 1:

                        string characterName = "Tom"; //declaring and assigning a variable. String = text, Int = integer (whole number)
                        int characterAge; //declaring a variable
                        characterAge = 25; //assigning variable a value

                        Console.WriteLine("There once was a man named " + characterName);
                        Console.WriteLine("He was " + characterAge + " years old");

                        characterName = "Mike"; //changing variable value

                        Console.WriteLine("He really liked the name " + characterName);
                        Console.WriteLine("But didn't like being " + characterAge);

                        break;

                    case 2:

                        string phrase = "Basic learning";
                        char character = 'A';
                        int wholeNumber = 100;
                        double unwholeNumber = 3.2; //float and decimal are other unwhole number data types
                        bool yesNo = false; //or true

                        Console.WriteLine(false);
                        break;
                    case 3:


                        break;

                    default:
                        Console.WriteLine("Wrong input, try again");
                        goto choice;
                        
                }
            }

            else
            { 
            Console.WriteLine("Learn how to read, try again");
            goto choice;
            
            }

                 

        }
    }

}



