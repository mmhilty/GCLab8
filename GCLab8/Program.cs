using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool killswitch = true;
            while (killswitch)
            {
                string[,] studentArray = new string[15, 5] {
                {"1", "Nana", "Banahene", "Ghana" , "Empanadas" },
                {"2", "Tim", "Broughton", "Detroit" , "Chicken Parm" },
                {"3", "Lin-Z", "Chang", "Toledo" , "Ice Cream" },
                {"4", "Taylor", "Everts", "Caro" , "Cordon Bleu" },
                {"5", "Michael", "Hern", "Canton" , "Chicken Wings" },
                {"6", "Madelyn", "Hilty", "Oxford" , "Croissants" },
                {"7", "Jordan", "Owiesny", "Warren" , "Burgers" },
                {"8", "Shah", "Shahid", "Newark" , "Chicken Wings" },
                {"9", "Blake", "Shaw", "Los Angeles" , "Cannoli" },
                {"10", "Jon", "Shaw", "Huntington Woods" , "Ribs" },
                {"11", "Jay", "Stiles", "Macomb" , "Pickles" },
                {"12", "Rochelle", "Toles", "Mars" , "Space Cheese" },
                {"13", "Bob", "Valentic", "St Clair Shores" , "Pizza" },
                {"14", "Abby", "Wessels", "Traverse City" , "Soup" },
                {"15", "Joshua", "Zimmerman", "Taylor" , "Turkey" }  };

                //Reference Section
                Console.WriteLine(@"Welcome to our C# class! Which student would you like to learn more about?
(Helpful Hint: You must pick a student from the list below to continue)
");

                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine($"Student {i + 1} : {studentArray[i, 1]} {studentArray[i, 2]}");
                }

                int studentSelection = SearchLoop(true, studentArray);
                if (studentSelection == -1)
                {
                    Console.WriteLine("Returned -1. Figure out why.");
                    Console.ReadLine(); // PAUSE
                }




                bool switchLoop = true;
                while (switchLoop)
                {
                    Console.WriteLine("Good choice! What would you like to know about them?");
                    Console.WriteLine(@"1: Hometown
2: Favorite Food
(Helpful Hint: You must pick a valid option to continue)
");
                    string infoInput = Console.ReadLine();
                    switch (infoInput.ToUpper())
                    {
                        case "1":
                        case "HOME":
                        case "HOMETOWN":
                            Console.WriteLine($"{studentArray[studentSelection, 1]}'s hometown is {studentArray[studentSelection, 3]}.");
                            switchLoop = false;
                            break;

                        case "2":
                        case "FOOD":
                        case "FAVORITE":
                        case "FAVORITE FOOD":
                            Console.WriteLine($"{studentArray[studentSelection, 1]}'s favorite food is {studentArray[studentSelection, 4]}.");
                            switchLoop = false;
                            break;

                        default:
                            Console.WriteLine("That selection doesn't do anything");
                            break;


                    }
                }

                killswitch = ContinueLoop("Would you like to know more?");

            }
            //}

            // the array
            // WriteLine list out students, numbers and fields

            // userinput student
            // userinput field

            // have input refer to the index

            // print out the answer

            // continue loop

        }

        public static int SearchLoop(bool search, string[,] studentArray) //////find the code path that doesn't return a value and squish it
        {
            
                while (search)  
                {
                    string userInput = Console.ReadLine();

                    for (int i = 0; i < studentArray.GetLength(0); i++)
                    {

                        for (int j = 0; j < studentArray.GetLength(1); j++) /// REGULAR
                        {
                        //if (!studentArray[i, j].Equals(userInput))
                        //{
                        //    Console.WriteLine("That's not a valid selection. Try again.");
                        //    search = false;
                        //}

                        if (studentArray[i, j].Equals(userInput))
                        {
                            int studentSelection = Convert.ToInt32(studentArray[i, 0]);
                            Console.WriteLine($"You selected {studentArray[i, 1]} {studentArray[i, 2]} ");
                            return studentSelection-1; //subtract one to handle 0 based indexing

                        }
                        

                        }
                    }
                }
            return -1;  
        }

        

        static bool ContinueLoop(string prompt)
        {
            while (true)
            {
                bool userContinue;
                Console.WriteLine(prompt);
                Console.WriteLine("Y/N?");
                string userContinueInput = Console.ReadLine();

                if (userContinueInput.ToLower() == "y")
                {
                    userContinue = true;
                }

                else if (userContinueInput.ToLower() == "n")
                {
                    userContinue = false;
                }

                else
                {
                    Console.WriteLine("I'm not sure what you mean.");
                    continue;
                }


                return userContinue;
            }
        }


        //static void searchLoop([], out studentSelection)
        //{
        //    //Search Loop to Select Student
        //    bool searchLoop = true;
        //    while (searchLoop)
        //    {
        //        string userInput = Console.ReadLine();
        //        int studentSelection;
        //        for (int i = 0; i < studentArray.GetLength(0); i++)
        //        {

        //            for (int j = 0; j < studentArray.GetLength(1); j++) /// REGULAR
        //            {
        //                if (studentArray[i, j].Equals(userInput))
        //                {
        //                    studentSelection = Convert.ToInt32(studentArray[i, 0]);
        //                    Console.WriteLine($"You selected {studentArray[i, 1]} {studentArray[i, 2]} ");
        //                    Console.ReadLine();
        //                    searchLoop = false;
        //                }
        //            }
        //        }
        //    }
    }


}

