using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {


        
        static void Main(string[] args)
        {
            //this comments a single line
            /*this is for multiple lines*/
            //the shortcut visual studio standard toolbar

            //Part 1 Greetings
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            //Part 2 Attributes of Spartacus
            /*Console.WriteLine(messageOne);
            Console.WriteLine(messageTwo);
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.028461f;
            float weightTwo = 331.1234567f;
            bool isGodLikeOne = true;
            bool isGodlikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            //Part 3 Display of variable values
            Console.WriteLine(messageOne);//Displays initial greeting to console
            Console.WriteLine(messageTwo);

            //Part 4 Mathematical operator, bool, and char examples
            Console.WriteLine(ageOne + ageTwo);//Addition example
            Console.WriteLine(heightOne - heightTwo);//Subtraction example
            Console.WriteLine(weightOne * weightTwo);//Multiplication example
            Console.WriteLine(isGodLikeOne);//Bool example
            Console.WriteLine(genderMale);//Char example

            //Part 5 Variable Reassignment
            ageTwo = 70;
            heightTwo = 35.12345f;
            weightTwo = 1429.1234573f;

            //Part 6 Mathematical operator examples
            Console.WriteLine(ageOne + ageTwo);
            Console.WriteLine(heightOne - heightTwo);
            Console.WriteLine(weightOne * weightTwo);
            Console.WriteLine(ageTwo / ageOne);
            Console.WriteLine(ageTwo % ageOne);
            Console.WriteLine(ageThree / ageOne);
            Console.WriteLine(ageThree % ageOne);

            //Part 7 Increment and decrement operator examples
            ageTwo = ageTwo + 1;
            Console.WriteLine(ageTwo);
            ageTwo++;
            Console.WriteLine(ageTwo);
            ageTwo--;
            Console.WriteLine(ageTwo);

            //Part 8 Concatenation example
            Console.WriteLine(messageOne + " " + messageTwo + ".");
            Console.WriteLine("I am " + ageOne + " years old, and it is " + isGodLikeOne + " that I am godlike.");
            Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            Console.WriteLine("My father is {0} years old, and it is {1} that he is a god.", ageThree, isGodLikeOne);
            Console.WriteLine("I am {0} years old, and it is {1} that I am godlike.", ageOne, isGodLikeOne);
            Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            //Part 9 String equality examples
            Console.WriteLine(messageTwo.Equals(messageOne));
            Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //Part 10 String length examples
            int messOneLength = messageOne.Length;
            int messTwoLength = messageTwo.Length;

            Console.WriteLine("The length of messageOne is " + messageOne.Length);
            Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            Console.WriteLine("The length of messageOne is " + messOneLength);
            Console.WriteLine("The length of messageTwo is " + messTwoLength);
            Console.Write(messageOne.Length + messageTwo.Length + ("\n"));

            //Part 11 Conditional exqamples
            string cityOne = "Vesuvius";
            string cityTwo = "Nola";
            string cityThree = "Nuceria";
            int cityOneDistance, cityTwoDistance, cityThreeDistance;

            //Solicit user input
            Console.WriteLine("What is the distance to {0}", cityOne);
            cityOneDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the distance to " + cityTwo + "?");
            cityTwoDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the distance to Nuceria?");
            cityThreeDistance = int.Parse(Console.ReadLine());

            if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
            {
                Console.WriteLine("We will march to {0}", cityOne);
            }
            if ((cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
            {
                Console.WriteLine("We will march to " + cityTwo);
            }
            if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
            {
                Console.WriteLine("We will march to {0}", cityThree);
            }

            Console.WriteLine("What is your rank?");
            string rank = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if ((rank == "officer") || (age <= 26))
            {
                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            }
            else
            {
                Console.WriteLine("Sorry, you are staying home.");
            }

            Console.WriteLine("What is your rank soldier?");
            string rank = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age soldier?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your job soldier?");
            string job = Console.ReadLine().ToLower();

            if ((rank == "officer") || (age <= 26))
            {
                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            }
            else if ((job == "cook") && (age >= 26))
            {
                Console.WriteLine("My army has to eat. Pack your pots and pans.");
            }
            else
            {
                Console.WriteLine("Sorry, you are staying home.");
            }

            switch (job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword.");
                    break;

                case "archer":
                    Console.WriteLine("You will carry a bow and arrow.");
                    break;

                case "supply":
                    Console.WriteLine("You will carry pots and pans.");
                    break;

                case "specialist":
                    Console.WriteLine("You will operate the catapult.");
                    break;

                default:
                    Console.WriteLine("You will ride horseback.");
                    break;
             }

            //Part 12 array examples
            string[] foodList = new string[5];
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);*/

            int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " + foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);


            string[] elements = messageTwo.Split(' '); //Splits a string into multiple strings
            Console.WriteLine(elements[0]); //prints "I"
            Console.WriteLine(elements[1]); //prints "am"
            Console.WriteLine(elements[2]); //prints "Spartacus"


            string myName = "Sue"; 
            char[] letters = myName.ToCharArray(); //Splits a value into it's characters
            Console.WriteLine("The first letter of my name is" + letters[0]);

            Console.WriteLine(myName.IndexOf('S')); //prints "0"
            Console.WriteLine("foo".IndexOf('o')); //prints 1
            Console.WriteLine("fee, fie, fo, fum".IndexOf("foe")); //prints 10


            List<string> foodList = new List<string>();
            foodList.Add("Milk");
            foodList.Add("Fruit");
            foodList.Add("Meat");
            foodList.Add("Wine");
            foodList.Add("Bread");

            foodList.Add("Bepis");
            Console.WriteLine("{0}, {1}, {2}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            foodList.Remove("Bepis");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);
            foodList.Insert(1, "Bepis");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            foodList.RemoveAt(1);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

        }

    }
}
