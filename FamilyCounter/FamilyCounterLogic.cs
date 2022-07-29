
namespace FamilyCounter
{
    public static class FamilyCounterLogic
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome To Family Counter App");
            Console.WriteLine("---------------------------------------------");
        }

        public static string GetFamilyName()
        {
            Console.Write("What's name of the Family/Group: ");
            string output = Console.ReadLine();
            return output;
        }

        public static int GetNumberValue()
        {
            
            int output;
            bool isValid;

            do
            {
                Console.Write("How many members are in this family/group: ");
                string valueText = Console.ReadLine();
                isValid = int.TryParse(valueText, out output);
            } while (isValid == false);

            return output;
        }
        public static bool InputContinue()
        {
            string inputText = string.Empty;
            Console.Write("Another family/group to add Yes/No: ");
            inputText = Console.ReadLine();
            bool output = inputText.ToLower() != "no";
            return output;

            
        }

        public static (List<string> input , int numberFamily) GetUserInput()
        {
            List<string> input = new();
            int numberFamily = 0;

            do
            {
                input.Add(GetFamilyName());

                numberFamily += GetNumberValue();

            } while (InputContinue());

            return (input, numberFamily);

        }

        public static void DisplayFamily(List<string> input)
        {
            foreach (string name in input)
            {
                Console.WriteLine(name);
            }
          

        }

        public static void DisplayCounter(int numberFamily)
        {
            Console.WriteLine($"Total number in the family tree is: {numberFamily}");

            Console.WriteLine("\nThanks for using my app");

        }


    }
}
