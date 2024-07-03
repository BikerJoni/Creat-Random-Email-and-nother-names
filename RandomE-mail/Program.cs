using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using Tynamix.ObjectFiller;

namespace newProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {

                Console.WriteLine("What do you want creat : 1 - Random Email, 2 - Random Country name, 3 - Random Name, 4- Lorem Ipsum");
                int userChoise;
                userChoise = int.Parse(Console.ReadLine());

                Console.WriteLine("How many random names do you want ?");
                int howManyTimes;
                howManyTimes = int.Parse(Console.ReadLine());

                if (userChoise is 1)
                {
                    GenerateEmailAddress(howManyTimes);
                }
                else if (userChoise is 2)
                {
                    CreateCountryName(howManyTimes);
                }
                else if (userChoise is 3)
                {
                    CreateRandomNames(howManyTimes);
                }
                else if (userChoise is 4)
                {
                    Console.WriteLine("How many words of text do you need?");
                    Console.WriteLine("Enter the number of words: ");
                    string userInputLipsum = Console.ReadLine();
                    int userInputLipsumValue = Convert.ToInt32(userInputLipsum);
                    GenerateLoremIpsum(count: howManyTimes, numberOfWords: userInputLipsumValue);
                }

                Console.WriteLine("do you want to repead one more time ? (if yes press + , or any bottom to exit )");
                userInput = Console.ReadLine();

            }
            while (userInput is "+");
        }

        static void CreateRandomNames(int counter)
        {

            RealNames realNames = new RealNames();

            for (int i = 0; i < counter; i++)
            {
                string realName = realNames.GetValue();
                Console.WriteLine(realName);
            }
        }

        static void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
            }
        }
        static void CreateCountryName(int count)
        {
            CountryName countryNameGenerator = new CountryName();
            for (int i = 0; i < count; i++)
            {
                string countryName = countryNameGenerator.GetValue();
                Console.WriteLine(countryName);
            }
        }
        static void GenerateLoremIpsum(int count, int numberOfWords)
        {
            Lipsum lipsumGenerator = new Lipsum(LipsumFlavor.LoremIpsum, minWords: numberOfWords);

            for (int i = 0; i < count; i++)
            {
                string lipsumRandom = lipsumGenerator.GetValue();
                Console.WriteLine(lipsumRandom);
            }

        }
    }
}
