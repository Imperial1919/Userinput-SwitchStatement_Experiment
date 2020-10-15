using System;

namespace Userinput_SwitchStatement_Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, how old are You?");

            string age = Console.ReadLine();

            if (age == "I don't know" || age == "What")
            {
                Console.WriteLine("IMBECILE!, surely You know Your age, now get to typing!");

            }



            else if (Int32.Parse(age) <= 5)
            {

                switch (Int32.Parse(age))
                {
                    case 1:
                        Console.WriteLine("You are Literally a Newborn");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("You are still a infant, tell me, Can you walk yet?");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Awh, Can You talk yet?");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("I think You should be going to Preschool soon.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("You are now entering the hell-.. playground, that is public education, prepare Yourself.");
                        Console.ReadKey();
                        break;

                }
            }



            else if (Int32.Parse(age) <= 12)
            {

                switch (Int32.Parse(age))
                {
                    case 6:
                        Console.WriteLine("Dealing with any Playground Bullies yet? If so, DEAL WITH IT YA SCRUB.");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("I think You should be entering the second grade around this point");
                        break;
                    case 8:
                        Console.WriteLine("Let me guess, You are in the third grade?.. ");
                        break;

                    case 9:
                        Console.WriteLine("This is the last time Your age will be a single digit. Go to sleep with that fact tonight.");
                        break;
                    case 10:
                        Console.WriteLine("Welcome to the realm of binary digit age, better get used to it. ");
                        break;

                    case 11:
                        Console.WriteLine("You should be in the sixth grade in public school by this point, You're about to enter middle school, Just remember.. Middle School WILL be cringe.");
                        break;

                    case 12:
                        Console.WriteLine("Welcome to Hell- Middle school youngster! This is also the last year you can be called a 'Child' Technically speaking!");
                        break;



                }



            }

            else if (Int32.Parse(age) > 12 && Int32.Parse(age) <= 18)
            {
                switch (Int32.Parse(age))
                {

                
                case 13:
                    Console.WriteLine("Oh lord, You have hit puberty, you are in the middle of middle school AND your voice is probably cracking, god help you.");
                    break;
                }
            }




            else
            {
                Console.WriteLine("ERROR!");
                Console.ReadKey();
            }

            }
        }
        

            

        
        }

