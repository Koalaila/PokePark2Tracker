﻿using System;
using PokeCS;
using Items;

namespace PokePark2Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: List Pokemon");
                Console.WriteLine("2: List Items");
                Console.WriteLine("3: Exit");
                string? choice = Console.ReadLine();

                if (!string.IsNullOrEmpty(choice))
                {
                    try
                    {
                        if (choice == "1")
                        {
                            getPokedex();
                        }
                        else if (choice == "2")
                        {
                            getItems();
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
        static void getPokedex()
        {
            Console.WriteLine("Please enter a Pokemon number from 1-194: ");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                if (number >= 1 && number <= 194)
                {
                    try
                    {
                        var pokemon = PokemonTracker.GetPokemon(number);

                        if (pokemon != null)
                        {
                            Console.WriteLine($"You selected: {pokemon} ");
                        }
                        else
                        {
                            Console.WriteLine("No Pokémon found with this number.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving Pokémon: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Number out of range. Please enter a number between 1 and 194.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void getItems()
        {
            Console.WriteLine("Please enter an Item number from 1-32: ");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                if (number >= 1 && number <= 32)
                {
                    try
                    {
                        var item = ItemTracker.getItem(number);

                        if (item != null)
                        {
                            Console.WriteLine($"You selected: {item}");
                        }
                        else
                        {
                            Console.WriteLine("No Pokémon found with this number.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving item: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Number out of range. Please enter a number between 1 and 32.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}