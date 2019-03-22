﻿using System;

namespace WeaponShopAssign2
{
    class Program
    {
        static MyBST shop = new MyBST();
        static Player player;

        //prints the starting menu
        static void getPlayerInfo()
        {
            string playerName = getStringInput("Please Enter Your Name: ");
            int playerMoney = getIntInput("Enter how much gold you have: ");
            double playerMaxWeight = getDoubleInput("How much weight can you carry: ");
            player = new Player(playerName, playerMoney, playerMaxWeight);
        }

        //method that adds weapon to the shop
        static void addShopMerchandise()
        {
            Console.WriteLine("------ ADDING WEAPON TO THE SHOP ------");
            string choice = "";
            do
            {
                string weaponName = getStringInput("Enter the weapon name: ");
                int weaponRange = getIntInput("Enter the weapon range(1-10): ");
                int weaponDamage = getIntInput("Enter the weapon damage: ");
                double weaponWeight = getDoubleInput("Enter the weapon weight: ");
                double weaponCost = getDoubleInput("Enter the weapon price: ");
                shop.addWeapon(weaponName, weaponRange, weaponDamage, weaponWeight, weaponCost);
                choice = getStringInput("\nSuccessfully added the weapon to the shop!!\n\nIf you like to stop adding item to the shop, enter (end)!\n");
            } while (choice != "end");
        }

        //prints the player information
        static void printPlayerInfo()
        {
            Console.Clear();
            player.printCharacter();
        }

        //starting menu
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("----- WELCOME TO THE WORLD OF RAGNAROK -----");
            Console.WriteLine("\n1.) Add items to the shop\n2.) Delete item from the shop\n3.) Buy from the shop\n4.) View Backpack\n5.) View Player\n6.) Exit\n");
        }

        //buy weapon from the shop
        static void buyWeapon()
        {
            Console.WriteLine("----- BUYING WEAPON FROM THE SHOP -----\n");
            shop.displayWeapons();
            string name = getStringInput("Enter the Weapon name that you would like to buy: ");
            BSTNode w = shop.search(name);
            if (w != null)
            {
                Weapon weapon = w.weapon;
                if(w.quantity > 0)
                {
                    w.quantity--;
                    player.buyWeapon(w.weapon);
                    Console.WriteLine("Successfully bought the weapon {0} for {1} coins!!", weapon.name, weapon.cost);
                    player.money -= weapon.cost;
                }
                else
                {
                    Console.WriteLine("{0} is out of stock!", name);
                }
            }
            else
            {
                Console.WriteLine("{0} does not exist in this shop!", name);
            }

        }

        //view player backpack
        static void viewBackpack()
        {
            Console.WriteLine("----- VIEWING PLAYER BACKPACK -----");
            player.printBackpack();
        }

        //gets int input from the user
        static int getIntInput(string prompt)
        {
            int input;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out input));
            return input;
        }

        //get double input from the user
        static double getDoubleInput(string prompt)
        {
            double input;
            do
            {
                Console.Write(prompt);
            } while (!double.TryParse(Console.ReadLine(), out input));
            return input;
        }

        //gets string input from the user
        static string getStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        
        //gets a choice from the user from 1-6
        static int getChoice()
        {
            int choice;
            do
            {
                menu();
                choice = getIntInput("Input: ");
            } while (choice > 6 || choice < 1);
            return choice;
        }

        //run the program while user has not chosen to quit
        static void start()
        {
            int choice = getChoice();
            while (choice != 6)
            {
                run(choice);
                choice = getChoice();
            }
        }

        //the runs the function depending on the choice chosen by the user
        static void run(int choice)
        {
            Console.Clear();
            switch (choice)
            {
                case 1:
                    addShopMerchandise();
                    break;
                case 2:
                    break;
                case 3:
                    buyWeapon();
                    break;
                case 4:
                    viewBackpack();
                    break;
                case 5:
                    printPlayerInfo();
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            
            getPlayerInfo();
            start();
            Console.WriteLine("\nGOODBYE!");
            Console.ReadKey();
        }
    }
}
