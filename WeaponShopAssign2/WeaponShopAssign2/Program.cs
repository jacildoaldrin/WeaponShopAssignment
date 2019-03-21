using System;

namespace WeaponShopAssign2
{
    class Program
    {
        static  Shop bt = new Shop();
        static string playerName;
        
        //prints the starting menu
        public static void getPlayerInfo()
        {
            Console.WriteLine("----- WELCOME TO THE WORLD OF RAGNAROK -----");
            string playerName = getStringInput("Please Enter Your Name: ");
        }


        /*prints the menu
        static void shopMenu()
        {
            Console.WriteLine("Welcome to my Dictionary Software, please enter the number of the function you want to perform(1 - 6)");
            Console.WriteLine("\n1: Add a new word\n\n2: Delete Word\n\n3: Get Meaning\n\n4: Dictionary List\n\n5: Print Dictionary\n\n6: Exit\n");
            Console.Write("Entered Value: ");
        }

        //adds a word to the dictionary, and its meaning
        static void addWord()
        {
            Console.WriteLine("********** ADDING WORD **********\n");
            string word = getStringInput("Enter a word: ");
            string meaning = getStringInput("Enter the meaning of the word: ");

            dictionary.addWord(word, meaning);
        }

        //delete a word from the dictionary
        static void deleteWord()
        {
            Console.WriteLine("********** DELETING WORD **********\n");
            string word = getStringInput("Enter a word: ");
            dictionary.deleteWord(word);
        }
        //prints the meaning of the word entered by the user
        static void getMeaning()
        {
            Console.WriteLine("********** GETTING WORD MEANING **********\n");
            string word = getStringInput("Enter a word: ");
            string meaning = dictionary.getMeaning(word);
            if (meaning != "word not found")
            {
                Console.WriteLine("Meaning: " + meaning);
            }
            else
            {
                Console.WriteLine("\n" + meaning);
            }
        }

        //prints all the words in the dictionary
        static void printWordList()
        {
            Console.WriteLine("********** LISTING ALL WORDS IN THE DICTIONARY **********\n");
            Console.WriteLine(dictionary.printWordList());
        }

        //prints the dictionary
        static void printDictionary()
        {
            Console.WriteLine("********** LISTING ALL WORDS AND THEIR MEANING IN THE DICTIONARY **********\n");
            dictionary.printDictionary();
        }
        */


        //gets string input from the user
        static string getStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        /*
        public static void runProgram(int choice)
        {
            Console.Clear();
            switch (choice)
            {
                case 1:
                    addWord();
                    break;
                case 2:
                    deleteWord();
                    break;
                case 3:
                    getMeaning();
                    break;
                case 4:
                    printWordList();
                    break;
                case 5:
                    printDictionary();
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey();
            Console.Clear();
        }
        */
        static void Main(string[] args)
        {

            Shop s = new Shop();
            s.insert("Balmung", 10, 105, 150, 2000, 5);
            s.insert("Balmung", 10, 1055, 1540, 23000, 5);
            s.insert("Excalibur", 6, 140, 222, 5000, 5);
            s.insert("Ancients", 8, 103, 111, 4000, 2);
            s.inOrder();
            Console.ReadKey();
        }
    }
}
